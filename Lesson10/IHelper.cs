using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
	internal interface IHelper
	{
		 void Print();


		int Sum(int a, int b);

		int Subtract(int a, int b);

		void PrintInfo(int[] arr)
		{
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}


	}
}
