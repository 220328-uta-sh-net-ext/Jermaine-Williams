using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelpV3UI
{
    public class MainMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("This is the Main Menu");
        }

        public string UserChoice()
        {
            Display();
            return "1";
        }
    }
}
