using System;
namespace PayrollSystem
{
    public class CommissionEmployee : Employee
	{
        public double rate;
        public int SalesAmount;
		public CommissionEmployee(double rate, int salesAmount ) : base
        {
            
		}

        public override void CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }
}

