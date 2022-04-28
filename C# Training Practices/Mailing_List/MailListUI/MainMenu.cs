using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailListUI
{
    public class MainMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to the Target Mailing List!");
            Console.WriteLine("Press <1> to start the aplliaction to be up on the mailing list");
            Console.WriteLine("Press <0> to exit the app");
        }

        public string UserChoice()
        {
            string userinput = Console.ReadLine();
            
            switch (userinput)
            {
                case "1":
                    return "NewUser";
                    break;

                case "0":
                    return "Exit";
                    break;

                default:
                    Console.WriteLine("Please enter a vaild response");
                    Console.WriteLine("Press <Enter> to continue");
                    Console.ReadLine();
                    return "MainMenu";
                    break;
            }
        }
    }
}
