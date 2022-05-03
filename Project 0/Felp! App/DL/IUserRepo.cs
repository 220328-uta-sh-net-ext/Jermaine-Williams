using Models;

namespace DL;

public interface IUserRepo //repository interface for the users
{
    User AddUser(User newuser); // method that will add a new user to the list

    List<User> GetAllUsers();// list of all the users that are already added to the repo

    bool IsDuplicate(User newuser);
}