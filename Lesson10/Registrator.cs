using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
	internal class Registrator : Employe, IWorker
	{
		public int NumberOfPatients { get; set; }
		int IWorker.WorkingHours { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		void IWorker.Work()
		{
			Console.WriteLine("Registrator works");
		}
	}
}
