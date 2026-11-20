using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson18.Models
{
	internal class User
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }

		public override string? ToString()
		{
			return $"{Id}|{Name}|{LastName}|{Email}|{Password}";
		}
	}
}
