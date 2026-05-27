using System.Globalization;

namespace lect2
{
	internal class Program
	{
		static void Main(string[] args)
		{

			/* dsddsdsds
			Console.WriteLine("Hello, World!");  
			Console.WriteLine("Hello, World!");
			*/


			//Console.WriteLine(""   /**/   );


			#region lgoin






			#endregion

			//Console.WriteLine();

			//int x = 10;
			//int y = x;




			Console.WriteLine("Enter your age");
			string ageStr = Console.ReadLine(); ///text  "50"

			//int age = int.Parse(ageStr);  // 50


			//0
			//int age;
			bool isvalid = int.TryParse(ageStr, out int  age);
			//int.TryParse(ageStr, out int age);  // 0

			//Console.WriteLine(age);


			//string symbol = Console.ReadLine();
			//char ch = char.Parse(symbol);


			//if (isvalid)
			//{
			//	//Console.WriteLine("you are : " + age);
			//	Console.WriteLine($"you are : {age}");
			//}
			//else
			//{
			//	Console.WriteLine("invalid input");
			//}




			//Console.WriteLine("Enter your sallary");

			//10000 მეტი  მაშინ Console.WriteLine("you are rich");
			// 10000 ნაკლები   KA   მაშინ Console.WriteLine("you are poor but its ok your georgian");
			//10000 ნაკლები   sxva მაშინ Console.WriteLine("you are poor ");


			//bool isvalid = int.TryParse(ageStr, out int age);









			//Console.WriteLine("enter your sallary");


			//string sallaryStr = Console.ReadLine();
			//bool isSallaryValid = decimal.TryParse(sallaryStr, out decimal sallary);
			//string nationality = Console.ReadLine();



			//if (isSallaryValid)
			//{
			//	if (sallary > 1000)
			//	{
			//		Console.WriteLine("you are rich");
			//	}
			//	else if (sallary <= 1000 && nationality == "KA")  // ""KA"  "ka"
			//	{
			//		Console.WriteLine("you are poor but its ok you");
			//	}
			//	else
			//	{
			//		Console.WriteLine("you are poor");
			//	}
			//}
			//else
			//{
			//	Console.WriteLine("invalid input");
			//}








			//=  
			//int xx = 10;

			//==    > < >= <=  != 

			//!true 

			//&&  და   ||    ან    & | 

			//011010 

			//L



			//? : 

			//5 && 5 



			//Console.WriteLine(!true ? "rame" : "other rame");



			int x = 10;
			Console.WriteLine(++x);  //11
			Console.WriteLine(x);  //11

			Console.WriteLine(typeof(int));  //System.Int32


			//DateTime dt = new DateTime();











			//Console.ReadKey();









		}




	}
}
