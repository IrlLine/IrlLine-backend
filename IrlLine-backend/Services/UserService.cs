namespace IrlLine_backend;

public class UserService
{
    public static User GetAll()
    {
        return new User { UserName = "TestiKäyttäjä", Password = "TestiSalasana" };
    }

    public static User GetOneUser(string username)
    {
        return new User { UserName = username, Password = "TestiSalasana" };
    }
}
