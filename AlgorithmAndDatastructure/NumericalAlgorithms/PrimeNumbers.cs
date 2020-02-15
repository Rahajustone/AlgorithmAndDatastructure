using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDatastructure.NumericalAlgorithms
{
    class PrimeNumbersAlgorithms
    {
        // Is a number is prime or not
        // O(n) worst case
        // But if is a number is even or divided by 3 time complexity will be O(1)
        public static bool IsPrimeNumber(int n)
        {
            // Improve speed
            // Number is even or divided by 3
            if (n % 2 == 0 || n %3 ==0)
                return false;

            for (int i = n-1; i > 1; i--)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        // IsPrimeNumber
        // O(sqrt(n))
        public static bool IsPrimeNumberGood(int n)
        {
            // Improve speed
            // Number is even or divided by 3
            if (n % 2 == 0 || n % 3 == 0)
                return false;

            int sqrtNumber = (int)Math.Sqrt(n) + 1;

            for (int i = sqrtNumber; i > 1; i--)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }

        // Finding prime factors
        // O(n)
        // List of integer
        public static int[] FindFactor(int number)
        {
            List<int> factors = new List<int>();
            int i = 2;
            while (i < number)
            {
                while (number % i == 0)
                {
                    factors.Add(i);
                    number = number / i;
                }

                i++;
            }

            if(number > i)
                factors.Add(number);

            return factors.ToArray();
        }


        // Finding prime factors
        // Improve the Algorithms
        // List of integer
        public static int[] FindFactorGood(int number)
        {
            List<int> factors = new List<int>();

            // Pull out factor 2
            while (number % 2 == 0)
            {
                factors.Add(2);
                number /= 2;
            }


            // Look for odd factors
            int i = 3;
            int maxFactor = (int) Math.Sqrt(number);
            while (i <= maxFactor)
            {
                while (number % i == 0)
                {
                    // i is factor then add to list
                    factors.Add(i);

                    // Divide number by i
                    number = number / i;
                    
                    // Set a new upper bound
                    maxFactor = (int)Math.Sqrt(number);
                }

                // Check the next upper bound
                i+=2;
            }

            // Any number Left
            if (number > i)
                factors.Add(number);

            return factors.ToArray();
        }

    }
}
