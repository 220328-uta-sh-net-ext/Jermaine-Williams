using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMPR_UI
{
    public class CharacterSelect : IMenu
    {
        Secret menu = new Secret();
        public void Display()
        {
            Console.WriteLine("Welcome to the Mighty Morphin Power Rangers Game Made in C#!");
            Console.WriteLine("Please enter your name: ");

            string name = Console.ReadLine();

            Console.WriteLine($"Awesome, Hello {name}, and welcome to Angel Grove, the most peaceful place in California");
            Console.WriteLine("Please choose a character to defend the town with:");

            Console.WriteLine("Press <1> to play as the leader of the team: the Red Ranger, Jason Lee Scott");
            Console.WriteLine("Press <2> to play as the most intelligent of the team: the Blue Ranger, Billy Cranston");
            Console.WriteLine("Press <3> to play as the strongest of the team: the Black Ranger, Zack Taylor");
            Console.WriteLine("Press <4> to play as the wildcard of the team: the Yellow Ranger, Trini Kwan");
            Console.WriteLine("Press <5> to play as the  of the team: the Pink Ranger, Kimberly Ann Hart");
            Console.WriteLine("...or if you have a secret code, Press <6> to enter it");
        }

        public string UserChoice()
        {
            string z = Console.ReadLine();

            switch (z)
            {
                case "1":
                    return "Red Ranger";
                    Console.WriteLine("Red");
                    break;

                case "2":
                    return "Blue Ranger";
                    Console.WriteLine("Blue");
                    break;

                case "3":
                    return "Black Ranger";
                    Console.WriteLine("Black");
                    break;

                case "4":
                    return "Yellow Ranger";
                    Console.WriteLine("Yellow");
                    break;

                case "5":
                    return "Pink Ranger";
                    Console.WriteLine("Pink");
                    break;

                case "6":
                    return "";
                    menu = new Secret();
                    break;

                default:
                    return "MainMenu";
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press <enter> to continue");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
