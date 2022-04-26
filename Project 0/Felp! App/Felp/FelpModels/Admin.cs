using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelpModels
{
    public class Admin 
    {
        private const string ac = "123456";
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email
        {
            get { return Email; }
            set { Email = value; }
        }
        public string Password { get; set; }
        public string Accesscode
        {
            get { return Accesscode; }
            set { Accesscode = ac; }
        }
    }
}
