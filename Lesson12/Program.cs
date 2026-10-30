namespace Lesson12
{
	internal abstract class Program
	{



	 

		static void Main(string[] args)
		{
#region gaxseneba


			//Console.WriteLine("Hello, World!");



			//Random random = new Random();
			//random.Next(1, 100);



			//Console.WriteLine();

			//int x = 5;

			//int[] numbers = [10, 20, 30];

			

			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.WriteLine(numbers[i]);
			//}
			//                  //JOHN
			//string[] names = ["        John     ", "Jane", "Bob"];


			//foreach (string item in names)
			//{
			//	Console.WriteLine(item.ToLower().Trim());
			//}



			//Console.WriteLine(names[names.Length - 1]);


			//string mail = "sasas@gmail.com";  // [sas, gmail.com]

			//var splied = mail.Split("@");

			//Console.WriteLine(splied[splied.Length - 1]);


			#endregion
			#region hw

			//			შექმენით კლასი იუზერი რომელსაც ექნება სახელი, პაროლი,
			//			მეილი და ავტორიზაციის მეთოდი რომელიც მომხმარებელს
			//			შეაყვანინებს მეილს და პაროლს.
			//ასევე შექმენით მემკვიდრე კლასები ClientUser და AdmminUser.

			//გადატვირთეთ კონსტრუქტორები, გამოიყენეთ აბსტრაქცია, მემკვიდრეობა, ინკაფსულაცია და პოლიმორფიზმი.





			//Client client = new Client("david", "password123", "david@gmail.com");

			//client.Authorize(Console.ReadLine(), Console.ReadLine());

			//Client client1 = new Client();




			//DisplayManu.ShowMenu();

			#endregion



			//Food 
			//  vegetarian
			//  title
			//  description

			//  method showIngredients


		 //  MainDish

		 //  Deserrt
				

			//T   ჯენერიკი   ზოგადი
			//
			//
			int[]   numbers = new int[5] { 1, 2, 3, 4, 5 };
			int[] numbers2 = new int[5] { 1, 2, 3, 4, 5 };


			ArrayHelper.FindElement(numbers, 3); // 3


			Product[] products = [];

			ArrayHelper.FindElement(products, new Product());


			Client[] clients = [];

			string[] strings = new string[5] { "a", "b", "c", "d", "e" };

			//ArrayHelper ah = new();
			//ah.PrintArray(numbers);

			ArrayHelper.PrintArray(numbers2);

			ArrayHelper.PrintArray(strings);

			ArrayHelper.PrintArray(products);
			ArrayHelper.PrintArray(clients);




		}





		//public static void PrintArray(int[] numbers)
		//{

		//	foreach (var item in numbers)
		//	{
		//		Console.WriteLine(item);
		//	}

		//}

		//public static void PrintArray(string[] numbers)
		//{

		//	foreach (var item in numbers)
		//	{
		//		Console.WriteLine(item);
		//	}

		//}
		//public static void PrintArray(Product[] numbers)
		//{

		//	foreach (var item in numbers)
		//	{
		//		Console.WriteLine(item);
		//	}

		//}

		//public static void PrintArray(Client[] numbers)
		//{

		//	foreach (var item in numbers)
		//	{
		//		Console.WriteLine(item);
		//	}

		//}

		//public static void PrintArray(Admin[] numbers)
		//{

		//	foreach (var item in numbers)
		//	{
		//		Console.WriteLine(item);
		//	}

		//}
	}

}



