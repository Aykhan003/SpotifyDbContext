using Microsoft.EntityFrameworkCore;

namespace ConsoleApp59.Data;

internal class SpotifyTaskDbContext : DbContext
{
    override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=localhost;Database=SpotifyTaskDb;Trusted_Connection=True;TrustServerCertificate=true;");
    }

}
