using Lect10.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lect10.Models
{
	internal class Student : Person
	{

		public byte Grade { get; set; }


		public Lesson[] Lessons { get; set; }

		public override void PrintInfo()
		{
			base.PrintInfo();
			Console.WriteLine($"Grade: {Grade}");
		}

		public override void SayName()
		{
			Console.WriteLine(FirstName);
		}

	}
}






//Student
//	teacher   50*lessson.length
//	manager   30000


//GetSalary()