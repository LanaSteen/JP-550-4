using Lesson17.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson17.Services
{
	internal class FileManager
	{

	  private readonly	string path = @"C:\Users\l4nst\Desktop\new-jp-550-4\Lesson17\Data\user.txt";
	
	
	  public void RegisterUser(User user)
		{
			var users = GetAllUsers();

			int maxId = users.MaxBy(u => u.Id).Id;
			user.Id = ++maxId;

			File.AppendAllLines(path, [user.ToString()]);
		}
	

		public List<User> GetAllUsers()
		{

			List<string> lines = File.ReadAllLines(path).ToList();  // "1|dfdff|ddsds@sd|dsddsd", "", ""

			List<User> users = new List<User>();

			foreach (var line in lines)
			{
				string[] parts = line.Split("|");   // [1,dsdsd,dsdsds, ]
				User userFromfile = new User();

				userFromfile.Id = int.Parse(parts[0]);
				userFromfile.UserName = parts[1];
				userFromfile.Email = parts[2];
				userFromfile.Password = parts[3];

				users.Add(userFromfile);
			}


			return users;

		}
	
	}
}
