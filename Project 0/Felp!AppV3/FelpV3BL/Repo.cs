using CustomExceptions;
using FelpV3DL;
using FelpV3Models;

namespace FelpV3BL;
public class Repo : IRepo// this class is inheriting the IBL interface 
{
    private readonly ISQLRepo dl;// readable variable that refers to the repo interface

    public Repo(ISQLRepo repo)
    {
        dl = repo;
    }



    /// <summary>
    /// Gets all restaurants
    /// </summary>
    /// <returns>list of all restaurants</returns>

    public List<Restaurant> GetAllRestaurants()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Adds a new restaurant to the list
    /// This method will check for the duplicate record before persisting
    /// </summary>
    /// <param name="restaurantToAdd">restaurant object to add</param>
    /// <exception cref="DuplicateRecordException">When there is a restaurant that already exists</exception>

    public void AddRestaurant(Restaurant restaurantToAdd)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Adds a new review to the restaurant that exists on that index
    /// </summary>
    /// <param name="restaurantId">index of the restaurant to leave a review for</param>
    /// <param name="reviewToAdd">a review object to be added to the restaurant</param>

    public void AddReview(int restaurantId, Review reviewToAdd)
    {
        throw new NotImplementedException();
    }

    public List<Restaurant> SearchRestaurants(string searchTerm)
    {
        throw new NotImplementedException();
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

    /// <summary>
    /// gets the username from the DB and check if there's a duplicate or not
    /// </summary>
    /// <param name="Username"></param>
    /// <returns></returns>
    public List<User> GetUsername(string Username)
    {
        List<User> users = dl.GetAllUsers();
        var filteredUsernames = users.Where(user => user.Username.ToLower().Contains(Username)).ToList();
        return filteredUsernames;
    }
}


