using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Lesson11
{
	internal class Car : Transport
	{
		//public Car()
		//{
		//}

		public Car(string model, int releaseYear)
		{
			Model = model;
			ReleaseYear = releaseYear;
		}
		public Car(string model, int releaseYear, decimal price)
		{
			Model = model;
			ReleaseYear = releaseYear;
			Price = price;
		}
		public Car(string model)
		{
			Model = model;
		}
		public Car(string model, decimal price)
		{
			Model = model;
			Price = price;
		}
		public Car(int releaseYear)
		{
			ReleaseYear = releaseYear;
		}
		public Car()
		{
		}


		public void ShowInfo(string seria, int seria2)
		{
			Console.WriteLine(Model + " " + seria);

			//Console.WriteLine($"{Model} {seria}");
		}

		public void ShowInfo(int seria, string model)
		{
			Console.WriteLine(Model + " " + seria);

			//Console.WriteLine($"{Model} {seria}");
		}
		public void ShowInfo()
		{
			Console.WriteLine(Model );

			//Console.WriteLine($"{Model} {seria}");
		}

		public override string? ToString()
		{
			return $"{Model} {ReleaseYear} {Price}";
		}

		public override void Move2()
		{
			Console.WriteLine("car can be driven");
		}

		public string Model { get; set; }
		public int ReleaseYear { get; set; }

		public decimal Price { get; set; }




		//public override void Move()
		//{
		//	Console.WriteLine("Car is moving");
		//}

	}
}


//polimorphizm
//გადატვირთვა  -   overload


///  override - გადაწერა - გადაფარვა