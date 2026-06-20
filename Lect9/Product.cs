using System;
using System.Collections.Generic;
using System.Text;

namespace Lect9
{
	internal class Product
	{
		public string Category { get; set; }
		public string Model { get; set; }


		private int _year;

		public int Year
		{
			get { return _year; }
			set
			{
				if (value < 0 || value > DateTime.Now.Year)
				{
					Console.WriteLine("invalid year");
					return;
				}
				_year = value;


			}
		}

		public decimal Price { get; set; }
		public string Color { get; set; }



		public void Print()
		{
			Console.WriteLine($" {Model} {Year} {Price} {Color}");
		}
}
}
