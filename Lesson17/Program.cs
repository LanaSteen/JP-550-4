using Lesson17.Models;
using Lesson17.Services;

namespace Lesson17
{
	internal class Program
	{
		static void Main(string[] args)
		{

	

		

			User user = new User();

			//user.Id =1;

			Console.WriteLine("Enter user name");
			user.UserName = Console.ReadLine();

			Console.WriteLine("Enter user Email");
			user.Email = Console.ReadLine();


			Console.WriteLine("Enter user password");
			user.Password = Console.ReadLine();



			FileManager fm = new FileManager();
			fm.RegisterUser(user);



			List<User> users = fm.GetAllUsers();


			foreach (var item in users)
			{
				Console.WriteLine(item);
			}











			//Console.WriteLine(Power(2, 3));    //2

			//Console.WriteLine(Fact(5));


			//File


		}





		//Solid


		//2 ^  3 
		//2  *  2 ^ 2
		//2  *  2 ^ 1
		//2


		//public static int Power(int num, int power) 
		
		//{

		//	if (power == 1)
		//	{
		//		return num;
		//	}
		//	return num * Power(num, power - 1);


		//}


		//5!       = 5 * 4 * 3 * 2 * 1 

		//5 * 4!
		//4 * 3!
		//3 * 2!
		//2 * 1!
		//1




		//public static int Fact(int num)
		//{
		//	if (num == 1) 
		//	{
		//		return 1;
		//	}


		//	return num * Fact(num-1);
		//}

	}
}
