using System;
namespace AlgorithmAndDatastructure.SearchingAlgorithms
{
	public class CustomSearching
	{
		public CustomSearching()
		{
		}

		public bool LinearSearch(int target, params int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == target) return true;
			}

			return false;
		}

		public bool BinarySearch(int target, params int[] arr)
		{
			int left = 0;
			int right = arr.Length;

			while (left<right)
			{
				int mid = (left + right) / 2;
				if (arr[mid] == target) return true;
				else if (arr[mid] > target) right = mid;
				else left = mid + 1;
			}

			return false;
		}
	}
}

