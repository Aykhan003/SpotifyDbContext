namespace ConsoleApp59.Methods;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Username { get; set; }
    public string Password
    {
        get { return field; }
        set
        {
            if (field.Length < 8)
            {
                throw new ArgumentException("Password must be at least 8 characters long.");
            }
            if (!value.Any(char.IsUpper))
            {
                throw new ArgumentException("Password must contain at least one uppercase letter.");
            }
            if (!value.Any(char.IsLower))
            {
                throw new ArgumentException("Password must contain at least one lowercase letter.");
            }
            if (!value.Any(char.IsDigit))
            {
                throw new ArgumentException("Password must contain at least one digit.");
            }
            if (!value.Any(ch => !char.IsLetterOrDigit(ch)))
            {
                throw new ArgumentException("Password must contain at least one special character.");
            }
            field = value;
        }
    }
    public string Gender
    {
        get { return field; }
        set
        {
            if (value != "Male" && value != "Female" && value != "Other")
            {
                throw new ArgumentException("Gender must be either 'Male' or 'Female' or 'Other'.");
            }
            field = value;
        }
    }
    public List<Playlist> Playlists { get; set; }
}
