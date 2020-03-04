using System;
namespace AlgorithmAndDatastructure.SortingAlgorithms
{
    public class InsertionSortAlgorithms
    {
        public InsertionSortAlgorithms()
        {
        }

        // TODO
        public void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while(j >= 0 && arr[j] < key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }

                //for (int j = i; j >0; j--)
                //{
                //    if(arr[j] < arr[j-1])
                //    {
                //        int temp = arr[j];
                //        arr[j] = arr[j-1];
                //        arr[j-1] = temp;
                //    }
                //}
            }
        }
    }
}
