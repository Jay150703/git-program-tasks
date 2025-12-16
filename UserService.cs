public class UserService
{
    public void CreateUser()
    {
        // initial user creation logic
        // TODO : Add validation logic for user creation
    }
 HEAD
    public bool IsUserValid(string userName)
{
    if (userName == null)

public bool IsUserValid(string userName)
{
    if (userName.Length < 3)
 feature/length-check
        return false;

    return true;
}

}

