using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
	internal class Doctor:  Employe, IWorker, ISallaryGetter
	{
		public string Speciality { get; set; }

		public int Amount { get; set; }
		int IWorker.WorkingHours { get; set; }

		public decimal CalculateBonus(int rate)
		{
			return Amount * rate;
		}

		public void Print()
		{
			Console.WriteLine("sdddsdssds");
		}

		void ISallaryGetter.GetSallary(decimal sallary)
		{
			Console.WriteLine($"Sallary: {sallary}");
		}

		void IWorker.Work()
		{
			Console.WriteLine("Working...");
		}
	}
}




//alivecreature 

//breed 
//color 



    //animal 
	//bird
	//see anymal




//fly 
//sweem
//walk



//pet livingHome 
//	wild hinting
	  

