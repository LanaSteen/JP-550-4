using School.Domain.Interfaces;
using School.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infrastructure.Repositories
{
	public class UserRepository  : IUserRepository
	{
		private readonly string _path = "C:\\Users\\l4nst\\Desktop\\new-jp-550-4\\School.Infrastructure\\Data\\User.txt";

	

		public List<User> GetAllUsers() 
		{
			return default;
		}


		public void AddUser(User user)
		{

		}

	}
}
