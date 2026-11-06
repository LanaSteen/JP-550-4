using System;
using System.Collections.Generic;
using System.Text;

///  Action  /// void
///  predicate  //  bool 
///  func   //  ნებისმიერ ტიპს


//delegates

namespace Lesson14
{
	internal static class CollectionHelper
	{

		public static void PrintAllElemnts<T>(this IEnumerable<T> collection)
		{
			foreach (var item in collection)
			{
				Console.WriteLine(item);
			}
		}


		public static void PrintReverseAllElemnts<T>(this IEnumerable<T> collection)
		{
		
			foreach (var item in collection.Reverse())
			{
				Console.WriteLine(item);
			}
		}


		public static T GetFirstElement<T>(IEnumerable<T> collection)
		{
			foreach (var item in collection)
			{
				return item;
			}

			return default;
		}


		public static T GetLastElement<T>(IEnumerable<T> collection)
		{
			T last = default;

			foreach (var item in collection)
			{
				last = item;
			}
			return last;
		}

		public static T FindElement<T>(this IEnumerable<T> collection, T el)
		{
			foreach (var item in collection)
			{
				if (item.Equals(el))
				{
					return el;
				}
			}
			return default;
		}



		public static List<T> FindElementsMetia<T>(this IEnumerable<T> collection, T el) where T : IComparable<T>
		{
			List<T> list = new List<T>();
			foreach (var item in collection)
			{
				if(item.CompareTo(el) > 0 )
				{
					list.Add(item);
				}
			}

			return list;
		}


		public static List<T> CustomFilter<T>(this IEnumerable<T> collection, Predicate<T> logika)
		{
			List<T> newList = new List<T>();

			foreach (var item in collection)
			{
				if (logika(item))
				{
					newList.Add(item);
				}
			}

			return newList;
		}

	



		public static bool IsValidAll<T>(this IEnumerable<T> collection, Predicate<T> logika)
		{

			if(collection == null || collection == default)
			{
				return false;
			}


			foreach (var item in collection)
			{
				if (!logika(item))
				{
					return false;
				}
			}
			return true;
		}




	}
}



//50,60,30,70     35 

//                 true
//arr.filter(x => x %2==0)