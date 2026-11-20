using Lesson18.Menus;
using Lesson18.Models;
using Lesson18.Repositories;

namespace Lesson18
{
	internal class Program
	{
		static void Main(string[] args)
		{

			FileManager fm = new FileManager();

			MainMenu mm = new MainMenu(fm);

			mm.ShowMainMenu();



		}
	}
}



//S
//OLID