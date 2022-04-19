using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelpModels
{
    public class Restaurant
    {
        private const decimal sr = 10;

        public string Name { get; set; }
        public string Location { get; set; }
        public decimal StarRating
        {
            get { return StarRating; }
            set { StarRating = sr; }
        }
    }
}
