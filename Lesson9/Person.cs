using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
	internal abstract class Person /// zogadi
	{
		public string Name { get; set; }
		public string Email { get; set; }

		public override string? ToString()
		{
			return $"Name: {Name}, Email: {Email}";
		}


		public virtual void Speak()
		{
			Console.WriteLine($"{Name} is speaking.");
		}
	}
}





//anymal 
//	pet
//  wildAnimal



/// actor 
/// director 
/// producer
///
