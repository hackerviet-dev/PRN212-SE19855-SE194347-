using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Customer
    {
        // cach viet poco
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public void PrintInfor()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Customer ID: {Id}");
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Email = {Email}");
            Console.WriteLine($"Phone = {Phone}");
            Console.WriteLine($"Address = {Address}");
            Console.WriteLine("----------------------------------");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
