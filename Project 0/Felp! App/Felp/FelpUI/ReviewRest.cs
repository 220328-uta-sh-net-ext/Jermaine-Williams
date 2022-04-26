using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelpUI
{
    public class ReviewRest : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Enter your infomation below to make a new account:");
            Console.WriteLine("<1> Full name ");
            Console.WriteLine("<2> Username " );
            Console.WriteLine("Press <0> to go back to the main menu");
        }

        public string UserChoice()
        {
            throw new NotImplementedException();
        }
    }
}
