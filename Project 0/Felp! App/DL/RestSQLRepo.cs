using Models;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace DL
{
    public class RestSQLRepo : IRestaurantRepo
    {
        private const string connectionStringFilePath = "../../../../DL/ConnectionString.txt";
        private readonly string connectionString;

        public RestSQLRepo()
        {
            connectionString = File.ReadAllText(connectionStringFilePath);
        }
        public void AddRestaurant(Restaurant restaurantToAdd)
        {
            string commandString = "INSERT INTO Restaurants (Name, City, State, RestID) VALUES (@Name, @City, @State, @RestID)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            connection.Open();
            command.Parameters.AddWithValue("@Name", restaurantToAdd.Name);
            command.Parameters.AddWithValue("@City", restaurantToAdd.City);
            command.Parameters.AddWithValue("@State", restaurantToAdd.State);
            command.Parameters.AddWithValue("@RestID", restaurantToAdd.RestID);
            command.ExecuteNonQuery();
            using SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine(restaurantToAdd);
        }

        public void AddReview(int restaurantID, Review reviewToAdd)
        {
            string commandString = "INSERT INTO Review (ReviewID, Rating, RestaurantID, Note) VALUES (@ReviewID, @Rating, @RestaurantID, @Note)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            connection.Open();
            command.Parameters.AddWithValue("@ReviewID", reviewToAdd.ReviewID);
            command.Parameters.AddWithValue("@Rating", reviewToAdd.Rating);
            command.Parameters.AddWithValue("@RestaurantID", reviewToAdd.RestaurantID);
            command.Parameters.AddWithValue("@Note", reviewToAdd.Note);
            command.ExecuteNonQuery();
            using SqlDataReader reader = command.ExecuteReader();

            Console.WriteLine(reviewToAdd);
        }

        public List<Restaurant> GetAllRestaurants()
        {
            string commandString = "SELECT Name, City, State, RestID from Restaurants";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var restaurants = new List<Restaurant>();
            while (reader.Read())
            {
                Restaurant rest = new Restaurant { Name = reader.GetString(0) };
            }
            return restaurants;
        }

        public bool IsDuplicate(Restaurant restaurant)
        {
            return true;
        }

        public List<Restaurant> SearchRestaurants(string searchTerm)
        {
            string commandString = "SELECT Name, City, State, RestID from Restaurants";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var restaurants = new List<Restaurant>();
            while (reader.Read())
            {
                Restaurant rest = new Restaurant { Name = reader.GetString(0) };
            }
            return restaurants;
        }
    }
}
