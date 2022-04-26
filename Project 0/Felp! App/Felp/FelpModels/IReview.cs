using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelpModels
{
    public interface IReview
    {
        string Review { get; set; }

        int Rating { get; set; }
    }
}
