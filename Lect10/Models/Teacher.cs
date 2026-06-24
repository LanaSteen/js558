using System;
using System.Collections.Generic;
using System.Text;

namespace Lect10.Models
{
	internal class Teacher : Employee
	{

		//public decimal	Salary  { get; set; }
		public Lesson[] Lessons { get; set; }


		public override decimal GetSalary()
		{

			return Lessons.Length * 50;
		}

		public override void SayName()
		{
			Console.WriteLine(FirstName);
		}
	}
}



//c# wesi ar sheizleba 1 ze meti mshobeli yavdes