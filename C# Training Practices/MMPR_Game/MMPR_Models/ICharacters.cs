using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMPR_Models
{
    public interface ICharacters
    {
        string Name { get; set; }
        int baseattack { get; set; }
        int speed { get; set; }
        int energy { get; set; }

        public void Move_1()
        {
            
        }
        public void Move_2()
        {

        }
        public void Move_3()
        {

        }
        public void Move_4()
        {

        }
    }
}
