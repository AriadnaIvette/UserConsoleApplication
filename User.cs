public class User
{
    public string Username {get; set;}
    public string Password {get; set;}
    public int Availability {get; set;}

    public User()
    {
        Username = "";
        Password = "";
        Availability = 0;
    }

    public User(string username, string password, int availability)
    {
        Username = username;
        Password = password;
        Availability = availability;
    }
}