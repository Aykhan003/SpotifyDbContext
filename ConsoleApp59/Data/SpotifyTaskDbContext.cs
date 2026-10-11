using ConsoleApp59.Methods;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp59.Data;

internal class SpotifyTaskDbContext : DbContext
{
    override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=localhost;Database=SpotifyTaskDb;Trusted_Connection=True;TrustServerCertificate=true;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Playlist>()
            .HasKey(p => new { p.UserId, p.MusicId });
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Music> Musics { get; set; }
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Categories> Categories { get; set; }
    public DbSet<Playlist> Playlists { get; set; }
}
