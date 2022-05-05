using FelpV3Models;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace FelpV3DL
{
    public class SQLRepo : ISQLRepo
    {
        private const string connectionStringFilePath = "../../../../FelpV3DL/ConnectionString.txt";
        private readonly string connectionString;

        public SQLRepo()
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

        public User AddUser(User newuser)
        {
            string commandString = "INSERT INTO Users (Fullname, Username, Email, Password) VALUES (@Fullname, @Username, @Email, @Password)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            //connection.Open();
            command.Parameters.AddWithValue("@Fullname", newuser.Fullname);
            command.Parameters.AddWithValue("@Username", newuser.Username);
            command.Parameters.AddWithValue("@Email", newuser.Email);
            command.Parameters.AddWithValue("@Password", newuser.Password);
            //command.Parameters.AddWithValue("@UserID", user.UserID);
            connection.Open();

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("That username is already taken");
                Console.WriteLine("Try to use another username");
            }   
            //using SqlDataReader reader = command.ExecuteReader();
            connection.Close();

            return newuser;
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

        public List<User> GetAllUsers()
        {
            string commandString = "SELECT * from User";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var users = new List<User>();
            while (reader.Read())
            {
                users.Add(new User
                {
                    Fullname = reader.GetString(0),
                    Username = reader.GetString(1),
                    Email = reader.GetString(2),
                    Password = reader.GetString(3),
                    //UserID = reader.GetInt32(4)
                });
            }
            return users;
        }

        public bool IsDuplicate(Restaurant restaurant)
        {
            return true;
        }

        public bool IsDuplicate(User newuser)
        {
            throw new NotImplementedException();
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
