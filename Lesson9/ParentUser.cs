using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
	internal class ParentUser
	{
		public string Name { get; set; }

		private int _age;  /// 

		public int Age
		{
			get { return _age; }
			set
			{

				if (value < 0)
				{
					Console.WriteLine("Age can't be negative");

				}
				else
				{
					_age = value;
				}


			}
		}



		public void Print()
		{
			Console.WriteLine($"Name: {Name}, Age: {Age}");
		}

		public override string? ToString()
		{
			return $"Name: {Name}, Age: {Age}";
		}
	}
}
