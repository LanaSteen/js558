using Lect9.enums;
using System;
using System.Collections.Generic;
using System.Text;


//oop - object oriented programming

//1. ინკაფსულაცია
//2. მემკვიდრეობა
//3. პოლიმოფიზმი


//overload

namespace Lect9.Models
{
	public class Car
	{
		public Car(string manufacturer, string model, int year, decimal price, Color color)
		{
			Manufacturer = manufacturer;
			Model = model;
			Year = year;
			Price = price;
			Color = color;
		}


		//კონსტრუქტორი  

		public Car()
		{

		}


		public Car(string manufacturer)
		{
			Manufacturer = manufacturer;
		}



		//public Car(string manufacturer, string model, int year, decimal price, string color)
		//{

		//}

		//private string _manufacturer;  // field

		public string Manufacturer { get; set; }  // property
		public string Model { get; set; }


		private int _year; // full property
		public int Year { 
			get{ return _year; }
			set
			{
			
			   if(value < 0 || value > DateTime.Now.Year)
				{
					Console.WriteLine("invalid year");
					return;
				}
				_year = value;


			}
		
		}  // -2 50000


		private int _disscount;

		public int Disscount
		{
			get { return _disscount; }
			set 
			{ 
				if(value < 0 || value > 100)
				{
					Console.WriteLine("invalid disscount");
					return;
				}
				_disscount = value;
			}
		}

		public decimal Price { get; set; }

		public Color Color { get; set; }

		public void PrintInfo()
		{
			Console.WriteLine($"{Manufacturer} {Model} {Year} {Price} {Color}");
		}
		public bool IsExpencive()
		{
			return Price >= 100000;
		}
		public bool IsExactModel(string model)
		{

			return Model == model;
		}



		public Color GetColor()
		{
			return Color;
		}



	}

}


