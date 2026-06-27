using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11.Models
{
	internal class Student
	{
		public string Name { get; set; }
		public string LastName { get; set; }

		private int _age;

		public int Age
		{
			get => _age;
			
			set 
			{ 
			   if(value < 0)
				{
					Console.WriteLine("Age cannot be negative");
				}
				else
				{
					_age = value;
				}
			
			}
		}

	}
}
