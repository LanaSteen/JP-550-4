using Lesson19.Menus;
using Lesson19.Repositories;
using Lesson19.Services;

namespace Lesson19
{
	internal class Program
	{
		static void Main(string[] args)
		{

			CarRepository carRepository = new CarRepository();

			CarService carService = new CarService(carRepository);


			CarMenu carMenu = new CarMenu(carService);

			Console.WriteLine("enter x to exit, or ennter to continue");
			string exit = Console.ReadLine();

			while (exit!="x")
			{
				carMenu.ShowMenu();
			}




		}
	}
}
