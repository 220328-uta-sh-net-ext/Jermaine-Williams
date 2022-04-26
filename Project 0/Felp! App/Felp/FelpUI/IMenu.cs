using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelpUI
{
    public interface IMenu
    {
        void Display(); //will display the menu and user choices visually in the terminal 

        string UserChoice(); //will record the user's choise and change the menu based on that choice 
    }
}
