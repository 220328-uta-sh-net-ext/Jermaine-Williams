using FelpModels;
using FelpDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FelpUI
{
    public class AddUser 
    {
        public static User newUser = new User(); //User is from your Models, newUser is the name of your User object

        //public void Display()
        //{
        //    Console.WriteLine("Enter your infomation below to make a new account:");
        //    Console.WriteLine("Your Full Name");
        //    Console.WriteLine("Your Username");
        //    Console.WriteLine("Your Email");
        //    Console.WriteLine("Press <0> to go back to the main menu");
        //}

        public static void AddingUser()
        {
            Console.WriteLine("Enter your infomation below to make a new account:");
            Console.WriteLine("Your Full Name");
            Console.WriteLine("Your Username");
            Console.WriteLine("Your Email");
            Console.WriteLine("Press <0> to go back to the main menu");

            string fullname = Console.ReadLine();
            string username = Console.ReadLine();
            string email = Console.ReadLine();

            Console.WriteLine(fullname);
            Console.WriteLine(username);
            Console.WriteLine(email);
            Console.WriteLine("If this infomation is correct Press <1>");
        }

        public string UserChoice()
        {
            string userinput = Console.ReadLine();

            switch (userinput)
            {
                case "1":
                    return "1";
                    break;

                case "0":
                    return "MainMenu";
                    break;

                default:
                    Console.WriteLine("Please enter a vaild response");
                    Console.WriteLine("Press <Enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";
                    break;
            }
        }

        //string userinput = Console.ReadLine();

        //    switch (userinput)
        //    {
        //        case "1":
        //            Console.WriteLine();
        //            break;

        //        case "0":
        //            return "MainMenu"
        //            break;
        //    }

    }
}
