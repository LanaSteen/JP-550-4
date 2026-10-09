namespace Lesson6
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region hw

			//int[] transactions = { 120, -50, 300, -100, 80, -200, 500, -30, 150, -400 };
			//int countPositive = 0;
			//int countNegative = 0;
			//int sumPositive = 0;
			//int sumNegative = 0;


			//foreach (var item in transactions)
			//{

			//	if(item > 0)
			//	{
			//		Console.WriteLine("dadebitia");
			//		countPositive++;  // 120
			//		sumPositive += item;
			//	}
			//	else if(item == 0)
			//	{
			//		Console.WriteLine("egeti tanxas ver sheitan");
			//	}
			//	else
			//	{
			//		Console.WriteLine("uayofitia");
			//		countNegative++;
			//		sumNegative += -item;
			//	}
			//}

			//Console.WriteLine(sumPositive);
			//Console.WriteLine(sumNegative);
			//Console.WriteLine($"balance = {sumPositive - sumNegative}");


			#endregion

			#region loop
			//int[] rame = [50, 15, 32, 11];
			//int countEven = 0;
			//int sumEven = 0;


			//foreach (var item in rame)
			//{
			//	if(item % 2 == 0)
			//	{
			//		countEven++;
			//		sumEven += item;

			//	}
			//}


			//for (int i = 0; i < rame.Length; i++)
			//{
			//	if (rame[i] % 2 == 0 && i % 2 != 0)
			//	{
			//		countEven++;
			//		sumEven += rame[i];

			//	}
			//}


			//raodenoba
			//jami


			#endregion


			#region local functions

			//functions  vs method


			//function name(num1,nnum2)
			//{
			//	 return num1 + num2
			//}


			//local funtion

			//int Sum(int num1, int num2)
			//{
			//	return num1 + num2;
			//}


			//void Print()
			//{
			//	Console.WriteLine("hi");
			//}


			//Print();

			//int jami = Sum(1, 2);  // 3
			//Console.WriteLine(jami);

			//Console.WriteLine(Sum(5,6));



			//შექმენით ლოკალური ფუნქცია რომელიც დააბრუნებს რენდომულ რიცხვს 1000 9999

			//int GetPassCode()
			//{

			//	Random random = new Random();

			//	return random.Next(100000, 999999);
			//}


			//int[] passCodeArr = new int[5];  // 0,0,0,0,0

			//for (int i = 0; i < passCodeArr.Length; i++)
			//{
			//	passCodeArr[i] = GetPassCode();
			//}



			// bool parameters 2 cali ricxvi  



			bool IsGreater(int x, int y) 
			{
				//  if(x > y)
				//	{
				//		return true;
				//	}
				//else
				//	{
				//		return false;
				//	}
				return x > y;  // false
			
			}

			//Console.WriteLine(IsGreater(6,66));




			//int GetLength(string text)
			//{
			//	return text.Length;
			//}

			//Console.WriteLine(GetLength("dsfdffgfd dsdfgfhfg dfdggfhjgj dgfhgj"));




			// შექმენით ფუნქცია რომელშიც თუ გადაცემმული ტექსტი
			// 50 სიმბვოლოზე ნაკლებია დააბეჭდავს "invalid input'
			// და თუ 50 მეტია მეშინ ეს ტექსტი გამოიტანოს


			//void CheckText(string text)
			//{
			//	Console.WriteLine(text.Length < 50 ? "invalid input" : text);
			//}

			//CheckText("dsd dsdfgf dsffgf dfd sfgfg fghgg fghfc dfsfgfggx fggfgfgfgfgffgfgf ffsfdfsfsfsfsfsdff");



			#endregion

		    Print();



			Console.WriteLine();

			Random random1 = new Random();
			random1.Next();
		

		}


     	protected static void Print()
		{
			Console.WriteLine("dsdgfdgh");
		}




	}


}
