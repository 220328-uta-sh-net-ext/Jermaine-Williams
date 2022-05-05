using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FelpV3BL;
using FelpV3DL;
using FelpV3Models;

namespace FelpV3UI
{
    public class Login : IMenu
    {
        private SQLRepo userRepo = new SQLRepo();
        readonly Repo bL;

        public Login(Repo bL)
        {
            this.bL = bL;
        }
        public void Display()
        {
            Console.WriteLine("Please enter your Username");
            Console.WriteLine("Press <1> to login");
            Console.WriteLine("or Press <0> to go back to the Welcome Screen");
        }

        public string UserChoice()
        {
            Display();

            string userinput = Console.ReadLine();

            switch (userinput)
            {
                case "1":
                    return "Enter your Username: ";
                    string username = Console.ReadLine();

                    List<User> nameResult = bL.GetUsername(username);

                    if (nameResult.Count == 0)
                    {
                        return "You need to enter your Username";
                        goto case "1";
                    }
                    else if (nameResult.Count > 0)
                    {
                        return "MainMenu";
                    }
                    else
                    {
                        return "Your Username is incorrect, please re-enter it";
                        goto case "1";
                    }
                default:
                    Console.WriteLine("Response not acceptable");
                    Console.WriteLine("To continue press <enter> to continue");
                    Console.ReadLine();
                    return "Welcome";
            }

        }
    }
}
