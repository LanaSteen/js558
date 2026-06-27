using Lecture11.Enums;
using Lecture11.Helpers;
using Lecture11.Models;

namespace Lecture11
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine("Hello, World!");
			//1.შექმენით enum Country, ჩაამატეთ მასში 4 ქვეყნის დასახელება.
			//2.შექმენით enum Gender, ჩაამატეთ მასში მნიშვნელობები.
			//3.შექმენით enum Contacts ჩაამატეთ შიგნით მასში.მაგ ტელეფონი, მეილი, ფაქსი
			//4.შექმენით Employ კლასი რომელსაც ექნება ზემოთ შექმნილი enum-ების propertebi და პლიუს თავისიფროფერთები: name, surname, dateofbirth(datetime)
			//5.Employ კლასს ჩაუმატეთ პარამეტრიანი კონსტრუქტორი რომელიც ყველა ფროფერთის შეავსებს.
			//6.Employ კლასს ჩაუმატეთ მეთოდი რომელიც გამოთვლის და დაგვიბრუნებს ასაკს.
			//7.შექმენით Employ კლასის 8 ინსტანსი, რომლებსაც ყოველ ორს ერთიდაიგივე ქვეყანა ექნება.
			//8.შეინახეთ ეს ობიექტები Employ[] employs = new Employ[8] ელემენტიან მასივში.
			//9.შექმენით მეთოდი გარეთ ან რამე კლასში რომელიც მიიღებს ორ პარამეტრს, Employ[] მასივს და ქვეყანას, გადაივლის ყოველ ელემენტზე და დაგვიბეჭდავს ისეთ Employ-იებს რომლებსაც ეგ ქვეყანა აქვთ Countryფროფერთიში შენახული.


			Employee emp = new Employee();

			Employee[] employs = new Employee[8] {

			 new Employee("John", "Smith", new DateTime(1990, 3, 15), Contacts.Email, Country.USA, Gender.Male),
			 new Employee("Anna", "Johnson", new DateTime(1985, 7, 22), Contacts.Phone, Country.USA, Gender.Female),
			 new Employee("Jhon", "Doe", new DateTime(1980, 5, 20), Contacts.Phone, Country.Georgia, Gender.Male),
			 new Employee("Maria", "Garcia", new DateTime(1992, 11, 2), Contacts.Email, Country.Georgia, Gender.Female),
			 new Employee("David", "Brown", new DateTime(1978, 9, 10), Contacts.Phone, Country.Mexico, Gender.Male),
			 new Employee("Elena", "Ivanova", new DateTime(1988, 4, 18), Contacts.Email, Country.Canada, Gender.Female),
			 new Employee("Michael", "Williams", new DateTime(1995, 12, 1), Contacts.Phone, Country.Canada, Gender.Male),
			 new Employee("Sophie", "Martin", new DateTime(1983, 6, 25), Contacts.Email, Country.Mexico, Gender.Female)

			};


			Employee empnew = new Employee("Sophie", "Martin", new DateTime(1983, 6, 25), Contacts.Email, Country.Mexico, Gender.Female);

			//Console.WriteLine(DateTime.Now);

			//Employee[] employs = new Employee[8] {emp1, emp2, emp3 };



			Console.WriteLine(employs[0].GetAge());

			Random rendom = new Random();
			rendom.Next();


			//Employee[] filtered = Employee.GetEmployeesByCountry(employs, Country.Georgia);


			//Employee[] filtered = ArrayHelper.GetEmployeesByCountry(employs, Country.Georgia);

			//ArrayHelper.PrintArray(filtered);



			//int[] arr = [20, 60, 50];
			//string[] arrstr = ["fdfd","dff"];


			//ArrayHelper.PrintArray(arr);
			//ArrayHelper.PrintArray(arrstr);
			//ArrayHelper.PrintArray(employs);


			Employee[] filtered2 = ArrayHelper.GetEmployeesByCountry(employs, empnew);

			ArrayHelper.PrintArray(filtered2);


			//foreach (var item in filtered)
			//{
			//	//Console.WriteLine(item.Country + " " + item.Name);
			//	Console.WriteLine(item); // 
			//}

			//Employee.GetEmployeesByCountry(employs, Country.Canada);





			int x = 5;
			int y = 2;

			double z = 5 / 2;
			Console.WriteLine(z);



			int[] ints2 = new int[2];// [0,0]
			string[] strs = new string[2]; //[null, null]

			bool[] rame = new bool[3];  // [false, false, false]

			Employee[] rameemp = new Employee[1]; // [null]


			Console.WriteLine(rameemp[0]); // Lecture11.Employee


			

		}
	}
}
