using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelpModels
{
    public class Review 
    {

        public double _foodrating;

        public double foodrating
        {
            get { return _foodrating; }
            set
            {
                if (value >= 1 && value <= 5)
                    _foodrating = value;
                else
                    throw new Exception("You can't rate a restaurant's food lower than 1 or higher than 5");
            }
        }

        public double _servicerating;

        public double servicerating
        {
            get { return _servicerating; }
            set
            {
                if (value >= 1 && value <= 5)
                    _servicerating = value;
                else
                    throw new Exception("You can't rate a restaurant's service lower than 1 or higher than 5");
            }
        }

        public double _cleanrating;

        public double cleanrating
        {
            get { return _cleanrating; }
            set
            {
                if (value >= 1 && value <= 5)
                    _cleanrating = value;
                else
                    throw new Exception("You can't rate then cleanliness a restaurant lower than 1 or higher than 5");
            }
        }

        public double _viberating;

        public double viberating
        {
            get { return _viberating; }
            set
            {
                if (value >= 1 && value <= 5)
                    _viberating = value;
                else
                    throw new Exception("You can't rate a restaurant's atmosphere lower than 1 or higher than 5");
            }
        }

        public double _returnrating;

        public double returnrating
        {
            get { return _returnrating; }
            set
            {
                if (value >= 1 && value <= 5)
                    _returnrating = value;
                else
                    throw new Exception("You can't rate a restaurant's atmosphere lower than 1 or higher than 5");
            }
        }

        public string ReviewStatment { get; set; } 

        public Review()
        {
            _foodrating = 2;
            _cleanrating = 1;
            _servicerating = 2;
            _viberating = 1;
            _returnrating = 2;
            ReviewStatment = "This place is bad, I would never come back here.";
        }
    }
}
