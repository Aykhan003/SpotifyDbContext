namespace ConsoleApp59.Methods;

public class Music
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Duration { get; set; }
    public int ArtistId { get; set; }
    public Artist Artist { get; set; }
    public int CategoryId { get; set; }
    public Categories Category { get; set; }
    public List<Playlist> Playlists { get; set; }
}
