using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
	internal class Helpers
	{


		public static void PrintArray(int[] arr)
		{
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}


		public  void PrintArrayNonStatic(int[] arr)
		{
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}
	}
}
