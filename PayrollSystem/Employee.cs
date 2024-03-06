using System;
namespace PayrollSystem
{
	public abstract class Employee
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int SINNumber { get; set; }

		public Employee(string firstName, string lastName, int sINNumber)
		{
			firstName = FirstName;
			lastName = LastName;
			sINNumber = SINNumber;

		}

		abstract public void CalculateSalary();
		

		

	}
}

