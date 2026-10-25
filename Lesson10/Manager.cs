using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10
{
	internal class Manager : IWorker
	{
		public int Share { get; set; }
		int IWorker.WorkingHours { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		void IWorker.Work()
		{
			throw new NotImplementedException();
		}
	}
}
