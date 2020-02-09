namespace AlgorithmAndDatastructure.SearchingAlgorithms
{
    class BinarySearchAlgorithms
    {
        // Binary Search Algorithms
        public static bool BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                    return true;
                if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return false;
        }

        public static bool BinarySearchRecursive(int[] arr, int left, int right, int target)
        {
            if (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return true;

                if (arr[mid] < target)
                    return BinarySearchRecursive(arr, mid + 1, right, target);

                return BinarySearchRecursive(arr, left, mid - 1, target);
            }

            return false;
        }
    }
}