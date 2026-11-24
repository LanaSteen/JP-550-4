
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson19.Models
{
	internal class Car
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public decimal Price { get; set; }
		public Color Color { get; set; }

		public override string? ToString()
		{
			return $"{Brand},{Model},{Year},{Price},{Color}";
		}
	}



	public enum Color
	{
		Red,
		Blue,
		Green,
		Black,
		White,
		MidnightPurple,
		FluidMetal,
		Silver,
		Gray,
		Yellow,
		Orange,

	}

}
