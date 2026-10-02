namespace Lesson4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//			1.შექმენი 2 რიცხვისგან შედგენილი მასივი და დაბეჭდე
			//			
			//			კონსოლში პირველი რიცხვი უფრო დიდია თუ მეორე.


			//int[] arr1 = [50, 70];

			//Console.WriteLine(arr1[0] > arr1[1] ? "first is bigger" : "second is bigger");


			//2.შექმენი 3 რიცხვისგან შედგენილი მასივი და დაბეჭდე
			//კონსოლში თითოეული რიცხვი ლუწია თუ კენტია და დადებითია
			//თუ უაწყოფითია. (მაგალითად  „6 დადებითი ლუწი“ ან „-4 უარყოფითი ლუწი“
			//int[] num2 = [20, 45, 70];

			//string isEven;
			//string isNagaive;

			//Console.WriteLine(num2[0] >=0 ? isNagaive = "positive": isNagaive =  "nagative");
			//Console.WriteLine(num2[0] %2 == 0 ? isEven =  "even" : isEven = "odd");


			//Console.WriteLine($"{isNagaive} {isEven}");

			//int num123 = num2[0];
			//string isEven;
			//string isNagaive;

			//if(num123 <0)
			//{
			//	isNagaive = "nagative";
			//}

			//else
			//{
			//	isNagaive = "positive or zero";
			//}
			//if (num123 % 2 == 0)
			//{
			//	isEven = "Even";
			//}
			//else
			//{
			//	isEven = "odd";
			//}


			//3.შექმენი 5 მანქანის მოდელის სახელისგან შედგენილი მასივი და
			//კონსოლში დაბეჭდე ბოლო მოდელის სახელი.

			//0      1              2       3            4

			//string[] names = ["BMW", "Mercedess", "Wrangler", "Toyota", "Audi"];

			//Console.WriteLine(names[names.Length-1]);




			//loop -  

			//for // while // foreach // do while 



			//for (int i =5; i <15; i++)
			//{
			//	if(i == 7 || i == 8 || i ==9 || i ==10 || i == 11 || i == 12 || i == 13 || i == 14)
			//	{
			//		continue;  // skip
			//	}
			//	Console.WriteLine("hi " + i);
			//}
			//for (int i = 0; i < 10; i++)
			//{
			//	if(i == 6)
			//	{
			//		break;
			//	}
			//	Console.WriteLine(i);
			//}
			//

			//int[] arr = [20, 15, 30,80,12];



			//for (int i = 0; i < arr.Length; i++) 
			//{
			//	Console.WriteLine(arr[i]);
			//}


			//int x = 5;

			//int y = 10;


			//int temp = x;  // 5

			//x = y;  // 10
			//y = temp;  // 5
			//
			//int[] numbers = [50, 70, 60, 30, 20, 15];

			////numbers[0]
			////	numbers[1]



			//for (int j = 0; j < numbers.Length; j++)
			//{
			//	for (int i = 0; i < numbers.Length - 1; i++)
			//	{

			//		if (numbers[i] > numbers[i + 1])
			//		{

			//			int temp = numbers[i];
			//			numbers[i] = numbers[i + 1];

			//			numbers[i + 1] = temp;
			//		}

			//	}

			//}


			//for (int i = 0; i < numbers.Length; i++)
			//{
			//	Console.WriteLine(numbers[i]);
			//}



			Console.WriteLine();
			

			Random random = new Random();

			
			Console.WriteLine(random.Next(0,100));

			Console.WriteLine(int.MaxValue);



			int[] emptyArr = new int[5];
			///  [0, 0 ,0 ,0 ,0 ]


			for (int i = 0; i < emptyArr.Length; i++)
			{

				emptyArr[i] = random.Next(0, 100);
			}


			for (int i = 0; i < emptyArr.Length; i++)
			{
				Console.WriteLine(emptyArr[i]);
			}


			foreach (var item in emptyArr)
			{
				Console.WriteLine(item);
			}





			//3 სახელი  
			//დავბეჭდოთ ყველა სახელის სიგრძე

			//string[] names = ["dsddsd", "sddsds", "Fdfdf"];

			//foreach (var name in names)
			//{
			//	Console.WriteLine(name.Length);
			//	Console.WriteLine(name[0]);
			//}



			string rame = "dsdfgfdhhfgjhkj";


		}
	}
}
