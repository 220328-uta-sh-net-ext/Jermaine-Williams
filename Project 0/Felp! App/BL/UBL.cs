using CustomExceptions;

namespace BL;
public class UBL : IUBL
{
    private readonly IUserRepo _dl;

    public UBL(IUserRepo repo)
    {
        _dl = repo;
    }

    /// <summary>
    /// adds a new user infomation to create a new user
    /// </summary>
    /// <param name="newuser"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public User AddUser(User newuser)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// gets all the users
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public List<User> GetAllUsers()
    {
        throw new NotImplementedException();
    }
}
