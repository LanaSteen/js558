using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace lect4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region hw

			//			Login სისტემა: პროგრამაში გვაქვს
			//username: admin
			//password: 1234
			//მომხმარებელს შემოჰყავს ორივე მნიშვნელობა
			// თუ სწორია კონსოლში გამოიტანე:
			//Welcome!
			// თუ არა:
			//Access denied

			//Console.WriteLine("write your username");

			//string userStr = Console.ReadLine();
			//Console.WriteLine("write your password");
			//string passStr = Console.ReadLine();

			//if (userStr== "admin" && passStr == "1234")
			//{
			//	Console.WriteLine("welcome");

			//}

			//else
			//{

			//	Console.WriteLine("access denied");
			//}






			//			Calculator(switch-ით)
			//მომხმარებელი შეიყვანს:
			//•	რიცხვი 1
			//•	ოპერატორი(+-* /)
			//•	რიცხვი 2
			//კონსოლში გამოიტანე არითმეტიკული ოპერაციის შედეგი. (შემოყვანილი ოპერატორის შესაბამისად)

			//string num1 = Console.ReadLine();
			//string num2 = Console.ReadLine();
			//string nisAni = Console.ReadLine();

			//bool nu1 = int.TryParse(num1, out int numm1);
			//bool nu2 = int.TryParse(num2, out int numm2);
			//bool nishani = char.TryParse(nisAni, out char nish);

			//int sum = 0;


			//int	sabolood = nish switch
			//{
			//	'+' => sum = numm1 + numm2,
			//	'-' => sum = numm1 - numm2,
			//	'/' =>  sum = numm1 / numm2,
			//             '*' => sum = numm1 * numm2,

			//             _ =>  int.MinValue,

			//};

			//Console.WriteLine("saboloo pasuxi aris " + sabolood);






			//			მომხმარებელს შეაყვანინე ასაკი:
			//			დაადგინე და კონსოლში გამოიტანე:
			//•	ბავშვი(0–12)
			//•	თინეიჯერი(13–19)
			//•	ზრდასრული(20–64)
			//•	პენსიონერი(65 +)
			//	Console.WriteLine("Sheiyvane Asaki");
			//	string asaki = Console.ReadLine();
			///*false*/	bool isValid = int.TryParse(asaki , out int result);  // 0
			//	if (result > 0 && isValid && result <= 12)
			//	{
			//		Console.WriteLine("Shen xar Bavshi");
			//	}
			//	else if (result <= 19 && isValid) 
			//	{
			//		Console.WriteLine("Shen xar Teenage-ri");
			//	}
			//	else if (result <= 64  && isValid)
			//	{
			//		Console.WriteLine("SHen xar adult-i");
			//	}
			//	else if (result >= 65 && isValid) {
			//		Console.WriteLine("Gadi Pensiaze <3");
			//	}
			//	else
			//	{
			//		Console.WriteLine("She Invalido Shena <3");
			//	}



			#endregion




			//loop 

			//int x 

			//Random rand = new();             //arastatikuri 

			//var r = new Random();


			//rand.Next();
			///// nebismmieri int    int.Minvalue   int.Maxvalue
			//Console.WriteLine(int.MaxValue);

			//Console.WriteLine();    //statikuri





			//Console.WriteLine(rand.Next(0,100));



			//Random rand = new();
			//rand.Next(1000,9999);
			//Console.WriteLine();





			//loop 


			//for (int i = 1; i < 10; i+=2)
			//{
			//	Console.WriteLine("hello");

			//	Console.WriteLine(i);
			//}


			//for (int i = length - 1; i >= 0; i--)
			//{

			//}



			//int count = 0;
			//for (int i = 0; i < 10; i++)
			//{
			//	for (int j = 0; j < 10; j++)
			//	{
			//		Console.WriteLine($"{i} * {j} = {i * j}");
			//		count++;
			//	}

			//	Console.WriteLine();
			//}




			//მარტივი რიცხვები
			//

			//2 10  ჩათვლით გამოთვალეთ მარტივი რიცხვები და რთული რიცხვები ა




			//for (int i = 2; i < 10; i++) 
			//{
			//	int count = 0;

			//	for (int j = 2; j<i; j++)
			//	{
			//		if (i % j == 0)
			//		{
			//			count++; // 1
			//		}
			//	}


			//	if(count > 0)
			//	{
			//		Console.WriteLine($"{i} rtulia");
			//	}
			//	else
			//	{
			//		Console.WriteLine($"{i} martivia");
			//	}
			//}






			//while (true)
			//{

			//}




			//string pass = "123";

			//Console.WriteLine("Enter password");
			//string userinp = Console.ReadLine();



			//int trycount = 0;

			//while(pass != userinp)
			//{

			//	Console.WriteLine("Try again Enter password");
			//	userinp = Console.ReadLine();
			//	trycount++;



			//	if (trycount == 10)
			//	{
			//		Console.WriteLine("liit is up");
			//		break;
			//	}


			//}


			//if (trycount < 10)
			//{
			//	Console.WriteLine("Welcome");
			//}



			//break continue



			//for (int i = 0; i < 10; i++) 
			//{
			//	Console.WriteLine(i);
			//	if (i == 5)
			//	{

			//		break;
			//	}


			//}
			//for (int i = 0; i < 10; i++)
			//{

			//	if (i == 5)
			//	{

			//		continue;
			//	}
			//	Console.WriteLine(i);

			//}





			string userinput;

			do
			{
				Console.WriteLine("Enter role");
				userinput = Console.ReadLine();

			}
			while (userinput != "admin");







			//foreach (var item in args)
			//{

			//}

		
		}
	}
}
