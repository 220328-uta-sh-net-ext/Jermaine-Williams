using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FelpDL;
using FelpModels;

namespace FelpUI
{
    internal class RestaurantOperations
    {
        static Repository repo = new Repository();

        public static void GetAllRestaurants()
        {
            repo.GetAllRestaurants();
        }
        public static void AddDummyRestaurant()
        {
            Restaurant restaurant1 = new Restaurant()
            {
                Name = "Burger King",
                Location = "Florida",
                Review = new List<Review>()
                {
                    new Review()
                    {
                        _foodrating = 4,
                        _cleanrating = 4,
                        _returnrating = 4,
                        _servicerating = 4,
                        _viberating = 4,
                    }
                }
            };

            repo.AddRestaurant(restaurant1);
        }
    }
}
