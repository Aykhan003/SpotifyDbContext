using ConsoleApp59.Data;
using ConsoleApp59.Methods;
using ConsoleApp59.Service;
#region CreateUsers
//var context = new SpotifyTaskDbContext();
//var userService = new UserService(context);
//var newUser = new User
//{
//    Name = "John Doe",
//    Surname = "Smith",
//    Username = "johnsmith",
//    Password = "Password123!",
//    Gender = "Male"
//};
//await userService.AddUserAsync(newUser);
//Console.WriteLine("User added successfully.");
//var newUser2 = new User
//{
//    Name = "Jane Doe",
//    Surname = "Foster",
//    Username = "janefoster",
//    Password = "Password123!",
//    Gender = "Female"
//};
//await userService.AddUserAsync(newUser2);
//Console.WriteLine("User added successfully.");
//var newUser3 = new User
//{
//    Name = "Alex",
//    Surname = "Lopez",
//    Username = "alexlopez",
//    Password = "Password123!",
//    Gender = "Male"
//};
//await userService.AddUserAsync(newUser3);
//Console.WriteLine("User added successfully.");
//var newUser4 = new User
//{
//    Name = "Sam",
//    Surname = "Rogers",
//    Username = "samrogers",
//    Password = "Password123!",
//    Gender = "Male"
//};
//await userService.AddUserAsync(newUser4);
//Console.WriteLine("User added successfully.");
//var newUser5 = new User
//{
//    Name = "Taylor",
//    Surname = "Adams",
//    Username = "tayloradams",
//    Password = "Password123!",
//    Gender = "Female"
//};
//await userService.AddUserAsync(newUser5);
//Console.WriteLine("User added successfully.");
//var newUser6 = new User
//{
//    Name = "Jordan",
//    Surname = "Miller",
//    Username = "jordanmiller",
//    Password = "Password123!",
//    Gender = "Male"
//};
//await userService.AddUserAsync(newUser6);
//Console.WriteLine("User added successfully.");
//var newUser7 = new User
//{
//    Name = "Morgan",
//    Surname = "Vega",
//    Username = "morganvega",
//    Password = "Password123!",
//    Gender = "Female"
//};
//await userService.AddUserAsync(newUser7);
//Console.WriteLine("User added successfully.");
//var newUser8 = new User
//{
//    Name = "Casey",
//    Surname = "Edwards",
//    Username = "caseyedwards",
//    Password = "Password123!",
//    Gender = "Female"
//};
//await userService.AddUserAsync(newUser8);
//Console.WriteLine("User added successfully.");
//var newUser9 = new User
//{
//    Name = "Riley",
//    Surname = "Brown",
//    Username = "rileybrown",
//    Password = "Password123!",
//    Gender = "Male"
//};
//await userService.AddUserAsync(newUser9);
//Console.WriteLine("User added successfully.");
//var newUser10 = new User
//{
//    Name = "Jamie",
//    Surname = "Nelson",
//    Username = "jamienelson",
//    Password = "Password123!",
//    Gender = "Male"
//};
//await userService.AddUserAsync(newUser10);
//Console.WriteLine("User added successfully.");
//var newUser11 = new User
//{
//    Name = "Avery",
//    Surname = "Sanders",
//    Username = "averysanderson",
//    Password = "Password123!",
//    Gender = "Female"
//};
//await userService.AddUserAsync(newUser11);
//Console.WriteLine("User added successfully.");
//var newUser12 = new User
//{
//    Name = "Peyton",
//    Surname = "Sellers",
//    Username = "peytonsellers",
//    Password = "Password123!",
//    Gender = "Other"
//};
//await userService.AddUserAsync(newUser12);
//Console.WriteLine("User added successfully.");
#endregion
#region CreateMusics
var context = new SpotifyTaskDbContext();
var musicService = new MusicService(context);
var newMusic = new Music
{
    Name = "Song Title",
    Duration = 180,
    ArtistId = 1,
    CategoryId = 1
};
await musicService.AddMusicAsync(newMusic);
Console.WriteLine("Music added successfully.");
var newMusic2 = new Music
{
    Name = "Another Song",
    Duration = 200,
    ArtistId = 2,
    CategoryId = 2
};
await musicService.AddMusicAsync(newMusic2);
Console.WriteLine("Music added successfully.");