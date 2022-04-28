using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FelpModels;

namespace FelpDL
{
    public interface IRepository
    {
        /// <summary>
        /// add a restaurant to database
        /// </summary>
        /// <param name="rest"></param>
        /// <returns>the restaurant added</returns>
        Restaurant AddRestaurant(Restaurant rest);

        /// <summary>
        /// will return all the restaurants from the database
        /// </summary>
        /// <returns>returns a collection of restaurants as generic list</returns>
        List<Restaurant> GetAllRestaurants();
    }
}
