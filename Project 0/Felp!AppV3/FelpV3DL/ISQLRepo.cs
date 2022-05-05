using FelpV3Models;

namespace FelpV3DL;


public interface ISQLRepo// repository interface for the restaurant/reviews
{
    List<Restaurant> GetAllRestaurants();// list of all restaurants that are already added to the repo

    void AddRestaurant(Restaurant restaurantToAdd);// method to add a restaurant

    void AddReview(int restaurantId, Review reviewToAdd);// method to add a review

    List<Restaurant> SearchRestaurants(string searchTerm);// list with a method with a string parameter that'll be used to search restaurants 

    bool IsDuplicate(Restaurant restaurant);// boolean to check if the restaurant has already been added or not

    User AddUser(User newuser); // method that will add a new user to the list

    List<User> GetAllUsers();// list of all the users that are already added to the repo

    bool IsDuplicate(User newuser);

}
