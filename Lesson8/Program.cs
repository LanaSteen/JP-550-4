namespace Lesson8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Student student = new();

			student.Name = "Test";
			student.Surname = "Test";

			//student.Age = 150;

			//student._age

			student.Gdare = 15;

			student.Info();
			Student.Print();

			Console.WriteLine();


			student.Age = 30;



			Console.WriteLine(student.Age);


			student.Group = "";



		}
	}
}
