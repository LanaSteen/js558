using Lect9.enums;
using Lect9.Models;

namespace Lect9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");



			//შექმენით მანქანის კლასი მოცემული მონაცემებისთვის
			//BMW, M5,2023,105000,Black
			//დაწერეთ მეთოდები რომლებიც:
			//დაბეჭდავს მთლიანად მაქანის ინფორმაციას,
			//გამოთვლის ძვირია თუ არა მანქანა. ძვირია თუ ფასი 100 000 ზე მეტია
			//დაადგენს მანქანა არის თუ არა  კონკრეტული მოდელის 
			//დააბრუნებს მანქანის ფერს

			//შექმენით 5 ობიექტი ამ მანქანის კლასისდან 

			//შეინახეთ არაიში და ყველა მანქანის შესახებ ინფორმაცია გამოიტანეთ კონსოლში




			//Car car = new();

			//car.Manufacturer = "BMW";
			//car.Model = "M5";
			//car.Year = -2;
			//car.Price = 105000;
			//car.Color = "Black";



			//Car car2 = new Car() { Manufacturer = "Mercedess", Model="GL", Year = 2026, Color = "White", Price = 50000 };


			//Car[] cars = [car, car2, new Car() { Manufacturer = "Mercedess", Model = "GL", Year = 2026, Color = "White", Price = 50000 }];


			//foreach (var item in cars)
			//{
			//	item.PrintInfo();
			//}






			//Laptop,Dell XPS 13,2023,1200,Silver
			//მთელი ინფორმაციის დაბეჭდვა



			Product product = new();
			product.Category = "Laptop";
			product.Model = "XPS 13";
			product.Year = 2023;
			product.Price = 100;
			product.Color = "Silver";


			product.Print();


			//string path = "C:\\Users\\l4nst\\Desktop\\jp 558\\js558\\Lect9\\products.txt";


			string path = @"../../../products.txt";


			//string lines = File.ReadAllText(path);

			//Console.WriteLine(lines);



			string[] lines2 = File.ReadAllLines(path);

			Product[] products = new Product[lines2.Length];

			int index = 0;

			foreach (var item in lines2)
			{
				Console.WriteLine(item);
				Console.WriteLine("--------");



				string[] lineParts = item.Split(",");
				Product productnew = new();
				productnew.Category = lineParts[0];
				productnew.Model = lineParts[1];
				productnew.Year = int.Parse(lineParts[2]);   
				productnew.Price = int.Parse(lineParts[3]);
				productnew.Color = lineParts[4];


				products[index] = productnew;
				index++;

			}


			foreach (var item in products)
			{

				item.Print();
			}





			Car car1 = new Car("bMw","M5", 2026, 52200, Color.black);
	}



	
	//internal 


	

}
}
