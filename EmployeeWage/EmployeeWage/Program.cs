using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome This is a Employee Wage problem");
            EmployeeClass Tcs = new EmployeeClass("TCS", 77, 30, 150);
            EmployeeClass Wipro = new EmployeeClass("Wipro", 57, 27, 100);
            Tcs.CompanyEmpWage();
            Console.WriteLine(Tcs.ToString());
            Wipro.CompanyEmpWage();
            Console.WriteLine(Wipro.ToString());
        }
    }
}
