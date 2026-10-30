using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson12
{
	internal class ArrayHelper
	{

		public static void PrintArray<T>(T[] numbers)
		{

			foreach (var item in numbers)
			{
				Console.WriteLine(item);
			}

		}


		public static void PrintFirty<T>(T[] arr)
		{

			Console.WriteLine(arr[0]);
			

		}
		public static void PrintLast<T>(T[] arr)
		{

			Console.WriteLine(arr[arr.Length - 1]);


		}

		///Searches an array for a specified element.The type of elements in the array.The array to search.The element to locate in the array.
	    public static void FindElement<T>(T[] colleciotn, T el  )
		{
			foreach (var item in colleciotn)
			{
				if(item.Equals(el))
				{
					Console.WriteLine(el);
				}
			}

		}
	
	
	}
}
