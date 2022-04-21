using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMPR_UI
{
    public class MainMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to the Mighty Morphin Power Rangers Game Made in C#!");
            Console.WriteLine("Press <1> to start the game");
            Console.WriteLine("Press <0> to exit the app");
        }

        public string UserChoice()
        {
            string userinput = Console.ReadLine();

            switch (userinput)
            {
                case "1":
                    return "";
                    menu = new MainMenu();
                    break;

                case "0":
                    return "Exit";
                    break;

                default:
                    Console.WriteLine("Please enter the correct key to start the game");
                    Console.WriteLine("Please try again");
                    Console.ReadLine();
                    return "MainMenu";
                    break;
            }
        }
    }
}
