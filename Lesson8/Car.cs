using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8
{
	internal class Car
	{
		public string Brand { get; set; }


		private int _year;

		public int Year
		{
			get { return _year; }
			set { 
			   if(value <1900 || value > 2026)
				{
					Console.WriteLine("Year must be between 1900 and 2026");
				}
				else
				{
					_year = value;
				}
			}
		}

	}
}


//name,  year, director