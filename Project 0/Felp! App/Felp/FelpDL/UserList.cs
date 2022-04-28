using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using FelpModels;

namespace FelpDL
{
    public class UserList : IUserList
    {
        private string filePath = "../FelpDL/Database/";
        private string jsonString;

        public User AddNewUser(User user)
        {
            var allusers = GetAllUsers();
            allusers.Add(user);
            var userString = JsonSerializer.Serialize<List<UserList>>(allusers);
            File.WriteAllText(filePath + "Felp.json", userString);
            return user;
        }

        public List<UserList> GetAllUsers() //deserialization
        {
            try
            {
                jsonString = File.ReadAllText(filePath + "Felp.json");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Please check the path, " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check the file name,  " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (!string.IsNullOrEmpty(jsonString))
            {
                return JsonSerializer.Deserialize<List<UserList>>(jsonString);
            }
            else
                return null;

        }

        List<User> IUserList.GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
