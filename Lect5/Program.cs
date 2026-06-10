namespace Lect5
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region hw


			//გააკეთე კონსოლიდან შემოყვანილი რიცხვის გამრავლების ტაბულის ერთი ბლოკი.
			//(ათის ნამრავლის ჩათვლით)

			//Console.WriteLine("Enter number");

			////int num = Console.ReadLine();


			//bool isValid = int.TryParse(Console.ReadLine(), out int num);

			//if (isValid)
			//{
			//	for (int i = 0; i <= 10; i+=2)
			//	{
			//		Console.WriteLine($" {num} * {i} = {num * i}");
			//	}
			//}




			//დაწერეთ პროგრამა რომელიც გამოიტანს კონსოლში ფიფქებით შედგენილ პირამიდის ფორმას.
			//	მაგალითად ციფრი 4–ის შეყვანისას კონსოლში გამოვა შემდეგი სახის პირამიდა:


			//Console.WriteLine("Enter number");
			//bool isValid = int.TryParse(Console.ReadLine(), out int lines);


			//for (int i = 1; i <= lines; i++)  //4
			//{

			//	for (int j = 1; j <= lines - i; j++)
			//	{
			//		Console.Write(" ");
			//	}

			//	for (int k = 1; k <= i; k++)
			//	{
			//		Console.Write("* ");
			//	}


			//	Console.WriteLine();
			//}






			//დაწერეთ პროგრამა რომელიც კონსოლიდან
			//წაკითხულ რიცხვამდე დააჯამებს ყველა 
			//	ლუწ რიცხვს და პასუხი გამოიტანეთ კონსოლში



			//Console.WriteLine("Enter number");
			//bool valid = int.TryParse(Console.ReadLine(), out int num);

			//int sum = 0;

			//for (int i = 0; i < num; i+=2) 
			//{
			//	sum += i;
			//	//if (i % 2 == 0)
			//	//{
			//	//	sum += i;
			//	//}
			//}



			//დაწერეთ პროგრამა რომელიც აირჩევს რენდომულ რიცხვს.
			//მომხმარებელმა შემოიყვანოს კონსოლიდან რიცხვი
			//მანამ არ გამოიცნობს არჩეულ რენდომულ რიცხვს.

			//Random rand = new Random();

			//int random = rand.Next(0,100);

			//Console.WriteLine("Enter number");
			//bool valid = int.TryParse(Console.ReadLine(), out int userNum);



			//	while (random != userNum || !valid )
			//	{
			//     	Console.WriteLine($"random is {random}");
			//		Console.WriteLine("try again");
			//		valid = int.TryParse(Console.ReadLine(), out userNum);
			//	}




			#endregion


			//byte[] numbers = [10,50,60];  // ფიქსირებული ზომის

			//numbers[3] = 50;
			//
			//int[] number = new int[5];   // 0 0 0 0 0

			//number[0] = 1;
			//number[1] = 1;
			//0                 Length-1




			//Random random = new Random();

			//int[] nums = new int[5];


			//for (int i = 0; i < nums.Length; i++)
			//{
			//	nums[i] = random.Next(0,100);
			//	Console.WriteLine(nums[i]);

			//}


			//string[] names = { };
			//string[] names2 = [ ];
			//string[] names3 = new string[2];
			//string[] names4 = new string[2] {"John", "George" };



			//შექმენით სახელების არაი და დაბეჭდეთ
			//ყველა ის სახელი რომელიც არის "John"


			//string[] names = ["John", "John", "George"];

			//int count = 0;


			//for (int i = 0; i < names.Length; i++)
			//{
			//	if (names[i] == "John")
			//		count++;
			//}


			//Console.WriteLine(count);


			//string[] names = ["John", "John", "George"];
			//int count = 0;
			//foreach (string item in names)
			//{
			//	Console.WriteLine(item);
			//	if(item == "John")
			//	{
			//		count++;
			//	}
			//}



			//string[] names = ["John", "John", "George"];

			//int ind = 0;

			//foreach (var item in names)
			//{
			//	if(item == "John")
			//	{
			//		Console.WriteLine(ind);
			//	}
			//	ind++;
			//}
			//
			//

			//jagged array  - მასივები მასივი 

			int[][] nums = [ [20,50,60 ],  [10,20,30], [50,60,30]  ];


			//2D array   //   მოიძიეთ ინფორმაცია


			foreach (var item in nums)
			{

				foreach (var num in item)
				{
					Console.WriteLine(num);
				}


			}

		}
	}
}
