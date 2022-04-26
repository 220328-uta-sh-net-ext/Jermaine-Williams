using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelpModels
{
    public class Restaurant
    {
        public string Name { get; set; }

        public string Location { get; set; }


        //Review -> foodrating, cleanrating, servicerating, returnrating, viberating, and reviewstatment
        private List<Review> _review;
        public List<Review> Review
        {
            get { return _review; }
            set { _review = value; }
        }
        //default restaurant constructor to add default values to the properties
        public Restaurant()
        {
            Name = "KFC";
            Location = "Kentucky";
            _review = new List<Review>()
            {
                new Review()
            };
        }

        public override string ToString()
        {
            return $"Name of Restaurant: {Name}\nLocation of Restaurant: {Location}\n";
        }
    }

}
