using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13
{
	internal static class CollectionHalper
	{

		public static T GetFirstElement<T>(this IEnumerable<T> collection)
		{
			foreach (var item in collection)
			{
				return item;
			}

			return default;
		}


		public static T GetLastElement<T>(this IEnumerable<T> colection)
		{
			T last = default;

			foreach (var item in colection)
			{
				last = item;
			}
			return last;
		}

		public static T GetBeforeLastElement<T>(this IEnumerable<T> colection)
		{
			int idex = 0;
			foreach (var item in colection)
			{
				idex++;
				if (idex == colection.Count() - 1)
				{
					return item;
				}
			
			}

			return default;

		}



		public static int FindIndex<T>(this IEnumerable<T> colection, T el)
		{
			int index = 0;
			foreach (var item in colection)
			{
				if (item.Equals(el))
				{
					return index;
				}
				index++;
			}
			return -1;
		}

		public static int FindIndex<T>(this IList<T> colection, T el)
		{
			foreach (var item in colection)
			{
				if (item.Equals(el))
				{
					return colection.IndexOf(item);
				}
			}
			return 0;
		}


		public static List<T> FindAll<T>(this IEnumerable<T> colection, T el) where T : IComparable<T>
		{
			{
				List<T> list = new List<T>();


				foreach (var item in colection)
				{
					if (item.CompareTo(el) > 0)
					{
						list.Add(item);
					}
				}
				return list;
			}
		}
	}
}

//[20,30,60,15, 70]   35   [60,70]

// დაწერეთ ისეთი ჯენერიკ მეთოდი რომელიც
// იმუშავებს ნებისმიერ კოლექციაზე 
//და გადაცემული კოლექციიდან დააბრუნებს
//ელემენტებს რომელიც მეტია გადაცემულ ელემენტზე