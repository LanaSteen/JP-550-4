using System;
using System.Collections.Generic;
using System.Text;

/// oop 
/// 
/// 
/// encapsulation
/// inheritance
/// polymorphism
/// 

namespace Lesson8
{
	internal class Student
	{

		public string Name;  // field

		public string Surname; // field

		//public int Age;  // field

		//full property
		private int _age;///  30

		public int Age
		{
			get 
			{
				return _age; 
			
			}
			set
			{
				if(value >100)
				{
					Console.WriteLine("Error");
				}
				else
				{
					_age = value;
				}
			
			}
		}



		public string Group { get; set; }


		



		//public int Gdare { get; set; } // property  1-12 



		public int Gdare { get; 
			set 
			
			{ 
				if(value>12 && value < 1)
				{
					Console.WriteLine("Error");
				}
			}
		
		} // property  1-12



		public static void Print() // method
		{
			Console.WriteLine("hi");
		}

		public  void Info()  //metho
		{
			Console.WriteLine($"{Name} {Surname} {Age}");
		}
	}
}
