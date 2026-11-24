using Lesson19.Models;
using Lesson19.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson19.Menus
{
	internal class CarMenu
	{

		private readonly CarService _carService;

		public CarMenu(CarService carService)
		{
			_carService = carService;
		}


		public void ShowMenu()
		{
			Console.WriteLine("Car Menu:");
			Console.WriteLine("1. List all cars");
			Console.WriteLine("2. Add a new car");
			Console.WriteLine("3. Delete a car by brand");
			Console.WriteLine("4. Update a car by brand");
			Console.WriteLine("5. Exit");
			var choice = Console.ReadLine();
			switch (choice)
			{
				case "1":
					var cars =  _carService.GetAllCars();
					foreach (var item in cars)
					{
						Console.WriteLine(item);
					}

					break;
				case "2":
					Car car = new Car();
					Console.WriteLine("Enter car brand:");
					car.Brand = Console.ReadLine();
					Console.WriteLine("Enter car model:");
					car.Model = Console.ReadLine();
					Console.WriteLine("Enter car year:");
					car.Year  = int.Parse(Console.ReadLine());
					Console.WriteLine("Enter car price:");
					car.Price = decimal.Parse(Console.ReadLine());
					Console.WriteLine("Enter car color (Red, Blue, Green, Black, White, MidnightPurple, FluidMetal, Silver, Gray, Yellow, Orange):");
					car.Color = Enum.Parse<Color>(Console.ReadLine());

					_carService.AddCar(car);
					break;
				case "3":
					Console.WriteLine("Enter brand you want to delete:");
					string brand = Console.ReadLine();
					_carService.DeleteCar(brand);
					break;
				case "4":
					Car car1 = new Car();
					Console.WriteLine("Enter car brand:");
					car1.Brand = Console.ReadLine();
					Console.WriteLine("Enter car model:");
					car1.Model = Console.ReadLine();
					Console.WriteLine("Enter car year:");
					car1.Year = int.Parse(Console.ReadLine());
					Console.WriteLine("Enter car price:");
					car1.Price = decimal.Parse(Console.ReadLine());
					Console.WriteLine("Enter car color (Red, Blue, Green, Black, White, MidnightPurple, FluidMetal, Silver, Gray, Yellow, Orange):");
					car1.Color = Enum.Parse<Color>(Console.ReadLine());
					_carService.UpdateCar(car1.Brand, car1);
					return;
				default:
					Console.WriteLine("Invalid choice. Please try again.");
					break;
			}
		}

	}
}
