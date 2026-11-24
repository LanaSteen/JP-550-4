using School.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Domain.Interfaces
{
	public interface IUserRepository
	{
		List<User> GetAllUsers();
		void AddUser(User user);
	}
}
