using Lesson18.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson18.Repositories
{
	internal class FileManager
	{
		string userFilePath = "C:\\Users\\l4nst\\Desktop\\new-jp-550-4\\Lesson18\\Data\\User.txt";


		public void AddUser(User user)
		{
			File.AppendAllLines(userFilePath, [user.ToString()]);
		}
	}
}
