public class LoginService
{
    public bool Login(string username, string password)
    {
        if (username == null || password == null)
            return false;

        return true;
    }
}

