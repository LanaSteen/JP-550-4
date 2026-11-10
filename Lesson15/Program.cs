namespace Lesson15
{
	internal class Program
	{
		static void Main(string[] args)
		{


			//int[] numbers = [50, 30, 25, 78, 90];

			//var saleNumbers =   numbers.CustomSelect(x => x - x*25/100 );


			//foreach (var item in saleNumbers)
			//{
			//	Console.WriteLine(item);
			//}



			//sale 25%


			//45

			//var newNumbers =	numbers.CustomWhere(x => x >= 45);

			//foreach (var item in newNumbers)
			//{
			//	Console.WriteLine(item);
			//}





			//LinQ




			//int[] arr = [50, 60, 30, 80, 90, 30];


			//arr.Where(x => x > 50).Select(x => x + 10).OrderBy(x=>x);



			////>60


			//arr.Where(x=>x>65);
			//arr.First(x=> x>50);

			//arr.Last(x=> x>100);   // exception
			//arr.LastOrDefault(x => x > 100);   // 0


			//arr.Single(x=>x>50);  // true   an excption

			//arr.SingleOrDefault(x => x > 50);  // false


			//arr.Select(x=>x*2);


			//arr.Sum(x=>x);
			//arr.Average(x=>x);

			//arr.Any(x=>x>50); 
			//arr.All(x=>x>100);


		 //   arr.Skip(5).Take(5);  // paging













			//int pageNumber = arr.Count()/12;

			//int pageIndex = 0;
			//arr.Skip(pageIndex).Take(12);

			//for (int i = 0; i < pageNumber; i++)
			//{
			//	pageIndex++;
			//	arr.Skip(pageIndex * 12).Take(12);
			//}








			Product product = new Product();
			product.Name = "Test";
			product.Price = 100;

			Product product2 = new Product();
			product2.Name = "Test3";
			product2.Price = 80;

			Product product3 = new Product();
			product3.Name = "Test2";
			product3.Price = 80;



			Product product4 = new Product();
			product4.Name = "Test4";
			product4.Price = 105;



			List<Product> products = new List<Product>() {product, product2, product3, product4 };

			products.Where(x => x.Name == "Test3");


			products.Where(x => x.Price > 50).OrderBy(x=> x.Price).ThenBy(x=>x.Name);


		}
	}
}
