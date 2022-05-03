namespace BL;

public interface IUBL // business logic interface for Users
{
    User AddUser(User newuser); // method that will add a new user to the list

    List<User> GetAllUsers();// list of all the users that are already added to the repo
}

