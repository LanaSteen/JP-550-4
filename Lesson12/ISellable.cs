using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12
{
	internal  interface ISellable
	{
		int price { get; }
		void Sell();
	}
}
