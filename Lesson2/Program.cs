namespace Lesson2
{
	internal class Program
	{
		static void Main(string[] args)
		{


			#region operators

			//Console.WriteLine("enter your score");

			//  int score =	int.Parse(Console.ReadLine());



			//Console.WriteLine("do you aagree");

			//bool isAgree = bool.Parse(Console.ReadLine());

			////5.3

			//double avgScore = double.Parse(Console.ReadLine());
			////'a'

			//char symbol = char.Parse(Console.ReadLine());

			//string name =Console.ReadLine();






			//opperaators 


			// + - * / %    
			//+=  -=  *=  /=   %=

			//Console.WriteLine(5+5);


			//int x = 10;
			//x += 10;

			//Console.WriteLine(x);   // 20



			////++ --   


			//Console.WriteLine(--x);   // 19
			//Console.WriteLine(x);


			////   >  <   >=   <=      ==   !=



			//Console.WriteLine(true != false);  // true

			//Console.WriteLine(5  !=5);  // false


			////!   not 


			//Console.WriteLine(!(5==5));  // false

			//Console.WriteLine(5>2 && 3==3);

			//Console.WriteLine(5 > 2 || 3 == 3);


			//  ?   // ternary operator

			//Console.WriteLine(5==5 ? "yes" : "no");

			//char symbol = char.Parse(Console.ReadLine());
			//Console.WriteLine(symbol == '!' ? "welcome" : "bye");

			//! 
			#endregion



			//?? null coalescing operator

			//string name = "john";

			//Console.WriteLine(name ?? "unknown");


			//int num1, nnum2, num2;

			//num2 = 10;



			// if   compariossion   action


			//int x = 5;

			//if (x>0 && x < 5) 
			//{
			//	Console.WriteLine("metia");
			//}
			//else if(x > 10)
			//{
			//	Console.WriteLine("10 ze metia");
			//}
			//else
			//{
			//	Console.WriteLine("ar aris martali");
			//}



			//  სახელი,
			//  ასაკი > 18 და < 60  
			//  მოქალაქეობა  "GEO"  --
			//  სახელი და შეგიძლია ბილეთი იყიდო



			//string name = "nika";
			//int age = 20;
			//string country = "geo";


			//if(age >= 18 && age <= 60   ) // 7
			//{

			//	if (country == "geo")
			//	{

			//		Console.WriteLine("you can buye ticket");
			//	}

			//	else
			//	{
			//		Console.WriteLine("you can buye ticket bcs you need passport");
			//	}
			//}

			//else
			//{
			//	Console.WriteLine("you age is not enough");
			//}



			//string dayname = "monday";


			//if(dayname == "monday" || dayname == "tusday")
			//{
			//	Console.WriteLine("working day");
			//}

			//switch (dayname)
			//{
			//	case "monday":
			//		Console.WriteLine("working day");
			//		break;
			//	case "tusday":
			//		Console.WriteLine("working day");
			//		break;

			//	default:
			//		Console.WriteLine("unknown day");
			//		break;
			//}




			int x = 3;


			switch (x)
			{
				case 1:
					Console.WriteLine("ertia");
					
					break;

				case 2:
					Console.WriteLine("oria");

					break;
				case 3:
					Console.WriteLine("samia");

					break;
				default:
					Console.WriteLine("unknown");

					break;
			}

		}
	}
}
