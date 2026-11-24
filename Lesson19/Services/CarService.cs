using Lesson19.Models;
using Lesson19.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson19.Services
{
	internal class CarService
	{


		private readonly CarRepository _carRepository;
		public CarService(CarRepository carRepository)
		{
			_carRepository = carRepository;
		}



		public List<Car> GetAllCars()
		{
			var cars = _carRepository.GetAllCars();
			if(cars.Count == 0)
			{
				throw new Exception("No cars found.");
			}

			return cars;
		}



		public void AddCar(Car car)
		{
			if (car == null)
			{
				throw new ArgumentNullException(nameof(car), "Car cannot be null.");
			}
			if (string.IsNullOrWhiteSpace(car.Brand) || string.IsNullOrWhiteSpace(car.Model))
			{
				throw new ArgumentException("Car brand and model cannot be empty.");
			}
			if (car.Year < 1886 || car.Year > DateTime.Now.Year + 1) // The first car was invented in 1886
			{
				throw new ArgumentOutOfRangeException(nameof(car.Year), "Car year is out of range.");
			}
			if (car.Price < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(car.Price), "Car price cannot be negative.");
			}
			_carRepository.AddCar(car);
		}




		public void DeleteCar(string brand)
		{
			var car = _carRepository.GetCarByBrand(brand);
			if (car == null)
			{
				throw new Exception($"Car with brand '{brand}' not found.");
			}
			_carRepository.DeleteCar(car.Brand);
		}



		public void UpdateCar(string brand, Car newCar)
		{
			var car = _carRepository.GetCarByBrand(brand);
			if (car == null)
			{
				throw new Exception($"Car with brand '{brand}' not found.");
			}
			_carRepository.UpdateCar(car.Brand, newCar);
		}

	}
}
