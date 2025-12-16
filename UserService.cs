public class UserService
{
    public void CreateUser()
    {
        // initial user creation logic
        // TODO : Add validation logic for user creation
    }
public bool IsUserValid(string userName)
{
    if (userName.Length < 3)
        return false;

    return true;
}

}

