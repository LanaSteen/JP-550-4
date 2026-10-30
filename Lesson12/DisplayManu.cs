using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12
{
	internal class DisplayManu
	{
		public static void ShowMenu()
		{
			Console.WriteLine("1. Register");
			Console.WriteLine("2. Login");
			Console.WriteLine("3. Exit");

		    Client client = new Client();
			client.Authorize(Console.ReadLine(), Console.ReadLine());


		}	
	}
}
