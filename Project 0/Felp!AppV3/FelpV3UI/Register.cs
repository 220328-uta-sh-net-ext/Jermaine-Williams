using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FelpV3Models;
using FelpV3DL;

namespace FelpV3UI
{
    public class Register : IMenu
    {
        private static User newuser = new User();
        private SQLRepo userRepo = new SQLRepo();

        public void Display()
        {
            Console.WriteLine("Enter User Information: The info here are defaults\nYou can change them with your info if you hit the number on the left of them.");
            Console.WriteLine("<1> Fullname: " + newuser.Fullname);
            Console.WriteLine("<2> Username: " + newuser.Username);
            Console.WriteLine("<3> Password: " + newuser.Password);
            Console.WriteLine("<4> Email: " + newuser.Email);
            Console.WriteLine("Press <5> to save the infomation and return to the Welcome screen");
            Console.WriteLine("or Press <0> to return to the Welcome menu if you already have an account");
        }

        public string UserChoice()
        {
            Console.Clear();

            Display();

            string userInput = Console.ReadLine();
            switch (userInput)
            {

                case "1":
                    Console.WriteLine("Please your full name: ");
                    newuser.Fullname = Console.ReadLine();
                    return "Register";

                case "2":
                    Console.WriteLine("Please enter a username you would like to use: ");
                    newuser.Username = Console.ReadLine();
                    return "Register";

                case "3":
                    Console.WriteLine("Please enter a password you would like to use: ");
                    newuser.Password = Console.ReadLine();
                    return "Register";

                case "4":
                    Console.WriteLine("Please enter your email: ");
                    newuser.Email = Console.ReadLine();
                    return "Register";

                case "5":
                    userRepo.AddUser(newuser);
                    Console.WriteLine($"{newuser.Username} was added to the database");
                    Console.WriteLine("Going back the Welcome Menu");
                    return "Welcome";

                case "0":
                    return "Welcome";

                default:
                    Console.WriteLine("Please use the correct key");
                    Console.WriteLine("Press <Enter> to continue");
                    Console.ReadLine();
                    return "Register";
            }
        }
    }
}
