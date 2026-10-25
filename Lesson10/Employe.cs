using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
	internal abstract class Employe
	{
		public string FullName { get; set; }

		

		private decimal _salary;

		public decimal Salary
		{
			get { return _salary; }
			set { 
				if (value < 0)
				{
					Console.WriteLine("Salary cannot be negative."); 
				}

				else { 
					_salary = value;
				}

			
				


			}

		}

		public override string? ToString()
		{
			return $"FullName: {FullName}, Salary: {Salary}";
		}

	}
}
