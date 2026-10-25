namespace Lesson10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Doctor doctor = new Doctor();

			doctor.FullName = "ajpijas";
			doctor.Salary = 2000;
			doctor.Speciality = "asds";
			//doctor.WorkingHours = 20;


			Console.WriteLine("Enter amount");
			//doctor.Amount =int.Parse(Console.ReadLine());  ///   try parse


			//'fgfghfhf'


			bool isValid = int.TryParse(Console.ReadLine(), out int amount);
			//false                                          // 0

			int x = 0;
			try
			{
				x = int.Parse(Console.ReadLine());
				Console.WriteLine(x);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);

			}
			Console.WriteLine(x);




			//doctor.CalculateBonus(10);


			//Console.WriteLine(doctor);


			//Helper.Print();

			Console.WriteLine("Hello, World!");


		}
	}
}
