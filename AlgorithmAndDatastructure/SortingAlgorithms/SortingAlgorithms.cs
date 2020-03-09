using System;
namespace AlgorithmAndDatastructure.SortingAlgorithms
{
    public class SortingAlgorithms
    {

        // Insertion Sort
        public void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j>=0 && arr[j] > key)
                {
                    arr[j+1] = arr[j];
                    j = j - 1;
                }

                arr[j + 1] = key;
            }
        }

        // Selection Sort
        public void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;

                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }

                if (min != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
        }

        // Bubble Sort
        public void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[j+1] )
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Bubble Sort with recursion
        public void BubbleSortRecursion(int[] arr, int length)
        {
            if (length == 1 )
            {
                return;
            }

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }

            BubbleSortRecursion(arr, length-1);
        }

        public void SelectionSorts(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;

                int j = i + 1;
                while (j < arr.Length)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                                        
                    j++;
                }

                if (i == minIndex)
                {
                    arr[minIndex] = arr[j];
                    arr[j] = arr[minIndex];
                }

            }
        }

    }
}
