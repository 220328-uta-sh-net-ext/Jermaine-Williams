using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FelpModels;

namespace FelpDL
{
    public interface IUserList
    {
        /// <summary>
        /// add a user to database
        /// </summary>
        /// <param name="user"></param>
        /// <returns>the user added</returns>
        User AddNewUser(User user);

        /// <summary>
        /// will return all the users from the database
        /// </summary>
        /// <returns>returns a collection of user as generic list</returns>
        List<User> GetAllUsers();
    }

}
