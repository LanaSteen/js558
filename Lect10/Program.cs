using Lect10.Models;

namespace Lect10
{
	//1. ინკფსულაცია
	//2. მეკვიდრეობა
	//3. პოლიმორფიზმი


	//overload - გადატვირთვა განსხვავებული პარამეტრებით მეტოდების ამუშავება
	//ovverride - გადაწერა გადაფარვა - განსხვავებულად იმპლემენტირდება ამეთოდი

	internal class Program
	{
		static void Main(string[] args)
		{


			Teacher teacher = new Teacher();
			teacher.FirstName = "John";
			teacher.Salary = 1000;



			teacher.Lessons = [new Lesson("Math", "rame"), new Lesson("English", "fsgfdfg")];

			Console.WriteLine(teacher.GetSalary()); // 100

			Manager manager = new Manager();
			manager.FirstName = "Kamal";
			manager.Salary = 2000;

			Console.WriteLine(manager.GetSalary()); //2000

			manager.PrintInfo();


			Student student = new Student();
			student.FirstName = "Ali";
			student.Grade = 1;

			student.PrintInfo();

			//Person person = new Person();

			//Employee employee = new Employee();

			//აბსტრაქტული - ზოგადი - კონკრეტული სახე არ აქვს
			
		
			string path = "C:\\Users\\l4nst\\Desktop\\jp 558\\js558\\Lect10\\Data\\CarsData.txt"

			string path2 = @"../../../Data/CarsData.txt";

			string[] lines = File.ReadAllLines(path);


			foreach (var line in lines)
			{
				string[] parts = line.Split(",");


			}


		}
	}






}




//სტუდენტი
//	მასწავლებელი
//	მენეჯერი
