namespace BL;

public interface IRRBL// business logic interface for Restaurants/Reviews
{
    List<Restaurant> SearchRestaurants(string searchString);// list of all restaurants to search all the restaurants with a string parameter "searchString"

    List<Restaurant> GetAllRestaurants(); // list of all restaurants to return the list of restaurants

    void AddRestaurant(Restaurant restaurantToAdd); // method to add a restaurant to the list

    void AddReview(int restaurantId, Review reviewToAdd); // method to add a review to a restaurant

}