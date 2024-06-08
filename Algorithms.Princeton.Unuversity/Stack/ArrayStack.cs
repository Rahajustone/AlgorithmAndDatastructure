using System;
namespace Algorithms.Princeton.Unuversity.Stack
{
	public class ArrayStack
	{
		private int[] integers;
		private int Count = 0;

		public ArrayStack(int N)
		{
			integers = new int[N];
        }

        // Overflow: use resizing array for array implementation.
        public void Push(int item)
		{
			// Take care of Overflow
			if (integers.Length >= Count)
            {
                Resize(Count*2);
            }

            integers[Count++] = item;
        }

        private void Resize(int capacity)
        {
            int[] newIntegers = new int[capacity];
            for (int i = 0; i < Count; i++)
            {
                newIntegers[i] = integers[i];
            }

            integers = newIntegers;
        }

        // Underflow: throw exception if pop from an empty stack
        public int Pop() {
            if (IsEmpty()) throw new ArgumentNullException();

			var item = integers[--Count];
			integers[Count] = 0;

            if (Count > 0 && Count == integers.Length / 4) Resize(integers.Length / 2);

            return item;
		}

        public bool IsEmpty() => Count == 0;

        public int GetCount() => Count;
	}
}
