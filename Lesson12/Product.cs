using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12
{
	internal class Product : ISellable
	{
		public int price => throw new NotImplementedException();

		public override bool Equals(object? obj)
		{
			return price.Equals(obj); //// next lesson
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public void Sell()
		{
			throw new NotImplementedException();
		}

		public override string? ToString()
		{
			return base.ToString();
		}
	}
}
