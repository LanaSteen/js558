using System;
using System.Collections.Generic;
using System.Text;

namespace Lect10.Models
{
	internal abstract class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public byte Age { get; set; }
		public string PN { get; set; }

		//public void PrintInfo()
		//{
		//	Console.WriteLine($"Name: {FirstName} {LastName}");
		//	Console.WriteLine($"Age: {Age}");
		//	Console.WriteLine($"PN: {PN}");
		//}

		public virtual void PrintInfo()
		{
			Console.WriteLine($"Name: {FirstName} {LastName}");
			Console.WriteLine($"Age: {Age}");
			Console.WriteLine($"PN: {PN}");
		}

		public abstract void SayName() ;  // savaldebuloa ovverride

	}
}
