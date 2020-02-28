using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace AlgorithmAndDatastructure.ArraysAlgorithms
{
    public class ArraysAlgorithm
    {
        // Add value at the end of array
        // O(n)
        public int[] InsertItem(int[] arr, int value)
        {
            int[] newArr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
                newArr[i] = arr[i];

            newArr[arr.Length] = value;

            return newArr;
        }

        // Add value to specific index 
        // O(n)
        public int[] InsertItem(int[] arr, int value, int index)
        {
            int[] newArr = new int[arr.Length+1];

            // index through new array
            int i = 0;
            
            // index through old array
            int j = 0;

            while ( i < newArr.Length)
            {
                if (i == index)
                {
                    newArr[i] = value;
                    i++;
                }
                else
                {
                    newArr[i] = arr[j];
                    i++;
                    j++;
                }
            }

            return newArr;
        }

        // Removing Item from array with index k
        // O(n)
        public int[] RemoveItem(int[] arr, int index)
        {

            int[] newArr = new int[arr.Length - 1];
            // index through new array
            int i = 0;

            // index through old array
            int j = 0;

            while (j < arr.Length)
            {
                if (j == index)
                {
                    j++;
                }
                else
                {
                    newArr[i] = arr[j];
                    i++;
                    j++;
                }
            }

            return newArr;
        }

        // It is not working properly
        // To find any media of array we have to first sort then 
        // O(n^2)
        public int FindMedian(int[] arr)
        {
            int largerCount = 0;
            int smallerCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        smallerCount++;
                    }

                    if (arr[j] > arr[i])
                        largerCount++;
                }

                if (smallerCount == largerCount)
                    return arr[i];
            }

            return -1;
        }

    }
}
