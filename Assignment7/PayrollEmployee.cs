using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    internal class PayrollEmployee:Employees
    {
        string date;
        public int exp;
        public int salary;
         public int da;
         public double hra;
        public double netSalary;
        public PayrollEmployee()
        {
            
        }
        public void GetDetails()
        {
            base.GetDetails();
            Console.Write("Enter date: ");
            date = Console.ReadLine();
            Console.Write("Enter Experience in years: ");
            exp=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter dearance allowance: ");
            da= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter hra: ");
            hra = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("Net Salary is: " + netSalary);
        }
    }
}
