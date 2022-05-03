using System.Collections.Generic;
using Models;
using System.Data.SqlClient;

namespace DL
{
    public class UserSQLRepo : IUserRepo
    {
        private const string connectionStringFilePath = "../../../../DL/ConnectionString.txt";
        private readonly string connectionString;

        public UserSQLRepo()
        {
            connectionString = File.ReadAllText(connectionStringFilePath);
        }

        public User AddUser(User newuser)
        {
            string commandString = "INSERT INTO Users (Fullname, Username, Email, UserID) VALUES (@Fullname, @Username, @Email, @UserID)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            connection.Open();
            command.Parameters.AddWithValue("@Fullname", newuser.Fullname);
            command.Parameters.AddWithValue("@Username", newuser.Username);
            command.Parameters.AddWithValue("@Email", newuser.Email);
            command.Parameters.AddWithValue("@UserID", newuser.UserID);
            command.ExecuteNonQuery();
            using SqlDataReader reader = command.ExecuteReader();

            return newuser;
        }

        public List<User> GetAllUsers()
        {
            string commandString = "SELECT Firstname, Username, Email, UserID from Users";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var users = new List<User>();
            while (reader.Read())
            {
                User user = new User { Fullname = reader.GetString(0) };
            }
            return users;
        }

        public bool IsDuplicate(User newuser)
        {
            return true;
        }
    }
}
