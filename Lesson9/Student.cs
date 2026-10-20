using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
	internal class Student : Person
	{
		public int Grade { get; set; }

		public override string? ToString()
		{
			return $"Name: {Name}, Emmail: {Email}, Grade: {Grade}";
		}

		public override void Speak()
		{
			
			Console.WriteLine($"{Name} is a student and is speaking.");
		}
	}
}
