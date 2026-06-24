using System;
using System.Collections.Generic;
using System.Text;

namespace Lect10.Models
{
	internal abstract class Employee : Person
	{
		public decimal Salary { get; set; }



		public virtual decimal GetSalary()
		{
			return Salary;
		}
	}
}
