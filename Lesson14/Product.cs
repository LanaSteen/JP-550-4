using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson14
{
	internal class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public override bool Equals(object? obj)
		{
			var objNew = obj as Product;

			return Id.Equals(objNew.Id) && Name.Equals(objNew.Name);
		}

		public override string? ToString()
		{
			return $"{Id} {Name}";
		}
	}
}
