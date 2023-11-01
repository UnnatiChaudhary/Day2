using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class Employees
    {
        int Id;
        string name;
        string manager;
        public void GetDetails()
        {
            Console.Write("Enter employee id: ");
            Id=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter employee name: ");
            name = Console.ReadLine();
            Console.Write("Who is the reporting manager: ");
            manager = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("Employee Id: " + Id);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Reporting Manager: " + manager);
        }
    }
}
