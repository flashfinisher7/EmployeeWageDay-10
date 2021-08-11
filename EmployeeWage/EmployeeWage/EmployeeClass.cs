using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeClass
    {
        public string Company;
        public int WagePerHour;
        public int MaxHoursPerMonth;
        public int MaxWorkingDays;
        public int TotalEmpWage;
        public EmployeeClass(string company, int wagePerHour, int maxHoursPerMonth, int maxWorkingDays)
        {
            this.Company = company;
            this.WagePerHour = wagePerHour;
            this.MaxHoursPerMonth = maxHoursPerMonth;
            this.MaxWorkingDays = maxWorkingDays;
        }
        public void CompanyEmpWage()
        {
            int empHours = 0;
            int empDailyWage = 0;
            int workingDays = 0;
            int workingHrs = 0;

            Random rand = new Random();

            while (workingDays <= MaxWorkingDays && workingHrs <= MaxHoursPerMonth)
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
                empDailyWage = empHours * WagePerHour;
                TotalEmpWage += empDailyWage;
                workingHrs += empHours;

            }
            Console.WriteLine("Company Name:" + Company);
            Console.WriteLine("Employee Working Hours :" + workingHrs);
            Console.WriteLine("Employee Wage Per day :" + empDailyWage);
            Console.WriteLine("Employee Working days in month :" + workingDays);
            Console.WriteLine("Employee Wage for working days :" + TotalEmpWage);

        }
        public string ToString()
        {
            return "Total employee wage for " + Company + " is " + TotalEmpWage;
        }
    }
}
