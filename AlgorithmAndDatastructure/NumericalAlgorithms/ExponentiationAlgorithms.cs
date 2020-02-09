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
