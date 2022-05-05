using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelpV3UI
{
    public class Welcome : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to Felp!");
            Console.WriteLine("Press <1> to login");
            Console.WriteLine("Press <2> to register for an account");
            Console.WriteLine("Press <0> to exit the app");
        }

        public string UserChoice()
        {
            //Display();
            string userinput = Console.ReadLine();

            switch (userinput)
            {
                case "1":
                    return "Login";
                    break;

                case "2":
                    return "Register";
                    break;

                case "0":
                    return "Exit";
                    break;

                default:
                    Console.WriteLine("Please enter a vaild response");
                    Console.WriteLine("Press <Enter> to continue");
                    Console.ReadLine();
                    return "Welcome";
                    break;
            }
        }
    }
}
