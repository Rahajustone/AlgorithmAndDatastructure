using System;
namespace AlgorithmAndDatastructure.StackCustom
{
	public class CustomArrayStack
	{

		private int[] arr;
		private int count;

		public CustomArrayStack(int size)
		{
			arr = new int[size];
		}

		public void Push(int a)
		{
			if (count == arr.Length)
				throw new StackOverflowException();
			arr[count++] = a;
		}

		public int Pop()
		{
			if (count == 0)
				throw new IndexOutOfRangeException();

			return arr[--count];
		}

		public int Peek()
		{
			return arr[count-1];
		}

		public bool IsEmpty()
		{
			return count > 0;
		}

		public void PrintArr()
		{
			Console.WriteLine("here");
			for (int i = 0; i < count; i++)
			{
				Console.WriteLine(arr[i]);
			}
		}

	}
}

