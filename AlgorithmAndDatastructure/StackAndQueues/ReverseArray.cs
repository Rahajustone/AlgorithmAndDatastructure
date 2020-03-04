using System;
namespace AlgorithmAndDatastructure.StackAndQueues
{
    public class ReverseArray
    {
        public ReverseArray()
        {
        }

        // Reverse an array using Stack
        public static int[] Reverse(int[] arr)
        {
            LinkedListedStack stack = new LinkedListedStack();

            // Push to Stack
            for (int i = 0; i < arr.Length; i++)
                stack.Push(arr[i]);

            // Pop from Stack
            for (int i = 0; i < arr.Length; i++)
                arr[i] = stack.Pop();

            return arr;
        }
    }
}
