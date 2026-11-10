namespace Lesson14
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Product prod1 = new();
			prod1.Id = 1;
			prod1.Name = "rame";


			Product prod2 = new();
			prod2.Id = 1;
			prod2.Name = "rame";


			Console.WriteLine(prod1.Equals(prod2));

			List<Product> products = new List<Product> { prod1, prod2 };

			//products.PrintAllElemnts();

			Console.WriteLine(products.FindElement(prod2));


			int[] numbers = [20, 60, 30, 50];

			numbers.CustomFilter(x=> x > 35);
			numbers.CustomFilter(x => x < 35);
			numbers.CustomFilter(x => x >0);
			numbers.CustomFilter(x => x %2 == 0);





			List<string> emails = new List<string>()
			{
				"dssds@fddfg",
				"gfgd@dggd"
			};


			emails.IsValidAll(x=> x.Contains("@"));  // true



			List<string> passwords = new List<string>()
			{
				"dssds12fddfg",
				"gfgd44ggd"
			};


			passwords.IsValidAll(x=> x.Length > 8);
			

			passwords.IsValidAll(asDelegate);
			passwords.IsValidAll(emailContains);


			passwords.IsValidAll( x => x.Length > 8);

			bool asDelegate(string pass)
			{
				return pass.Length > 8;
			}

			bool emailContains(string email)
			{
				return email.Contains("@");
			}

			//email  @ 
			//password > 8

			//IsValidAll 
		}
	}
}
