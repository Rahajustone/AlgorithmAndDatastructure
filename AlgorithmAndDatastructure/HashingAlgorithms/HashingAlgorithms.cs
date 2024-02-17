using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDatastructure.HashingAlgorithms
{
    class HashingAlgorithms
    {
        // The simple hash methods
        public int Hash(int x)
        {
            return x % 7;
        }

        public int GenerateHashCodeBaseOnString(string str)
        {
            int charSum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                charSum += str[i];
            }

            return charSum % 7;
        }
    }
}
