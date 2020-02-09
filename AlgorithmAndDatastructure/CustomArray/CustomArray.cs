using System;

namespace AlgorithmAndDatastructure.CustomArray
{
    public class CustomArray
    {
        protected int[] Arr;
        protected readonly int Upper;
        protected int NumberElements;

        public CustomArray(int size)
        {
            Arr = new int[size];
            Upper = size - 1;
            NumberElements = 0;
        }

        public void Insert(int element)
        {
            Arr[NumberElements] = element;
            NumberElements++;
        }


        public void InsertRange(params int[] elements)
        {
            foreach (var element in elements)
            {
                Insert(element);
            }
        }

        public void Display()
        {
            string temp = "";
            for (int i = 0; i <= Upper; i++)
                temp += Arr[i] + " ";
            Console.WriteLine($"[{temp}]");
        }

        public void Clear()
        {
            for (int i = 0; i <= Upper; i++)
                Arr[i] = 0;
            NumberElements = 0;
        }
    }
}