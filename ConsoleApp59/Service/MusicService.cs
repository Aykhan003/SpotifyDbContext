using ConsoleApp59.Data;
using ConsoleApp59.Methods;
using Microsoft.EntityFrameworkCore;
namespace ConsoleApp59.Service;

public class MusicService
{
    private readonly SpotifyTaskDbContext _context;

    public MusicService(SpotifyTaskDbContext context)
    {
        _context = context;
    }
    public async Task<List<Music>> GetAllMusicsAsync()
    {
        return await _context.Musics.ToListAsync();
    }
    public async Task<Music> GetMusicByIdAsync(int id)
    {
        return await _context.Musics.FindAsync(id);
    }
    public async Task AddMusicAsync(Music music)
    {
        _context.Musics.Add(music);
        await _context.SaveChangesAsync();
    }
    public async Task UpdateMusicAsync(Music music)
    {
        _context.Musics.Update(music);
        await _context.SaveChangesAsync();
    }
    public async Task DeleteMusicAsync(int id)
    {
        var music = await _context.Musics.FindAsync(id);
        if (music != null)
        {
            _context.Musics.Remove(music);
            await _context.SaveChangesAsync();
        }
    }
    public async Task<List<Music>> GetMusicsByArtistIdAsync(int artistId)
    {
        return await _context.Musics.Where(m => m.ArtistId == artistId).ToListAsync();
    }
    public async Task<List<Music>> GetMusicsByCategoryIdAsync(int categoryId)
    {
        return await _context.Musics.Where(m => m.CategoryId == categoryId).ToListAsync();
    }
    public async Task<List<Music>> GetMusicsByUserIdAsync(int userId)
    {
        return await _context.Playlists
            .Where(p => p.UserId == userId)
            .Select(p => p.Music)
            .ToListAsync();
    }
    public async Task<List<Music>> GetMusicsByUserIdAndCategoryIdAsync(int userId, int categoryId)
    {
        return await _context.Playlists
            .Where(p => p.UserId == userId && p.Music.CategoryId == categoryId)
            .Select(p => p.Music)
            .ToListAsync();
    }
    public async Task<List<Music>> GetMusicsByUserIdAndArtistIdAsync(int userId, int artistId)
    {
        return await _context.Playlists
            .Where(p => p.UserId == userId && p.Music.ArtistId == artistId)
            .Select(p => p.Music)
            .ToListAsync();
    }
    public async Task<List<Music>> GetMusicsByUserIdAndCategoryIdAndArtistIdAsync(int userId, int categoryId, int artistId)
    {
        return await _context.Playlists
            .Where(p => p.UserId == userId && p.Music.CategoryId == categoryId && p.Music.ArtistId == artistId)
            .Select(p => p.Music)
            .ToListAsync();
    }
    public async Task<List<Music>> GetMusicsByCategoryIdAndArtistIdAsync(int categoryId, int artistId)
    {
        return await _context.Musics
            .Where(m => m.CategoryId == categoryId && m.ArtistId == artistId)
            .ToListAsync();
    }
    public async Task<List<Music>> GetMusicsByCategoryIdAndUserIdAsync(int categoryId, int userId)
    {
        return await _context.Playlists
            .Where(p => p.UserId == userId && p.Music.CategoryId == categoryId)
            .Select(p => p.Music)
            .ToListAsync();
    }
}
