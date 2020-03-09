using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDatastructure.SearchingAlgorithms
{
    class InterpolationSearchAlgorithms
    {
        public bool InterpolationSearch(int[] arr, int target)
        {
            int min = 0;
            int max = arr.Length - 1;

            while(min <= max)
            {
                int scale = (target - arr[min])/(arr[max]-arr[min]);

                int mid = min + (max - min) * scale;

                if (arr[mid] == target) return true;

                if (arr[mid] > target)
                    min = mid + 1;
                else
                    max = mid - 1;
                
            }

            return false;
        }
    }
}
