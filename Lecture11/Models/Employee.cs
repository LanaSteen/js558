using Lecture11.Enums;
using System;
using System.Collections.Generic;
using System.Text;


//overload გადატვირთვა - სხვა და სხვა პარამეტრები აქვს ერტი და იგივე დასახელების ფუნქციას
//override გადაფარვა - ფუნქციის გადაწერა იმოლემენტაცია აქვს სხვა და სხვა 
namespace Lecture11.Models
{
	internal class Employee 
	{
		public Employee()
		{
		}

		public Employee(string name, string surname, DateTime dateOfBirth, Contacts contacts, Country country, Gender gender)
		{
			Name = name;
			Surname = surname;
			DateOfBirth = dateOfBirth;
			Contacts = contacts;
			Country = country;
			Gender = gender;
		}

		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTime DateOfBirth { get; set; }

		public Contacts Contacts { get; set; }

		public Country Country { get; set; }

		public Gender Gender { get; set; }




		public int GetAge()
		{
			return DateTime.Now.Year - DateOfBirth.Year;
		}



		//public static Employee[] GetEmployeesByCountry(Employee[] employees, Country country)
		//{
		//	Console.WriteLine($"{country}");

		//	Employee[] filteredEmployees = [];

		//	int count = 0;

		//	foreach (var item in employees)
		//	{
		//		if (item.Country == country)
		//		{
		//			count++;
		//			Array.Resize(ref filteredEmployees, count);
		//			filteredEmployees[count-1] = item;

		//			//Console.WriteLine($"{item.Country}, {item.Name}");
		//		}
		//	}

		//	return filteredEmployees;
		//}




		public override string? ToString()
		{
			return $"Name: {Name}, Surname: {Surname}, Date of birth: {DateOfBirth}, Contacts: {Contacts}, Country: {Country}, Gender: {Gender}";
		}




		//public static void GetEmployeesByCountry(Employee[] employees, Country country)
		//{
		//	Console.WriteLine($"{country}");

		//	Employee[] filteredEmployees = [];

		//	foreach (var item in employees)
		//	{
		//		if (item.Country == country)
		//		{
		//			Console.WriteLine($"{item.Country}, {item.Name}");
		//		}
		//	}


		//}
	}
}
