using System;
namespace AlgorithmAndDatastructure.SortingAlgorithms
{
    public class InsertionSortAlgorithms
    {
        public InsertionSortAlgorithms()
        {
        }

        // Insertion Sort
        public void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                int index = arr[i];
                int j = i-1;

                while (j>=0 && arr[j] > index)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = index;
            }
        }


        // SelectionSort
        public void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;

                int j = i+1;

                while (j< arr.Length)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                    j++;
                }

                if (i != minIndex )
                {
                    int temp = arr[minIndex];
                    arr[minIndex] = arr[i];
                    arr[i] = temp; ;
                }

            }

        }
    }
}
