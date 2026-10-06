using System.Text;

namespace Lesson5
{
	internal class Program
	{
		static void Main(string[] args)
		{


			Console.OutputEncoding = Encoding.UTF8;
			Console.InputEncoding = Encoding.UTF8;



			//			1.შექმენით რიცხვების მასივი და დაითვალეთ ყველა რიცხვის ჯამი.

			//
			//int[] numbers = [20,15,3,8,10];

			//int sum = 0;

			//foreach (var number in numbers)
			//{
			//	//number
			//	Console.WriteLine(number);

			//	sum = sum + number;  // 35
			//}

			//Console.WriteLine($"Sum is {sum}");




			//2.შექმენით 5 ელემენტიანი რენდომული რიცხვებისგან
			//შედგენილი მასივი და იპოვეთ მასივში არის
			//თუ არა ყველა ელემენტი 10 ზე მეტი.

			//Random random = new Random();
			////Console.WriteLine(random.Next(1, 100));
			//int[] arr = new int[5];  // 0 0 0 0 0    arr[1]

			//for (int i = 0; i < 5; i++)
			//{
			//	int rand = random.Next(1, 100);
			//	arr[i] = rand;

			//}

			//bool isGreater = true;
			//foreach (var item in arr)
			//{
			//	if(item < 10)
			//	{
			//		isGreater = false;
			//	}
			//	Console.WriteLine(item);
			//}


			//Console.WriteLine(isGreater ? "yevla metia" : "zogierti ar aris 10 ze meti");



			//int count = 0;
			//foreach (var item in arr)
			//{
			//	if (item < 10)
			//	{
			//		count++;  // 1
			//	}
			//	Console.WriteLine(item);
			//}

			//Console.WriteLine(count >0 ? "zogierti ar aris 10 ze meti" : "yevla metia 10 ze");


			//3.შექმენით რიცხვების მასივი და დაითვალეთ რამდენი
			//კენტი და რამდენი ლუწი რიცხვია მასში.

			//int[] numbers = [15, 20, 33, 18,0, 19, 22];
			//int even = 0;
			//int odd = 0;

			//foreach (var number in numbers)
			//{

			//	if (number == 0)
			//	{
			//		continue;
			//	}

			//	else if (number % 2 == 1) 
			//	{
			//		odd++;
			//	}
			//	else if(number % 2 == 0)
			//	{
			//		even++;
			//	}
			//}

			//Console.ForegroundColor = ConsoleColor.DarkGreen;
			//Console.BackgroundColor = ConsoleColor.Black;
			////სტრინგის ინტერპოლაცია - სტრინგის გამოსახვა 
			//Console.Write($"ლუწი რიცხვები არის : {even} ");

			//Console.ForegroundColor = ConsoleColor.Red;
			//Console.BackgroundColor = ConsoleColor.Black;
			//Console.Write($"და კენტი რიცხვები არის {odd}");


			//Console.ForegroundColor = ConsoleColor.White;



			//for 
			//Random randomObj = new Random();
			//int randomNumber = randomObj.Next(1,10); // 7


			//int userNumber = int.Parse(Console.ReadLine());

			//while (randomNumber != userNumber)
			//{
			//	Console.WriteLine("you did not guess try again");
			//	userNumber = int.Parse(Console.ReadLine());
			//}

			//Console.WriteLine($"yuu guessed number was {randomNumber}");






			//int x = 5;
			//while(x > 5)
			//{
			//	Console.WriteLine("rame");
			//}


			//do
			//{
			//	Console.WriteLine("rame from do");
			//}
			//while (x > 5);





			//while

			int[] arr = { 1, 2, 3, 4, 5, 6 };

			int x = 0;
			do
			{
				Console.WriteLine(arr);
				x++;
			}
			while (x < arr.Length);

		}
	}
}

//StackOverflowException


//ICU
//   initialization  comparission   update
//for (int i = 0; i < Array.Length; i++