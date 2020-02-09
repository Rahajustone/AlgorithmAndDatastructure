using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDatastructure.NumericalAlgorithms
{
    class GCDAlgorithms
    {
        // General with O(n)
        public static int GcdGeneral(int a, int b)
        {
            int max = Math.Max(a, b);
            for (int i = max; i > 1; i--)
            {
                if (a % i == 0 && b % i == 0)
                    return i;
            }

            return 1;
        }

        // General recursive 
        public static int GcdGeneralRecursive(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            if (a == b)
                return a;

            if (a > b)
                return GcdGeneralRecursive(a - b, b);

            return GcdGeneralRecursive(a, b-a);
        }

        // Euclidean algorithm
        public static int GcdEuclideanRecursive(int a, int b)
        {
            if (b == 0)
                return a;

            return GcdEuclideanRecursive(b, a % b);
        }

        // Euclidean algorithm of an Array
        // Array of Numbers
        public static int GcdEuclideanRecursive(int[] arr, int n)
        {
            int result = arr[0];
            for (int i = 0; i < n; i++)
            {
                result = GcdEuclideanRecursive(arr[i], result);

                if (result == 1)
                    return 1;
            }

            return result;
        }
    }
}
