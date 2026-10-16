using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8
{
	internal class FIlm
	{
		//property method feld fullproperty
		private string _name;///  feld


		public int MyProperty { get; set; }   //property

		public string Name
		{
			get { return _name; }
			set { 
			    if(value == null || value == "" ||  string.IsNullOrWhiteSpace(value)  || string.IsNullOrEmpty(value))
				{
					Console.WriteLine("Error");
				}
				else
				{
					_name = value;
				}
			}
		}


		// full properrti 
		private string _director;

		public  string Director
		{
			get { return _director; }
			set {
			
			   if(value.Length < 3 || value.Length > 50)
				{
					Console.WriteLine("Error");
				}
				else
				{
					_director = value;
				}
			
			}
		}



		private int _year;

		public int Year
		{
			get { return _year; }
			set {

				if (value < 1900 || value > 2026)
				{
					Console.WriteLine("Error");
				}
				else
				{
					_year = value;
				}
		
			}
		}



		public void Print()  //method
		{
			Console.WriteLine("hi");
		}



	}
}
