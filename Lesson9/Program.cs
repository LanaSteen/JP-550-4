namespace Lesson9
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			User user = new User();
		
			//user.Print();


			//Console.WriteLine(user);  ///  to string



			Student st = new Student();
			st.Name = Console.ReadLine();
			st.Email = "dsdssd";
			st.Grade = 10;

			st.Speak();



			Teacher te = new Teacher();
			te.Name = Console.ReadLine();
			te.Email = "dsdssd";
			te.Salary = 1000;


			//Person pers = new Person();
			//pers.Name = "dsdsd";
			//pers.Email = "dsdssd";

		}
	}
}




//student teacher 
//name email
//grade
//salarry