using OOP_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Reuse
{
    public static class YourUtils
    {
        public static int TinhTuoi(this Employee emp)
        {
            return DateTime.Now.Year - emp.Birthday.Year+1;
        }
    }
}
