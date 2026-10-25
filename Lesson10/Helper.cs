using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
	internal class Helper : IHelper
	{


		public void Print()
		{
			Console.WriteLine("Print");
		}

		public int Subtract(int a, int b)
		{
			throw new NotImplementedException();
		}

		public int Sum(int a, int b)
		{
			throw new NotImplementedException();
		}
	}
}
