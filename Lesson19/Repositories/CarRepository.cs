using Lesson19.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson19.Repositories
{
	internal class CarRepository
	{

		private readonly string _path = @"C:\Users\l4nst\Desktop\new-jp-550-4\Lesson19\Data\CarsData.txt";



		public List<Car> GetAllCars()
		{
			List<Car> cars = new List<Car>();

			string[] lines = File.ReadAllLines(_path);

			foreach (var item in lines)
			{
				var parts = item.Split(",");
				Car car = new Car
				{
					Brand = parts[0],
					Model = parts[1],
					Year = int.Parse(parts[2]),
					Price = decimal.Parse(parts[3]),
					Color = Enum.Parse<Color>(parts[4])
				};

				cars.Add(car);
			}
			//Toyota,Corolla,2022,25000,White

			return cars;
		}

		public Car GetCarByBrand(string brand)
		{
			var cars = GetAllCars();
			return cars.FirstOrDefault(c => c.Brand == brand);
		}

		public Car GetCarByModel(string model)
		{
			var cars = GetAllCars();
			return cars.FirstOrDefault(c => c.Model == model);
		}

		public List<Car> GetSortedByPrice()
		{
			var cars = GetAllCars();
			return cars.OrderBy(c => c.Price).ToList();
		}


		public void AddCar(Car car)
		{
			File.AppendAllLines(_path, [ car.ToString() ]);
		}


		public void DeleteCar(string brand)
		{
			var cars = GetAllCars();
			var carToDelete = cars.FirstOrDefault(c => c.Brand == brand);
			if (carToDelete != null)
			{
				cars.Remove(carToDelete);
				File.WriteAllLines(_path, cars.Select(c => c.ToString()));
			}
		}

		public void UpdateCar(string brand, Car updatedCar)
		{
			var cars = GetAllCars();
			var carToUpdate = cars.FirstOrDefault(c => c.Brand == brand);
			if (carToUpdate != null)
			{
				carToUpdate.Model = updatedCar.Model;
				carToUpdate.Year = updatedCar.Year;
				carToUpdate.Price = updatedCar.Price;
				carToUpdate.Color = updatedCar.Color;
				File.WriteAllLines(_path, cars.Select(c => c.ToString()));
			}
		}
	}
}



//c r u d 