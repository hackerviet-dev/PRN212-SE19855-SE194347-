using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public class PartTimeEmployee:Employee

    {
        public int WorkingHours { get; set; } // Số giờ làm việc
        public override double calSalary()
        {
            return 100000 * WorkingHours; // Lương theo giờ làm việc
        }
    }
}
