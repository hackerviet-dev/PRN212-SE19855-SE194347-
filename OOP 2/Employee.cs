using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public class Employee
    {
        public int Id { get; set; } 
        public string IdCard { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public virtual double calSalary()
        {
            return 4000000; // Phương thức này có thể được ghi đè trong các lớp con
        }
        public override string ToString()
        {
            return Id +"\t" + IdCard + "\t" + Name + "\t" + Birthday.ToString("dd/mm/yy") + "\t" + calSalary();
        }
    }
}
