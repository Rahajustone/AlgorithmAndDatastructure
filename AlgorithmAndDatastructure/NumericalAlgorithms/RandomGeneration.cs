using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmAndDatastructure.NumericalAlgorithms
{
    class RandomGeneration
    {
        // Generate from millisecond data time
        public static int BasicIntegerNumber()
        {
            return DateTime.Now.Millisecond;
        }


        // Randomizing an Array 
        public static int[] RandomizingArray(ref int[] arr)
        {
            var randMath= new Random();

            int getUpperBound = arr.Length;

            for (int i = 0; i < getUpperBound; i++)
            {
                int rand = randMath.Next(0, getUpperBound);

                // Swap the Element
                int temp = arr[0];
                arr[0] = arr[rand];
                arr[rand] = temp;
            }

            return arr;
        }
    }
}
