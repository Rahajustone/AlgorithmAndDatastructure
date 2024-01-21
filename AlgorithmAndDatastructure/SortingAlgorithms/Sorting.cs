using System;
namespace AlgorithmAndDatastructure.SortingAlgorithms
{
	public class Sorting
	{
		public Sorting()
		{
		}



		// Bubble Sorting change the Adjacent
		public static void BubbleSorting(int[] arr)
		{
			for (int i = 0; i < arr.Length-1; i++)
			{
				for (int j = (i+1); j < arr.Length; j++)
				{
					//Swap
					if (arr[i] > arr[j])
					{
						swap(arr, i, j);
					}
				}
			}

			foreach (var item in arr)
			{
				Console.WriteLine(item);

			}
		}

		// Selection Sorting
		public static void SelectionSort(int[] arr)
		{
			for (int i = 0; i < arr.Length-1; i++)
			{
                int min = i;


				for (int j=i+1; j < arr.Length; j++)
				{
					if (min > arr[j])
					{
						min = j;
					}
				}

				if (min != i)
				{
					swap(arr, i, min);
				}
			}

			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}

		// Insertion Sorting
		public static void InsertionSort(int[] arr)
		{
			for (int i = 1; i < arr.Length; i++)
			{
				int key = arr[i];
				int left = i - 1;

				while (left > -0 && arr[left] > key)
				{
					arr[left + 1] = arr[left];
					left--;
				}

				arr[left + 1] = key;

			}


			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
		}


		// Swap function
		private static void swap(int []arr, int a, int b)
		{
			int temp = arr[a];
			arr[a] = arr[b];
			arr[b] = temp; ;
		}

		// Factorial function
		// 3! = 3*(3-1)*(3-1-1)
		public static int Factorial(int n)
		{
			if (n==0||n==1)
			{
				return 1;
			}

			return n*Factorial(n - 1);
		}
	}


}

