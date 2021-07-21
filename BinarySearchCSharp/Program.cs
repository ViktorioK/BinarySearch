using System;

namespace BinarySearchCSharp
{
    class Program
    {
        public static void Main()
        {
			int[] arr = { 2, 4, 6, 8, 10, 20, 40, 80 };
			int x = 10;
			int index = BinarySearch(arr, 0, arr.Length - 1, x);

			Console.WriteLine(index == -1 ? "Element is not present." : "Element is present at index " + index);
		}

		public static int BinarySearch(int[] arr, int left, int right, int x)
		{
			if (right >= left)
			{
				int middle = (left + right) / 2;

				if (x == arr[middle])
				{
					return middle;
				}

				if (x < arr[middle])
				{
					return BinarySearch(arr, left, middle - 1, x);
				}

				return BinarySearch(arr, middle + 1, right, x);
			}

			return -1;
		}
	}
}