using Lecture11.Enums;
using Lecture11.Models;
using System;
using System.Collections.Generic;
using System.Text;


//generic - ჯენერიკი  ზოგადდi

namespace Lecture11.Helpers
{
	internal class ArrayHelper
	{

		public static void PrintArray<X>(X[] collection)
		{
			foreach (var item in collection)
			{
				Console.WriteLine(item);
			}
		}
		//public static void PrintArray(Employee[] employee)
		//{
		//	foreach (var item in employee)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}
		//public static void PrintArray(Student[] students)
		//{
		//	foreach (var item in students)
		//	{
		//		Console.WriteLine(item);
		//	}
		//}

		public static Employee[] GetEmployeesByCountry(Employee[] employees, Country country)
		{
			Console.WriteLine($"{country}");

			Employee[] filteredEmployees = [];

			int count = 0;

			foreach (var item in employees)
			{
				if (item.Country == country)
				{
					count++;
					Array.Resize(ref filteredEmployees, count);
					filteredEmployees[count - 1] = item;

					//Console.WriteLine($"{item.Country}, {item.Name}");
				}
			}

			return filteredEmployees;
		}

		public static T[] GetEmployeesByCountry<T>(T[] employees, T searchvalue)
		{
			Console.WriteLine($"{searchvalue}");

			T[] filteredEmployees = [];

			int count = 0;

			foreach (var item in employees)
			{
				if (item.Equals(searchvalue))
				{
					count++;
					Array.Resize(ref filteredEmployees, count);
					filteredEmployees[count - 1] = item;

					//Console.WriteLine($"{item.Country}, {item.Name}");
				}
			}

			return filteredEmployees;
		}
	}
}
