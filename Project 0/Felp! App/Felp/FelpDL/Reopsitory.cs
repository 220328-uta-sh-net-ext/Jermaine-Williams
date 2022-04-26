using FelpModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace FelpDL
{
    public class Repository : IRepository
    {
        private string filePath = "../FelpDL/Database/";
        private string jsonString;
        
        public Restaurant AddRestaurant(Restaurant rest) //serialization
        {
            var restaurants = GetAllRestaurants();
            restaurants.Add(rest);
            var restaurantString = JsonSerializer.Serialize<List<Restaurant>>(restaurants);
            File.WriteAllText(filePath + "Felp.json", restaurantString);
            return rest;
        }

        public List<Restaurant> GetAllRestaurants() //deserialization
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
                return JsonSerializer.Deserialize<List<Restaurant>>(jsonString);
            }
            else
                return null;
        
        }
    }
}
