using System;
using System.Collections.Generic;
using System.Text;


//delegate
// predicate   // bool
// func //  all types
// action  // void


namespace Lesson15
{
	internal static class CollectionHalper
	{

		public static IEnumerable<T> CustomWhere<T>(this IEnumerable<T> collection, Predicate<T> pred   )
		{
			List<T> list = new List<T>();

			if (collection == null || collection.Count() == 0 || pred == null)
			{

				throw new Exception("collection or predicate is null or empty");
			
			}

			foreach (var item in list)
			{
				if (pred(item))
				{
					list.Add(item);
				}
			}

			return list;
		}
	
	
	

		public static bool  CustomAny<T>(this IEnumerable<T> collection, Predicate<T> pred)
		{


			if (collection == null || collection.Count() == 0 || pred == null)
			{

				throw new Exception("collection or predicate is null or empty");

			}

			foreach (var item in collection)
			{
				if (pred(item))
				{
					return true;
				}
			}


			return false;
		}



		public static bool CustomAll<T>(this IEnumerable<T> collection, Predicate<T> pred)
		{

			if (collection == null || collection.Count() == 0 || pred == null)
			{

				throw new Exception("collection or predicate is null or empty");

			}
			foreach (var item in collection)
			{
				if (!pred(item))
				{
					return false;
				}
			}
			return true;
		}



		public static int CustomCount<T>(this IEnumerable<T> collection, Predicate<T> pred = null)
		{
			if (collection == null || collection.Count() == 0)
			{

				throw new Exception("collection or predicate is null or empty");
			}

			int count = 0;

			if(pred != null)
			{
				foreach (var item in collection)
				{
					if (pred(item))
					{
						count++;
					}
				}
			}
			else
			{
				count = collection.Count();
			}

			return count;
		}




		public static IEnumerable<TResult> CustomSelect<TSourse, TResult>(this IEnumerable<TSourse> collection, Func<TSourse, TResult> func)
		{
			List<TResult> list = new List<TResult>();

			foreach (var item in collection)
			{
				list.Add(func(item));
			}


			return list;


		}



		public static T CustomFirstOrDefault<T>(this IEnumerable<T> col, Predicate<T> pred)
		{
			foreach (var item in col)
			{
				if (pred(item))
				{
					return item;
				}
			}

			return default;
		}


		public static T CustomFirst<T>(this IEnumerable<T> col, Predicate<T> pred)
		{
			foreach (var item in col)
			{
				if (pred(item))
				{
					return item;
				}
			}

			throw new Exception();
		}


		public static T CustomLastOrDefault<T>(this IEnumerable<T> col, Predicate<T> pred)
		{

			foreach (var item in col.Reverse())
			{
				if (pred(item))
				{
					return item;
				}
			}

			return default;
		}



		public static T CustomLast<T>(this IEnumerable<T> col, Predicate<T> pred)
		{

			foreach (var item in col.Reverse())
			{
				if (pred(item))
				{
					return item;
				}
			}

			throw new Exception();
		}
	}
}
