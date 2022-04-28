using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailListUI
{
    internal interface IMenu
    {
        public void Display();

        public string UserChoice();
    }
}
