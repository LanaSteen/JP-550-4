using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
	internal class Product
	{
		public string Name;
		public decimal Price;
		public int Amount;

		 decimal Rate = 2.62m;

		public  decimal ConvertedInGel()
		{
			return Price * Rate;
		}

		public static  void PrintHeloo()
		{
			Console.WriteLine("hello");
		}


		public void DisplayInfo()
		{
			Console.WriteLine($"{Name} {Price} {Amount}");
		}

		//5 * 2.62 = 14.65665
	}
}
