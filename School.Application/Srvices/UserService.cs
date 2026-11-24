using School.Domain.Interfaces;
using School.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Application.Srvices
{
	public class UserService
	{

		private readonly IUserRepository _userRepository;
		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}


		public List<User> GetAllUsers()
		{
			return _userRepository.GetAllUsers();
		}
	}
}
