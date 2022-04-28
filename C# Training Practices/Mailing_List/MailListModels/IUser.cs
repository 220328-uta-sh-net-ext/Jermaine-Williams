using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailListModels
{
    internal interface IUser
    {
        string Name { get; set; }
        string Email { get; set; }
        string Location { get; set; }
    }
}
