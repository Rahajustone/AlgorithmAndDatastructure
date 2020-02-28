using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDatastructure.NumericalAlgorithms
{
    class ExponentiationAlgorithms
    {
        // Quadratic Algorithms
        // O(1)
        public static int QuadraticPower(int n)
        {
            return n * n;
        }

        // Cube Algorithms
        // O(1)
        public static int CubePower(int n)
        {
            return n * n * n;
        }


        // Power with the base
        // O(log n)
        // A^2 * A^4 * A^8 * A^16 so on
        public static int RaiseToPower(int number, int power)
        {
            int result = 1;
            while (power >= 1)
            {
                if (power %2 == 1)
                {
                    result = result * number;
                }

                power /= 2;
                number *= number;
            }

            return result;
        }

        // Power with base
        // O(n)
        public static long Power(int n, int b)
        {
            long result = 1;
            for (int i = 0; i < b; i++)
                result = result * n;

            return result;
        }
    }
}
