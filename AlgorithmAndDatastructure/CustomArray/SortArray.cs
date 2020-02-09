using AlgorithmAndDatastructure.CustomArray;

namespace AlgorithmAndDataStructure
{
    class SortArray : CustomArray
    {
        public SortArray(int size) : base(size)
        {
        }

        // Bubble Sort
        // Max to the End
        public void BubbleSort()
        {
            for (int i = Upper; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Arr[j]> Arr[j+1])
                        MySwapClass.Swap(ref Arr[j], ref Arr[j+1]);
                }
            }
        }

        // BubbleSort Reverse Version
        // 9,8,7,6,5,4,3,2,1
        public void BubbleSortReverse()
        {
            for (int i = Upper; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (Arr[j] < Arr[j + 1])
                        MySwapClass.Swap(ref Arr[j], ref Arr[j + 1]);
                }
            }
        }

        // Selection Sort
        // Select min or max to the left| right place
        public void SelectionSort()
        {
            for (int i = 0; i < Upper; i++)
            {
                int min = i;
                for (int j = i+1; j <= Upper; j++)
                {
                    if (Arr[j] < Arr[min])
                        min = j;
                }

                MySwapClass.Swap(ref Arr[i], ref Arr[min]);
            }
        }

        public void SelectionSortReverse()
        {
            for (int i = 0; i < Upper; i++)
            {
                int max = i;
                for (int j = i + 1; j <= Upper; j++)
                {
                    if (Arr[j] > Arr[max])
                        max = j;
                }

                MySwapClass.Swap(ref Arr[i], ref Arr[max]);
            }
        }

        // Insertion Sort
        // Select the min replace to the left
        public void InsertionSort()
        {
            for (int i = 1; i <= Upper; i++)
            {
                int sorted = Arr[i];
                int j = i-1;

                // SubArray
                while (j >= 0 && Arr[j] > sorted)
                {
                    Arr[j + 1] = Arr[j];
                    j--;
                }

                Arr[j + 1] = sorted;
            }
        }
    }
}