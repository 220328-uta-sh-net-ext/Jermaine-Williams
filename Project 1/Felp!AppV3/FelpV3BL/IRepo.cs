using FelpV3Models;

namespace FelpV3BL;

public interface IRepo// business logic interface for Restaurants/Reviews
{
    List<Restaurant> SearchRestaurants(string searchString);// list of all restaurants to search all the restaurants with a string parameter "searchString"

    List<Restaurant> GetAllRestaurants(); // list of all restaurants to return the list of restaurants

    void AddRestaurant(Restaurant restaurantToAdd); // method to add a restaurant to the list

    void AddReview(int restaurantId, Review reviewToAdd); // method to add a review to a restaurant

    User AddUser(User newuser); // method that will add a new user to the list

    List<User> GetAllUsers();// list of all the users that are already added to the repo

    public List<User> GetUsername(string Username); // will retrive a username from the database for the login
}