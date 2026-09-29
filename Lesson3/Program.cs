namespace Lesson3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//			დავალება 1:
			//Login სისტემა:
			//username: admin
			//password: 1234

			//თუ სწორია:
			//Welcome!
			// თუ არა:
			//Access denied

			//string adminUserNmae = "admin";
			//string adminPassword = "1234";

			//string userName = Console.ReadLine();
			//string userPassword = Console.ReadLine();


			//if (userName == "admin" && userPassword == "1234")
			//{
			//	Console.WriteLine("Wlecome");
			//}
			//else
			//{
			//	Console.WriteLine("Access denied");
			//}


			//დავალება 2:
			//Calculator(switch-ით)
			//მომხმარებელი შეიყვანს:
			//•	რიცხვი 1
			//•	ოპერატორი(+-* /)
			//•	რიცხვი 2


			//int num1 = int.Parse(Console.ReadLine());

			//string operation = Console.ReadLine();

			//int num2 = int.Parse(Console.ReadLine());


			//switch (operation)
			//{
			//	case "+":

			//		Console.WriteLine(num1+num2);
			//		break;

			//	case "-":

			//		Console.WriteLine(num1 - num2);
			//		break;
			//	case "*":

			//		Console.WriteLine(num1 * num2);
			//		break;

			//	case "/":

			//		if (num2 != 0)
			//		{
			//			Console.WriteLine(num1 / num2);
			//		}
			//		else
			//		{
			//			Console.WriteLine("devide by zero is not possioble");
			//		}
			//		break;
			//	default:

			//		Console.WriteLine("Invalid operation");
			//		break;
			//}


			#region if
			//if (operation == "+")
			//{
			//	Console.WriteLine(num1 + num2);
			//}
			//else if (operation == "-") 
			//{
			//	Console.WriteLine(num1 + num2);
			//}
			//else if (operation == "*")
			//{
			//	Console.WriteLine(num1 * num2);
			//}
			//else if (operation == "/")
			//{
			//	if (num2!=0)
			//	{
			//		Console.WriteLine(num1 / num2);
			//	}
			//	else
			//	{
			//		Console.WriteLine("devide by zero is not possioble");
			//	}
			//}

			//else
			//{
			//	Console.WriteLine("Invalid operation");
			//}

			#endregion
			//დავალება 3 :
			//მომხმარებელს შეაყვანინე ასაკი:
			//		დაადგინე:
			//•	ბავშვი(0–12)
			//•	თინეიჯერი(13–19)
			//•	ზრდასრული(20–64)
			//•	პენსიონერი(65 +)

			//byte userAge = byte.Parse(Console.ReadLine());
			//if(userAge >=0 && userAge <= 12)
			//{
			//	Console.WriteLine("bavshvi");
			//}
			//else if (userAge >= 13 && userAge <= 19)
			//{
			//	Console.WriteLine("teenager");
			//}
			//else if (userAge >= 20 && userAge <= 64)
			//{
			//	Console.WriteLine("zrdasruli");
			//}
			//else if (userAge >=65)
			//{
			//	Console.WriteLine("pensioneri");
			//}







			//uk 
			//usa 
			//russia

			//bool uk = bool.Parse(Console.ReadLine());

			//bool usa = bool.Parse(Console.ReadLine());

			//bool russia = bool.Parse(Console.ReadLine());

			//if (uk && usa && russia)
			//{
			//	Console.WriteLine("afetqda");
			//}
			//else
			//{
			//	Console.WriteLine("ar afetqda");
			//}


			//error handling



			//int x = int.Parse(Console.ReadLine()); // "fdfdffdf"
			//Console.WriteLine(x);

			// "fdfdffdf"

			//false                                                 // 0

			//bool numIsvalid = int.TryParse(Console.ReadLine(), out int num);

			//Console.WriteLine(num);
			//Console.WriteLine(numIsvalid);




			//int num;

			//bool numIsvalid = int.TryParse(Console.ReadLine(), out num);

			//Console.WriteLine(num);
			//Console.WriteLine(numIsvalid);





			//int age;
			//bool ageIsvalid = int.TryParse(Console.ReadLine(), out age);



			//if(ageIsvalid && age >= 18)
			//{

			//	Console.WriteLine("You are an adult.");
			//}

			//else if (ageIsvalid && age < 18)
			//{

			//	Console.WriteLine("You are not an adult.");
			//}
			//else if(!ageIsvalid || age < 0 || age > 120)
			//{
			//	Console.WriteLine("Invalid age.");
			//}
			//else
			//{
			//	Console.WriteLine("Invalid input.");
			//}



			//int age;
			//bool ageIsvalid = int.TryParse(Console.ReadLine(), out age);

			//მომხმარებელმა შემოიყვანოს ქულა 0 100 მდე 
			//	90 ზე მეტია დაუბეჭდეთ "A"
			//	80 ზე მეტია დაუბეჭდეთ "B"	
			//	70 ზე მეტია დაუბეჭდეთ "C"
			//	60 ზე მეტია დაუბეჭდეთ "D"
			//	დანარჩენნი "F" 

			//byte score;
			//bool scoreIsValid = byte.TryParse(Console.ReadLine(), out score);

			//if (score <= 100)
			//{
			//	if (score > 90)
			//	{
			//		Console.WriteLine("A");
			//	}
			//	else if (score > 80)
			//	{
			//		Console.WriteLine("B");
			//	}
			//	else if (score > 70)
			//	{
			//		Console.WriteLine("C");
			//	}
			//	else if (score > 60)
			//	{
			//		Console.WriteLine("D");
			//	}
			//	else if (score <= 60 && scoreIsValid)
			//	{
			//		Console.WriteLine("F");
			//	}
			//}
			//else
			//{
			//	Console.WriteLine("Invalid score.");
			//}






			//მასივი // array

			int[] numbers = [20, 30, 60];

			numbers[1] = 100;   


			string[] names = ["Alice", "Bob", "Charlie"];




			int[] nums = new int[10];  ////  [0,0,0,0,0,0,0,0,0,0]

			nums[0] = 100;
			nums[1] = 200;


			string[] names2 = new string[5];  ////  [null,null,null,null,null]

			names2[0] = "Alice";
			names2[1] = "Bob";
			names2[2] = "Charlie";
			names2[3] = "David";
			names2[4] = "Eve";




			//5 ქვეყნის სახელი



		}
	}
}
