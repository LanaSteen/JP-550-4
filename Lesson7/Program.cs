using System.Security.Cryptography.X509Certificates;

namespace Lesson7
{
	internal class Program
	{



		static void Main(string[] args)
		{

			#region hw


			//			1.შექმენით ლოკალური ფუნქცია რომელიც პარამეტრად მიიღებს
			//			ინტების მასივს და დააბრუნებს ამ მასივის ელემენტების ჯამს.





			//int[] arr = [20, 15, 30];

			//Console.WriteLine(Sum(arr));


			//int Sum(int[] x)
			//{
			//	int sum = 0;
			//	foreach (var item in x)
			//	{
			//		sum += item;
			//	}


			//	return sum;
			//}	



			//2.შექმენით ლოკალური ფუნქცია რომელიც პარამეტრად მიიღებს
			//3 ტექსტს და დაბეჭდავს კონსოლში ამ სამი ტექსტისგან გაერთიანებულ ერთ ტექსტს.


			//void PrintText(string text1, string text2, string text3)
			//{
			//	Console.WriteLine($"{text1} {text2} {text3}");
			//}




			//3.შექმენით მეთოდი რომელიც პარამეტრად მიღებული
			//სტრინგების მასივის ყველა ელემენტს გააერთიანებს ერთ ტექსტად
			//და დააბრუნებს ერთ სტრინგს.


			//string[] names = ["John", "James"];


			////"Jophn James"

			//Console.WriteLine(GetText(names));

			#endregion

			//int[] array = [50, 20, 30];


			//Helpers.PrintArray(array);



			//Helpers helpers = new();

			//helpers.PrintArrayNonStatic(array);


			//User user1 = new();
			//user1.FirstName = "Test";
			//user1.LastName = "Test";
			//user1.Email = "Test";
		 //   user1.Password = "Test";



			//Console.WriteLine(user1.FirstName
			//	+ " " + user1.LastName
			//	);




			//User user2 = new();
			//user2.FirstName = "dsf";
			//user2.LastName = "dsdsds";
			//user2.Email = "dffdf";
			//user2.Password = "Tefdfdfdst";






			//User x = new();
			//x.Age = 50;
			//x.FirstName = "John";



			Product product1 = new();

			product1.Name = "Phone";
			product1.Price = 60m;
			product1.Amount = 50;
			product1.DisplayInfo();

			//Console.WriteLine(product1.ConvertedInGel());

			//Product.PrintHeloo();


			Product product2 = new();

			product2.Name = "PowerBAnk";
			product2.Price = 20m;
			product2.Amount = 10;
			//Console.WriteLine(product2.ConvertedInGel());

			product2.DisplayInfo();

			// პროდუქტი სახელი, ფასი, რაოდენობა


			//Console.WriteLine(product2);


			//სტუდენტის კალსი






			string productname = "dsddd";
			string productdescription = "dsdsdsds";

			int productPrice = 50;


			string produc2tname = "dsddd";
			string product222description = "dsdsdsds";

			int product2Price = 50;

		


			string name = "sds";


		

			int x = 5;
			int y = x;

			//5 5

			y = 10;

			//5 10


			int[] arr = [20, 03, 60];
			int[] arr2 = arr;

			//[20, 03, 60]; [20, 03, 60];
			//arr2[0] = 500;

			//[500, 03, 60]; [500, 03, 60];
		}


		//public static string GetText(string[] texts)
		//{

		//	string fullText = "";

		//	foreach (var item in texts)
		//	{
		//		fullText += item;
		//		fullText += " ";
		//	}


		//	return fullText;
		//}



		//o o p 



	}
}
