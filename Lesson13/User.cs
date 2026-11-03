using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13
{
	internal class User : IComparable<User>
	{
		public string Name { get; set; }


		public int CompareTo(User? other)
		{
		   return Name.CompareTo(other.Name);
		}
	}
}
