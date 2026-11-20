using Lesson18.Models;
using Lesson18.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

//DI 

namespace Lesson18.Menus
{
	internal class MainMenu 
	{
		private readonly FileManager _fileManager;



		public MainMenu(FileManager fileManager)
		{
			_fileManager = fileManager;
		}

		public  void ShowMainMenu()
		{

			string choose = "";
			while(choose != "0")
			{
				Console.WriteLine("1. Register");
				Console.WriteLine("2. Login");
				Console.WriteLine("0. Exit");
				choose = Console.ReadLine();

				switch (choose)
				{
					case "1":
						// register   
						RegUser();
						break;
					case "2":
						// login
						break;
					default:
						Console.WriteLine("Invalid value - enter 1, 2 or 0");
						break;
				}
			}


		}



		private void RegUser()
		{
			User user = new User();

			user.Id = 1;


			Console.WriteLine("Enter your name");

			user.Name = Console.ReadLine();
			Console.WriteLine("Enter your last name");

			user.LastName = Console.ReadLine();

			Console.WriteLine("Enter your Email");

			user.Email = Console.ReadLine();

			Console.WriteLine("Enter password");

			user.Password = Console.ReadLine();


			_fileManager.AddUser(user);
		}
	
	
	
	}
}
