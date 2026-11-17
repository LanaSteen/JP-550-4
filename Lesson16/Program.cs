namespace Lesson16
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine();

			#region hw

			////შექმენით Player კლასი.უნდა ჰქონდეს სახელი, ქულა, აქტიურის სტატუსი.
			////შექმენით მოთამაშეების კოლექცია 10 ობიექტით.
			////კოლექციიდან დაალაგეთ მოთამაშეები ქულების მიხედვით(კლებადიბით) და დაბეჭდეთ
			//// კონსოლში თითოეული.
			////დაბეჭდეთ მხოლოდ ის მოთამაშეები რომლების სტატუსიც აქტიურია.
			////გამოიტანეთ კონსოლში მაქსიმალური ქულის მქონე მოთამაშე.
			////დაბეჭდეთ კონსოლში მინიმალური ქულის მქონე მოთამაშე რომლის სტატუსიც არის აქტიური.


			//List<Player> players = new List<Player>
			//{
			//	new Player(){ Name = "Player1", Score = 100, IsActive = true },
			//	new Player("Name1", 100, true),
			//	new Player("Player2", 200, false),
			//	new Player("BPlayer3", 300, true),
			//	new Player("APlayer4", 300, true),
			//	new Player("APlayer4", 300, false),
			//	new Player("Player6", 300, true),
			//	new Player("Player7", 350, false),
			//	new Player("Player8", 500, true),
			//	new Player("Player9", 450, false),
			//	new Player("Player10", 600, true)
			//};



			//players.First(p => p.Score > 200);
			//players.FirstOrDefault(p => p.Score > 200);


			//players.Count(x => x.Score>300);

			//players.Any(x => x.Score > 300);





			//var sortedPayers = players.OrderByDescending(p => p.Score).ThenBy(p => p.Name).ThenByDescending(p => p.IsActive);

			//foreach (var item in sortedPayers)
			//{
			//	Console.WriteLine(item);
			//}


			//var activePlayers = players.Where(p => p.IsActive);

			//foreach (var item in activePlayers)
			//{
			//	Console.WriteLine(item);
			//}




			//var maxScorePlayer = players.OrderByDescending(p => p.Score).FirstOrDefault();

			//// todo : use MaxBy instead of OrderByDescending

			//var maxScore = players.Max(p => p.Score);
			//// max int

			//var maxscorewithmaxBy = players.MaxBy(p => p.Score);
			//// maxby object

			//Console.WriteLine(maxScore);
			//Console.WriteLine(maxscorewithmaxBy); //600
			/////////////

			//var minScoreplayer = players.Where(p => p.IsActive).Min(p => p.Score);
			//Console.WriteLine(minScoreplayer);





			//var palyernames = players.Select(p => new { p.Name, p.Score });



			//foreach (var item in palyernames.Skip(5).Take(5))
			//{
			//	Console.WriteLine(item);
			//}



			#endregion


			//[]
			//List

			//IList
			//	ICollection

			//IEnumerable


			//HashSet<int> values = new HashSet<int> { 1, 2, 2, 3, 4, 5, 6, 7, 8, 9 };
			//values.Add(1);
			//values.Add(1);
			//foreach (var item in values)
			//{
			//	Console.WriteLine(item);
			//}



			//List<int> numebrs = new List<int> { 1, 1, 1, 2, 2, 3, 4, 5, 6, 7, 8, 9 };

			//var uniqueNumbers = numebrs.ToHashSet();
			//foreach (var item in uniqueNumbers)
			//{
			//	Console.WriteLine(item);
			//}


			/// LIFO - Last In First Out


			//Stack<int> stack = new Stack<int>();
			//stack.Push(10);
			//stack.Push(22);

			////("youtube", "facebook", "instagram", "tiktok")
			//stack.Peek();
			//stack.Pop();
			//stack.Peek();
			//stack.Pop();



			///// FIFO - First In First Out

			////Queue<int> queue = new Queue<int>();
			////queue.Enqueue(10);
			////queue.Enqueue(22);


			//Queue<string> rigi = new Queue<string>();
			//rigi.Enqueue("pirveli adamiani");
			//rigi.Enqueue("meore adamiani");
			//rigi.Enqueue("mesame adamiani");


			//rigi.Peek();  // pirveli adamiani
			//rigi.Dequeue(); // pirveli adamiani


			//rigi.Peek();  // meore adamiani





			//////// 
			//Dictionary<string, string> dictionary = new Dictionary<string, string>();

			//if (dictionary.Keys.Contains("Hello"))
			//{

			//}

			//dictionary.Add("Hello", "gamarjoba");
			//dictionary.Add("Hello2", "Mogesalmebit");
			//dictionary.Add("Hello2", "Mogesalmebit2");

			//foreach (var item in dictionary)
			//{
			//	Console.WriteLine(item.Key + " " + item.Value);
			//}



			//Console.WriteLine(dictionary["Hello2"]);


			//"Hello" - "gamarjoba"
			//"Hello" - "Mogesalmebit"




			//"Manager" - "599050545"
			//	"Sales" - "599050545"
			//	ItSupport - 5656565652


			//Dictionary<string, string> phoneBook = new Dictionary<string, string>();

			//phoneBook.Add("Manager", "599050545");
			//phoneBook.Add("Sales", "599050545");
			//phoneBook.Add("ItSupport", "5656565652");



			//string key = Console.ReadLine();

			//if(!phoneBook.ContainsKey(key))
			//{
			//	string value = Console.ReadLine();
			//	phoneBook.Add(key, value);
			//}


			//Print();

			//Power(2, 3);  // 8
		}


		//public static void Print()
		//{
		//	Print();
		//}


		//2 3


		//2

		//public static int Power(int num, int pow)
		//{

		//}

	}
}


