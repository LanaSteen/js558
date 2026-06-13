using System.Text;

namespace Lect7
{
	internal class Program
	{
		static void Main(string[] args)
		{





			#region hw
			//Console.WriteLine("Hello, World!");



			//Random rand = new Random();
			//Console.WriteLine(rand.Next(1, 14));



			//1.შექმენით jagged array სადაც: თითოეულ სტუდენტს აქვს სხვადასხვა 
			//	რაოდენობის ქულა. იპოვეთ თითოეულის საშუალო ქულა.	
			//int[][] points = [
			//	[5,9,10,8],
			//	[5,9,10,12],
			//	[5,9,10,13],
			//	[5,9,20,14],

			//	];

			//foreach (var item in points)
			//{
			//       int sum = 0;
			//	foreach (var item1 in item)
			//	{
			//		sum = sum + item1;
			//	}
			//	Console.WriteLine(sum/item.Length);

			//}


			//2.შექმენით რენდომული 4 ნიშნა პასკოდების არაი(10 წევრი).
			//მომხმარებელს შემოაყვანინეთ კოდი და თუ რომელიმეს დაემთხვა
			//არაიში დაუბეჭდეთ “Correct” თუ არა და “Wrong”.



			//var random = new Random();
			//int[] passcodes = new int[10];
			//for (int i = 0; i < passcodes.Length; i++)
			//{
			//	passcodes[i] = random.Next(1000, 9999);


			//}

			//Console.WriteLine("enter passcode");
			//string userInput = Console.ReadLine();
			//bool isCorrect = false;
			//foreach (var item in passcodes)
			//{
			//	if (item.ToString() == userInput)
			//	{
			//		isCorrect = true;
			//	}

			//}

			//Console.WriteLine(isCorrect? "correct" : "wrong");







			//3.შექმენით int-ების(მათ შორის ნეგატიური რიცხვებიც) მასივი.
			//	იპოვეთ მინიმალური და მაქსიმალური რიცხვები(არ გამოიყენოთ არაის მეთოდები).


			//int[] numbesr = { 10, 20, -30, 40, 50, -60, 70, 80, -90 };

			//int min = numbesr[0];
			//int max = numbesr[0];

			//for (int i = 1; i < numbesr.Length; i++)
			//{
			//	if (numbesr[i] < min)
			//	{
			//		min = numbesr[i];
			//	}
			//	if (numbesr[i] > max)
			//	{
			//		max = numbesr[i];
			//	}
			//}

			//Console.WriteLine("minimumi"+ min);
			//Console.WriteLine("max" + max);




			//4.შექმენით სტრინგების მასივი და კონსოლში 
			//	დაბეჭდეთ ყველა ელემენტის ყველა სიმბოლო(არ გამოიყენოთ არაის მეთოდები).

			//string[] names = { "John", "Jane", "Alice", "Bob" };

			//foreach (var item in names)
			//{
			//	foreach (var symbol in item)
			//	{
			//		Console.WriteLine(symbol);
			//	}

			//	Console.WriteLine("----");
			//}



			//5.შექმენით იმეილების მასივი და დაადგინეთ ყველა ელემენტი თუ შეიცავს @ სიმბოლოს.
			//	(არ გამოიყენოთ არაის და სტრინგის ჩაშენებული მეთოდები).

			//string[] emails = { "dsf@fdfd", "dsfdffdfd", "dsrrf@fdfd", "rrdsfdfd" };
			//foreach (var item in emails)
			//{
			//	foreach (var symbol in item)
			//	{
			//		if(symbol == '@')
			//		{
			//			Console.WriteLine("Welcome");
			//		}
			//	}
			//}


			//Console.WriteLine();
			//Console.ReadLine();
			//Console.ReadKey();


			//Console.ForegroundColor = ConsoleColor.Red;

			//Console.WriteLine("error");
			//Console.ResetColor();

			//  UTF8Encoding encoding = new UTF8Encoding();
			//Encon	Encoding.UTF8

			//Console.WriteLine("ქართული");


			////Console.Beep();
			//Console.BackgroundColor = ConsoleColor.Green;


			//Random rand = new Random();

			//StringBuilder sb = new StringBuilder();


			//////sb.AppendLine("Hello");

			//sb.Append("World");
			////string text = "World";
			////sb.Replace('W', 'w');
			//Console.WriteLine(sb);


			//Console.WriteLine(sb.ToString() == text);

			//string text = "text";
			//text = "hello";



			#endregion
			//Console.WriteLine(print()); 
			//string x = print();  // true


			//Console.WriteLine(x);

			////არ აბრუნებს არაფერს 
			//string print(){

			//	Console.WriteLine("hello");
			//	return "true";
			//}



			//print(100);


			//void print(int rame)
			//{
			//	Console.WriteLine(rame);
			//}



			//test("hello");


			//Random rn = new Random();


			int[] nums = new int[10];
			RandomNumbers(nums);
			PrintArray(nums);


		}
	
	
	  static void RandomNumbers(int[] numbers)
		{
			for (int i = 0; i < numbers.Length; i++)
			{
				Random rand = new Random();
				numbers[i] = rand.Next(0,100);
				Console.WriteLine(numbers[i]);
			}
		}


		static void PrintArray(int[] numbers)
		{
			foreach (int i in numbers)
			{
				Console.WriteLine(i);
			}

		}

		//static  void test(string text)
		//{
		//	Console.WriteLine(text);
		//}	
	}
}


//s r p     

//ფუნქცია
//მეთოდი    ობიექტში ჩაშენებული 


//Console.WriteLine();


//print(){ }
