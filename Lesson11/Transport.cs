using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson11
{
	internal abstract class Transport
	{
		public int Speed { get; set; }

		//virtual
		//abstract

		public virtual void Move()
		{
			Console.WriteLine("Transport is moving");
		}

		public abstract void Move2();
	}
}
