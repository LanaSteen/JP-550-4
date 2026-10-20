using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9
{
	internal class AdminUser : ParentUser
	{
		

		public void DeleterUser(User user)
		{
			Console.WriteLine($"User {user.Name} has been deleted.");
		}

	
	}
}
