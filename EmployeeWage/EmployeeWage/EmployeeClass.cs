using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public interface IComputeWage
    {
        public void AddCompanyEmpWage(string company, int wagePerHour, int maxHoursPerMonth, int maxWorkingDays);
        public void ComputeEmpWage();


    }
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
        public void SetTotalEmpWage(int TotalEmpWage)
        {
            this.TotalEmpWage = TotalEmpWage;
        }
        public string ToString()
        {
            return "Total employee wage for " + Company + " is " + TotalEmpWage;
        }
    }

}
