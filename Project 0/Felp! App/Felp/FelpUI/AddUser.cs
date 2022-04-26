using FelpModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelpUI
{
    public class AddUser : IMenu
    {
        private static User newUser = new User(); //User is from your Models, newUser is the name of your User object

        public void Display()
        {
            Console.WriteLine("Enter your infomation below to make a new account:");
            Console.WriteLine("<1> Full name " + newUser.Fullname);
            Console.WriteLine("<2> Username " + newUser.Username);
            Console.WriteLine("<3> Email " + newUser.Email);
            Console.WriteLine("<4> Password " + newUser.Password);
            Console.WriteLine("Press <0> to go back to the main menu");
        }

        public string UserChoice()
        {
            string userinput = Console.ReadLine();

            switch (userinput)
            {
                case "1":

                    return "Enter your fullname";
                    
                    break;

                case "2":

                    return "Enter the username you would like to use         ";

                    break;

                case "3":

                    return "Enter your email";

                    break;

                case "4":

                    return "Enter the password you would like to use for this account";

                    break;

                default:

                    return " ";
                    
                    break;
            }


        }
    }
}
