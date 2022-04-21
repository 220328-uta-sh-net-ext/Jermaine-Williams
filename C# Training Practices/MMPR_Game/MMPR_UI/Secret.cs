using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMPR_UI
{
    public class Secret : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Alpha 6: Welcome to the secret room! This is even hidden from Zordon");
            Console.WriteLine("Alpha 6: Please enter a secret code if you have one, you just might unlock an all new power!");
            string sc = "GWE";
            string sc2 = "WLT";
        }

        public string UserChoice()
        {
            throw new NotImplementedException();
        }
    }
}
