using System;
namespace PayrollSystem.EmployeeClasses
{
    public class CommissionEmployee : Employee
	{
        public double Rate;
        public int NumberOfSales;
		public CommissionEmployee(string firstName, string lastName, int sINNumber, double rate, int numberOfSales ) : base(firstName, lastName, sINNumber)
        {
            Rate = rate;
            NumberOfSales = numberOfSales;
		}

        public override double CalculateSalary()
        {
            return Rate * NumberOfSales;
        }
    }
}

