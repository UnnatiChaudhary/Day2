namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
           PayrollEmployee employees = new PayrollEmployee();
            
            int pf;
            int cnt=1;
            char ch = 'y';
      
            while (ch == 'y')
            {
                employees.GetDetails();
                if (employees.exp > 10)
                {
                    employees.da = (10 * (employees.salary)) / 100;
                    employees.hra = (8.5 * (employees.salary)) / 100;
                    pf = 6200;
                    employees.netSalary = (employees.da + employees.hra + employees.salary) - pf;
                }
                Console.WriteLine();
                employees.Display();
                Console.WriteLine("Do you want to continue? ");
                ch = Convert.ToChar(Console.ReadLine());
                if (ch == 'y') { cnt++; }
            }      
            Console.WriteLine("Total number of employees  are: "+cnt);
        }
    }
}