using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FelpModels;
using FelpDL;

namespace FelpUI
{
    public class AddRest
    {
        public static Restaurant newrestaurant = new Restaurant();

        public static void AddingRest()
        {
            Console.Clear();

            List<string> AllRestaurants = new List<string>();

            Console.WriteLine("Enter the infomation to add a restaurant to the list of restaurant to be reivewed:");
            Console.WriteLine("Their Name:");
            Console.WriteLine("Their Location:");
            Console.WriteLine("Their Food Type:");

            string foodname = Console.ReadLine();
            string location = Console.ReadLine();
            string foodtype = Console.ReadLine();

            Console.WriteLine($"Full Name: {foodname}");
            Console.WriteLine($"Username: {location}");
            Console.WriteLine($"Email: {foodtype}");
            Console.WriteLine("If this infomation is correct Press <1>");

            string userinput = Console.ReadLine();

            if (userinput == "1")
            {
                AllRestaurants.Add(foodname);
                AllRestaurants.Add(location);
                AllRestaurants.Add(foodtype);
                Console.WriteLine($"Adding the info to the Database\n Welcome {foodname} to Felp!");
            }
        }
    }
}
