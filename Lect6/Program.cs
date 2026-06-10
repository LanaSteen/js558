using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lect6
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//int[] arr = [10,20]; // 0
			//arr[0] = 1;
			//arr[1] = 2;
			//arr[2] = 2;   // error

			//arr = new int[3];


			//index
			//0 1 2 3 
			//                3   2
			//0      arr.Length - 1


			int[] numbs = {10,20,30 };
			int[] numbs2 = [ 10, 20, 30 ];

			int[] numb3 = new int[4];    
			int[] numb4 = new int[10];  //[0,0,0]

			int[] number5 = new int[4] { 10, 20,0,0 };



			//int[] points = [55, 66, 77, 88];

			//int student1 = 55;
			//int student2 = 66;
			//int student3 = 77;
			//int student4 = 88;

			//student1++;
			//student2++;


			//int x = 5;
			//int y = x;

			//Console.WriteLine(x + " " +  y );  //  5    5
			//y++;
			//Console.WriteLine(x + " " + y);  //  5    6
			//								 //
			//int[] arr1 = [20, 50, 30];
			//int[] arr2 = arr1;
			////  [20, 50, 30]      [20, 50, 30]
			////
			//arr2[0] = 100;

			//[100, 50, 30]    [100, 50, 30] 


			//value  vs referance
			//


			//int[][] jagged = 
			//	[
			//	  [20,60],
			//	  [50,60,70,80]
			//	];  // 

			//Console.WriteLine(jagged[1][2]);

			//int[][] jagged =
			//	[
			//	  [20,60],
			//	  [50,60,70,80]
			//	];


			//foreach (var line in jagged)
			//{
			//	int[] arr = line;
			//	int sum = 0;
			//	foreach (var item in arr)
			//	{
			//		sum += item;
			//	}
			//	Console.WriteLine(sum/line.Length);
			//}



			//[20, 60]





			//foreach (var line in jagged)
			//{
			//	//[20, 60],
			//	foreach (var element in line)
			//	{
			//		Console.WriteLine(element);
			//	}
			//}





			//			დავალება 1
			//შექმენით ერთ განზომილებიანი ორი მასივი.
			//შეავსეთ ორივე მასივი ელემენტებით.
			//გააერთიანე ერთ მასივში ორივე მასივის ელემენტები.
			//დაბეჭდეთ საბოლოოდ მიღებული მასივი.
			//მაგალითად, თუ პირველი მასივის ელემენტების: 1 2 3
			//ხოლო მეორე მასივის ელემენტებია : 4 5 6
			//შედეგად უნდა მიიღოთ: resultArray = [1, 2, 3, 4, 5, 6]



			//int[] num1 = [20, 60, 30, 40];

			//int[] num2 = [50, 60, 70, 80];


			//int[] arr3 = new int[num1.Length + num2.Length];

			//for (int i = 0; i < num1.Length; i++)
			//{
			//	arr3[i] = num1[i];
			//}

			//for (int i =0; i < num2.Length; i++)
			//{
			//	arr3[num1.Length+i] = num2[i];
			//}


			//foreach (var item in arr3)
			//{
			//	Console.WriteLine(item);
			//}


			//[50, 60, 70, 80, 0, 0 , 0 ,0 ]





			//			დავალება 2
			//შექმენით ინტების მასივი და შეავსეთ ელემენტებით. მაგ: 3, 5, -4, 8, 11, 1, -1, 6
			//კონსოლიდან გადმოეცით რაღაც რიცხვი რომელსაც შეინახავთ targetSum ცვლადში.
			//მოძებნეთ მასივში ყველა ის ორი ელემენტი რომლის ჯამიც იქნება targetSum ტოლი და ამწყვილებისგან შექმენით მასივი.
			//დააბრუნეთ ამ ელემენტების წყვილები კონსოლში.
			//2 | P a g e
			//მაგალითად: array = { 3, 5, -4, 8, 11, 1, -1, 6}
			//			targetSum = 7
			//შედეგად უნდა მივიღოთ: resultArray = [[1, 6], [8, -1], [-4, 11]]

			//int[] numbers = [3, 5, -4, 8, 11, 1, -1, 6];

			//bool isvalid = int.TryParse(Console.ReadLine(), out int targetSum);  // 7

			//int count = 0;


			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	for (int j = i + 1; j < numbers.Length; j++)
			//	{
			//		if (numbers[i] + numbers[j] == targetSum)
			//		{
			//			count++;
			//		}
			//	}
			//}


			//int[][] resultArray = new int[count][];
			//int index = 0;

			//for (int i = 0; i < numbers.Length; i++)
			//{

			//	for (int j = i + 1; j < numbers.Length; j++)
			//	{


			//		if (numbers[i] + numbers[j] == targetSum)
			//		{
			//			resultArray[index] = [numbers[i], numbers[j]];
			//			index++;
			//		}
			//	}
			//}





			string text = "text";


			text = "     tex @t2   ";



			Console.WriteLine(text[0]);


			foreach (var symbol in text)
			{
				Console.WriteLine(symbol);
			}



			Console.WriteLine(text.ToLower());
			Console.WriteLine(text.ToUpper());
			Console.WriteLine(text.Trim());

			Console.WriteLine(text.Contains("@")); ///  bool

			Console.WriteLine(text.EndsWith('i'));

			Console.WriteLine(text.EndsWith("com"));

			Console.WriteLine(text.StartsWith('t'));


			//2D   

			//int[,] matrix = new int[2, 3];
			//matrix[0, 1] = 10;


		}
	}
}




