using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome This is a Employee Wage problem");
            EmpWageBuilderArray emp1 = new EmpWageBuilderArray();
            emp1.AddCompanyEmpWage("bmw", 20, 2, 100);
            emp1.AddCompanyEmpWage("tata", 30, 4, 200);
            emp1.ComputeEmpWage();

        }
    }
}
