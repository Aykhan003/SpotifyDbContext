namespace ConsoleApp59.Methods;

public class Artist
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime Birthday
    {
        get { return field; }
        set
        {
            if (value > DateTime.Now)
            {
                throw new ArgumentException("Birthday cannot be in the future.");
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
}
