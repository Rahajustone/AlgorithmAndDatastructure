using System.Linq;

namespace AlgorithmAndDatastructure.SearchingAlgorithms
{
    class LinearSearchAlgorithms
    {
        // Basic Linear Search
        public static bool SeqSearch(int[] arr, int value)
        {
            foreach (var element in arr)
                if (element == value)
                    return true;

            return false;
        }

        // Generics Linear Search
        public static bool SeqSearch<T>(T[] arr, T value)
        {
            foreach (var element in arr)
                if (element.Equals(value))
                    return true;

            return false;
        }

        // Basic Linear Search With LINQ
        public static bool SeqSearchLinq(int[] arr, int value)
        {
            return arr.Any(x => x.Equals(value));
        }

        // Search Min element
        public static int FindMin(params int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < min)
                    min = arr[i];
            return min;
        }

        // Search MinLength
        // Find min word in array
        public static string FindMin(params string[] arr)
        {
            int min = arr[0].Length;
            int j = 0;
            for (int i = 1; i < arr.Length; i++)
                if (arr[i].Length < min)
                {
                    min = arr[i].Length;
                    j = i;
                }

            return arr[j];
        }
    }
}