using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson17.Models
{
	internal class User
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public string  Email { get; set; }
		public string Password { get; set; }

		public override string? ToString()
		{
			return $"{Id}|{UserName}|{Email}|{Password}";
		}
	}
}
