using System;
namespace PayrollSystem.EmployeeClasses
{
	public abstract class Employee
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int SINNumber { get; set; }
		public double Pay { get; private set; }

		public Employee(string firstName, string lastName, int sINNumber)
		{
			firstName = FirstName;
			lastName = LastName;
			sINNumber = SINNumber;
		}

		abstract public double CalculateSalary();
		

		

	}
}

