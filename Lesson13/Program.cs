using System.Globalization;

namespace Lesson13
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//int[] numbers = [20, 30, 60];
			////ArrayHelper.PrintReverse(numbers);
			//numbers.PrintReverse();

			//string[] strings = ["a", "b", "c"];
			//strings.PrintReverse();


			//int number = 50;
			////number.PrintNumber();

			////int[]

			//int[] numbersNew = [10, 560, 30];
			//List<int> numbersList = numbersNew.ToList();
			//numbersList.Add(500);

			//List<int> empty = new List<int>();
			//List<int> numbers123 = new() { 20, 30, 60 };
			//List<int> nnumbers = [2,45,65];

			//nnumbers.Add(100);
			//nnumbers.AddRange(202, 60, 30);

			//nnumbers.AddRange(numbersNew);
			//nnumbers.AddRange(new[] { 20, 30 });

			////numbers.Append(50);


			//nnumbers.Insert(1, 500);
			//nnumbers.Clear();



			//Console.WriteLine(nnumbers.Count());


			//for (int i = 0; i < nnumbers.Count(); i++)
			//{
			//	Console.WriteLine(nnumbers[i]);
			//}

			//Console.WriteLine(nnumbers[nnumbers.Count() - 1]);
			//Console.WriteLine(nnumbers[0]);



			//List<User> list = new();
			//Console.WriteLine(list.Count);
			//Console.WriteLine(list.Capacity);

			//list.Add(new User());
			//Console.WriteLine(list.Count);
			//Console.WriteLine(list.Capacity);



			//list.Add(new User());

			//list.Add(new User());

			//list.Add(new User());

			//list.Add(new User());
			//Console.WriteLine(list.Count);
			//Console.WriteLine(list.Capacity);
			//list.Add(new User());

			//list.Add(new User());

			//list.Add(new User());
			//for (int i = 0; i < 1000000; i++)
			//{
			//	list.Add(new User());
			//}

			//list.Add(new User());
			//Console.WriteLine(list.Count);
			//Console.WriteLine(list.Capacity);




			//list.TrimExcess();
			//Console.WriteLine(list.Count);
			//Console.WriteLine(list.Capacity);
			//
			int[] ints = [20, 60, 30];
			ints.PrintReverse();


			List<int> numbers = new List<int>();
			numbers.PrintReverse();

		}


		//public static void PrintNumber(this int num)
		//{
		//	Console.WriteLine(num);
		//}


	}
}
