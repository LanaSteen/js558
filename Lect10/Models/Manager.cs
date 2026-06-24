using System;
using System.Collections.Generic;
using System.Text;

namespace Lect10.Models
{
	internal class Manager : Employee
	{
		//public decimal Salary { get; set; }

		public override decimal GetSalary()
		{
			 return base.GetSalary();
		}
		public override void SayName()
		{
			Console.WriteLine(FirstName);
		}
	}
}


//DRY 