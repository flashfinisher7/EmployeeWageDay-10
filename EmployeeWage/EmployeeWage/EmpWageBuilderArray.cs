using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWage : IComputeWage
    {
        private LinkedList<EmployeeClass> employeeClassList;

        public EmployeeWage()
        {
            this.employeeClassList = new LinkedList<EmployeeClass>();


        }

        internal void ComputeEmpWage()
        {
            throw new NotImplementedException();
        }

        public void AddCompanyEmpWage(string company, int wagePerHour, int maxHoursPerMonth, int maxWorkingDays)
        {
            EmployeeClass companyWage = new EmployeeClass(company, wagePerHour, maxHoursPerMonth, maxWorkingDays);
            this.employeeClassList.AddLast(companyWage);
        }

        public int ComputeEmpWage(EmployeeClass employeeClass)
        {
            int empHours = 0;
            int empDailyWage = 0;
            int workingDays = 0;
            int workingHrs = 0;



            Random rand = new Random();

            while (workingDays <= employeeClass.MaxWorkingDays && workingHrs <= employeeClass.MaxHoursPerMonth)
            {
                int number = rand.Next(0, 3);
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Employee is present for full-time");
                        empHours = 8;
                        workingDays++;
                        break;
                    case 2:
                        Console.WriteLine("Employee is present for part-time");
                        empHours = 4;
                        workingDays++;
                        break;
                    default:
                        Console.WriteLine("Employee is absent");
                        break;

                }
                empDailyWage = empHours * employeeClass.WagePerHour;
                employeeClass.TotalEmpWage += empDailyWage;
                workingHrs += empHours;

            }
            Console.WriteLine("Company Name:" + employeeClass.Company);
            Console.WriteLine("Employee Working Hours :" + workingHrs);
            Console.WriteLine("Employee Wage Per day :" + empDailyWage);
            Console.WriteLine("Employee Working days in month :" + workingDays);
            Console.WriteLine("Employee Wage for working days :" + employeeClass.TotalEmpWage);
            Console.WriteLine("Total  wage for " + employeeClass.Company + " is " + employeeClass.TotalEmpWage);
            return workingDays * employeeClass.WagePerHour;
        }

        void IComputeWage.ComputeEmpWage()
        {
            throw new NotImplementedException();
        }
    }
}