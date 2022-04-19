using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelpModels
{
    public interface IUser //interface where everyhting i want shared to this will be inherited 
    {
        string Name { get; set; }
        string Username { get; set; }
        string Email { get; set; }
        string Password { get; set; }
    }
}
