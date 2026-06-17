using System.Drawing;

namespace Lect8
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region hw


			//			დავალება 1
			//დაწერეთ ფუნქცია რომელიც მიიღებს ორ ინტ პარამეტრს და აიყვანს პირველ რიცხვ მეორე რიცხვის ხარისხში.
			//მაგალითად:
			//		input: 3 და 2
			//result: 3 - ის კვადრატი 9
			//სხვა მაგალითი:
			//input: 2 და 4
			//result: 2 - ის მეოთხე ხარისხში ანუ 2 * 2 * 2 * 2 იქნება 16

			//2         3


			//Console.WriteLine(Pow(10,3));

			//int Pow(int num1, int num2)
			//{
			//	int result = num1;
			//	for (int i = 1; i < num2; i++)
			//	{
			//		result *= num1;
			//	}


			//	return result;
			//}






			//			დავალება 2
			//დაწერეთ ფუნქცია რომელიც მიიღებს ინტ რიცხვს დაგვიბრუნებს bool
			//მნიშვნელობას იმის მიხედვით რიცხვი მარტივია თუ არა: ანუ იყოფა მარტო საკუთარ თავზე და 1 ზე.
			//მაგ: input: 31 return: true console output: 31 მარტივი რიცხვია
			//2 | P a g e
			//მაგ2: input: 6 return: false console output: 6 არ არის მარტივი რიცხვი


			//string ans1 = "is prime";

			//string ans2 = "is composed";

			//Console.WriteLine("Enter numebr");
			//bool isValid = int.TryParse(Console.ReadLine(), out int iuserInput);

			//Console.WriteLine($"{iuserInput}  is { (IsPrime(iuserInput) ? ans1 : ans2) }");
			//bool IsPrime(int num)
			//{

			//	if(num == 0 ||  num ==1 || num <0)
			//	{
			//		return false;
			//	}
			//	else if(num == 1)
			//	{
			//		Console.WriteLine("Arc martivia arc shedginili");
			//		return false;
			//	}
			//	else
			//	{
			//		for (int i = 2; i < num; i++) 
			//		{
			//		   if(num% i ==0)
			//			{
			//				return false;
			//			}
			//		}
			//	}

			//	return true;

			//}






			//			დავალება 3
			//დაწერეთ რეკურსიული მეთოდი რომელიც მიიღებს რაიმე სტრინგს
			//კონსოლიდან და დაგვიბრენუბს true ან false იმის მიხედვით
			//არის თუ არა სტრინგი პალიდრომი.
			//განმარტება: პალიდრომი წარმოადგენს ისეთ ტექსტ, რომელიც რომელი
			//მხრიდანაც არ უნდა წავიკითხოთ, ის ერთნაირად იკითხება.
			//მაგ: inp: stepets console output: stepets არის პალინდრომი.
			//მაგ2: inp: noon console output: noon არის პალინდრომი.


			//string palindrome = "ng12gn";

			//Console.WriteLine(IsPalindrome(palindrome));

			//bool IsPalindrome(string palindrome)
			//{

			//	if(palindrome.Length <= 1)
			//	{

			//		return true;
			//	}
			//	char first = palindrome[0];
			//	char last = palindrome[palindrome.Length - 1];

			//	if (first != last)
			//	{
			//		return false;
			//	}


			//	string middles = palindrome.Substring(1,palindrome.Length-2);
			//	return IsPalindrome(middles);


			//}


			//int[] ar2 = [100, 15, 32];
			////Array.Sort(ar2);
			//Array.Reverse(ar2); // [32,15,100]

			//foreach (var item in ar2)
			//{
			//	Console.WriteLine(item);
			//}




			//string palind = "noon";  // "1noon"

			//char[] cahrs = palind.ToCharArray();   //['n','o','o','n', '1']

			//Array.Reverse(cahrs);


			//char[] reversed = cahrs;   //['1','n','o','o','n']  "1noon"




			//string newPal = new string(reversed);
			//Console.WriteLine(newPal);


			//Console.WriteLine(palind == newPal ? "palindrome" : "not palindrome");



			//			დაწერეთ რეკურსიული მეთოდი რომელიც გამოთვლის
			//			ნებისმიერი რიცხვის ხარისხს, კონსოლიდან შემოიტანეთ რიცხვი და ხარისხი,
			//			გადაეცით თქვენ რეკურსიულ მეთოდს და დააბრუნეთ მისი ხარისხი.
			//მაგ:
			//inpt num: 4
			//power: 3
			//console output: 4 –ი ხარისხად 3 არის: 64


			//Console.WriteLine(Powerer(5,1));



			#endregion




			//class    blueprint თემფლეითი  ობიექტი
			//user   {  name , age} 

			Random rand = new Random();
			rand.Next();

			int[] arr = new int[5];

			User user = new User();
			user.firstName = "george";
			user.age = 25;
			User user2 = new User();
			user2.firstName = "james";
			user2.age = 22;


			Console.WriteLine($"{user.firstName} {user.age}");

			User[] users = [user, user2];

			for (int i = 0; i < users.Length; i++)
			{
				users[i].Printfullinfo();
			}

			

		}

		////2 3 
		//static int Powerer(int n, int n2)
		//{
		//	if (n == 0) return 1;

		//	if (n2 == 1) return n;

		//	return n * Powerer(n, n2 - 1);  //  2 * pow(2,2)  // 8
		//									//  2 * pow(2,1)  //4
		//									// 2

		//}


	}





	public class User
	{
		public string firstName;  // property and fields and methods
		public int age;


		public void Printfullinfo()
		{
			Console.WriteLine($"{firstName } {age }");
		}

	}



}