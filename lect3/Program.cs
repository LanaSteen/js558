namespace lect3
{
	internal class Program
	{
		static void Main(string[] args)
		{


			//დავალება 1
			//დაწერეთ C# Sharp პროგრამა, რომლითაც მომხმარებელი შეიყვანს ამომრჩევლის ასაკს და პროგრამა განსაზღვრავს,
			//აქვს თუ არა მას არჩევნებზე ხმის მიცემის უფლება.
			//შესაყვანი სატესტო მონაცემი: 18
			//მოსალოდნელი შედეგი: გილოცავ! ხმის მიცემის უფლება გაქვთ.
			//–––––––––––––––––––––––
			//შესაყვანი სატესტო მონაცემი: 15
			//მოსალოდნელი შედეგი: სამწუხაროდ ხმის მიცემის უფლება ჯერ არ გაქვთ.



			//Console.WriteLine("Enter Age");

			//string ageStr = Console.ReadLine();

			//bool isValid = byte.TryParse(ageStr, out byte age);

			//if(isValid && age >= 18)
			//{
			//	Console.WriteLine("You can vote");
			//}
			//else if (isValid && age < 18)
			//{
			//	Console.WriteLine("You can't vote");
			//}
			//else
			//{
			//	Console.WriteLine("Invalid input");
			//}





			//			დაწერეთ C# პროგრამა, რომელიც დაადგენს სამ რიცხვს შორის უდიდესს.
			//შესაყვანი სატესტო მონაცემი:
			//			შეიყვანეთ პირველი რიცხვი: 25
			//შეიყვანეთ მე-2 რიცხვი: 63
			//შეიყვანეთ მე-3 რიცხვი: 10
			//2 | P a g e
			//მოსალოდნელი შედეგი: მე - 2 რიცხვი მაქსიმალურია წარმოდგენილ რიცხვებს შორის.



			//Console.WriteLine("enter first number");
			//string firstNumStr = Console.ReadLine();
			//bool isvalidFirst = int.TryParse(firstNumStr, out int first);


			//Console.WriteLine("enter second number");
			//string secondNumStr = Console.ReadLine();
			//bool isvalidsecond = int.TryParse(secondNumStr, out int second);


			//Console.WriteLine("enter third number");
			//string thirdNumStr = Console.ReadLine();
			//bool isvalidthird = int.TryParse(thirdNumStr, out int third);


			//if (isvalidFirst && isvalidsecond && isvalidthird)
			//{

			//	if (first > second && first > third)
			//	{
			//		Console.WriteLine(first + " is bigest");
			//	}
			//	else if (second > first && second > third)
			//	{
			//		Console.WriteLine(second + " is bigest");
			//	}
			//	else if (third > second && third > first)
			//	{

			//		Console.WriteLine(third + " is bigest");
			//	}
			//	else
			//	{
			//		Console.WriteLine("some of them is equal");
			//	}
			//}
			//else
			//{
			//	Console.WriteLine("some of them wwas invalid");
			//}




			//დაწერეთ C# პროგრამა ორი მოცემული მთელი რიცხვის ჯამის გამოსათვლელად.
			//თუ ეს ორი რიცხვი ერთნაირია, მაშინ დააბრუნეთ გასამმაგებული მათი ჯამი.


			//int num1 = 5;
			//int num2 = 10;


			//if(num1 == num2)
			//{
			//	int result = (num2 + num1) * 3;
			//	Console.WriteLine(result);
			//}
			//else
			//{
			//	int result = num2 + num1;
			//	Console.WriteLine(result);
			//}






			//++ -- 


			//int x = 5;

			//x++;  // 5
			//	  // 6

			//++x; //7










			//int day = 2;



			//if (day == 1) 
			//{
			//	Console.WriteLine("Monday");
			//}
			//else if (day == 2)
			//{
			//	Console.WriteLine("Tuesday");
			//}
			//else
			//{
			//	Console.WriteLine("Unknown");
			//}




			//switch (day)
			//{
			//	//case 100:
			//	//	Console.WriteLine("Monday");
			//	//	break;
			//	case 2:
			//		Console.WriteLine("Tuesday");
			//		goto case 1;
			//	case 1:
			//		Console.WriteLine("Monday");
			//		break;
			//	default:
			//		Console.WriteLine("Unknown");
			//		break;
			//}
			//			მომხმარებელს შეაყვანინე ქულა(0–100)
			//დაბეჭდე:
			//•	90 + → A
			//•	70–89 → B
			//•	50–69 → C

			//d
			//bool isValid = byte.TryParse(ageStr, out byte age);





			//Console.WriteLine("enter your point");
			//string result = Console.ReadLine();

			//bool valid = byte.TryParse(result, out byte grade);

			//if (valid && grade >= 90 && grade <=100) 
			//{
			//	Console.WriteLine("A");
			//}

			//else if (valid && grade >=70)
			//{
			//	Console.WriteLine("B");
			//}
			//else if (valid && grade >= 50)
			//{
			//	Console.WriteLine("C");
			//}
			//else if (valid)
			//{
			//	Console.WriteLine("D");
			//}
			//else
			//{
			//	Console.WriteLine("invalid");
			//}

			//	მომხმარებელს შეაყვანინე რიცხვი და თქვი:
			//•	დადებითია
			//•	უარყოფითია
			//•	ნულია

			string rame = Console.ReadLine();

			switch (rame)
			{
				case "admin":
					Console.WriteLine("You have full access");
					break;

				case "guest":
					Console.WriteLine("You have hulf access");
					break;

				default : Console.WriteLine("unknown");
					break;

			}






		}
	}
}
