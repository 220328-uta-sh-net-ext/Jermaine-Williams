using Models;

namespace DL;


public interface IRestaurantRepo// repository interface for the restaurant/reviews
{
    List<Restaurant> GetAllRestaurants();// list of all restaurants that are already added to the repo

    void AddRestaurant(Restaurant restaurantToAdd);// method to add a restaurant

    void AddReview(int restaurantId, Review reviewToAdd);// method to add a review

    List<Restaurant> SearchRestaurants(string searchTerm);// list with a method with a string parameter that'll be used to search restaurants 

    bool IsDuplicate(Restaurant restaurant);// boolean to check if the restaurant has already been added or not
}
