using ConsoleApp59.Data;
using ConsoleApp59.Methods;
using Microsoft.EntityFrameworkCore;
namespace ConsoleApp59.Service;

public class ArtistService
{
    private readonly SpotifyTaskDbContext _context;

    public ArtistService(SpotifyTaskDbContext context)
    {
        _context = context;
    }
    public async Task<List<Artist>> GetAllArtistsAsync()
    {
        return await _context.Artists.ToListAsync();
    }
    public async Task<Artist> GetArtistByIdAsync(int id)
    {
        return await _context.Artists.FindAsync(id);
    }
    public async Task AddArtistAsync(Artist artist)
    {
        _context.Artists.Add(artist);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateArtistAsync(Artist artist)
    {
        _context.Artists.Update(artist);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteArtistAsync(int id)
    {
        var artist = await _context.Artists.FindAsync(id);
        if (artist != null)
        {
            _context.Artists.Remove(artist);
            await _context.SaveChangesAsync();
        }
    }
}
