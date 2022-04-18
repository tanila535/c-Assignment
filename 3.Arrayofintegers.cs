using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.arrayofintegers
{
	class Integers
	{

		static int sum(int[] arr, int n)
		{

			int sum = 0;


			for (int i = 0; i < n; i++)
				sum += arr[i];

			return sum;
		}
		public static void Main()
		{

			int[] arr = { 34, 43, 64, 25 };
			int n = arr.Length;

			Console.Write("Sum of given integer is "
								+ sum(arr, n));
		}

	}

}
