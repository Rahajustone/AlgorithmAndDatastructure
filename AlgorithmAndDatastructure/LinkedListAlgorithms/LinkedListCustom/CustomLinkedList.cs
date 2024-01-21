using System;
using System.Collections.Generic;
using System.Reflection;
using AlgorithmAndDatastructure.StackAndQueues;

namespace AlgorithmAndDatastructure.LinkedListAlgorithms.LinkedListCustom
{
	public class CustomLinkedList
	{
		private class CustomNode
		{
			public CustomNode next;
			public int value { get; set; }

			public CustomNode(int value)
			{
				this.value = value;
			}
		}

		private CustomNode first;
		private CustomNode last;
		private int size { get; set; } = 0;

		public CustomLinkedList()
		{
		}

		public void AddLast(int item)
		{
			var node = new CustomNode(item);
			if (IsEmpty())
			{
				first = last = node;
			}
			else
			{
				last.next = node;
				last = node;
			}

			size++;
        }

		public void AddFirst(int item)
		{
			var node = new CustomNode(item);
			if (IsEmpty())
			{
				first = last = node;
			}
			else
			{
				node.next = first;
				first = node;
			}
            size++;
        }

        public int IndexOf(int item)
		{
			int index = 0;
            var current = first;
            while (current != null)
            {
                if (current.value == item) return index;
				current = current.next;
				index++;
			}

			return -1;
		}

		public bool Contains(int item)
		{
			return IndexOf(item) != -1;
        }

		public void RemoveFirst()
		{
			if (first == null) throw new InvalidOperationException("List is empty");
			if (first==last)
			{
				first = last = null;
				size = 0;
				return;
			}

			var secondNode = first.next;
			first = null;
			first = secondNode;

            size--;
        }

        public void RemoveLast()
        {

            if (IsEmpty()) throw new InvalidOperationException("List is empty");
            if (first == last)
			{
				first = last = null;
				size=0;
				return;
			}

			var previous = GetPreviousNode(last);
			last = previous;
			last.next = null;

            size--;
        }

		public int GetSize()
		{
			return size;
		}

		public int[] ToArray()
		{
			int[] arr = new int[size];
			int index = 0;
			var current = first;
			while (current != null)
			{
				arr[index++] = current.value;
				current = current.next;
			}

			return arr;
		}

		public void Reverse()
		{
			if (IsEmpty()) return;
			if (first.next == null) return;

			CustomNode previous = null;
			var current = first;
			while (current != null)
			{
				var next = current.next;
				current.next = first;
				first = current;
				current = next;
			}

			first = previous;
		}


		public int GetKthFromTheEnd(int k)
		{
			var a = first;
			var b = first;
			for (int i = 0; i < k-1; i++)
			{
				b = b.next;
			}

			while(b != last)
			{
				a = a.next;
				b = b.next;
			}

			return a.value;
			//int i = 0;
			//var firstPointer = first;
			//int res = -1;

			//while (firstPointer != null && i <= size-k)
			//{
			//	if (i == size - k) return firstPointer.value;
			//	i++;
			//	firstPointer = firstPointer.next;
			//}

			//return res;

		}

        public void PrintNodes()
        {
            var current = first;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }

		public void PrintMiddle()
		{
			if (IsEmpty())
			{
				return;
			}
			if (first==last)
			{
				Console.WriteLine(first.value);
				return;
			}


			var slow = first;
			var fast = first.next;

			while (fast != last)
			{
				slow = slow.next;
				if (fast.next.next == null)
				{
					Console.WriteLine(slow.value);
					return;
				}
				fast = fast.next.next;
			}

			Console.WriteLine((slow.value+slow.next.value)/2);
		}

        private CustomNode GetPreviousNode(CustomNode node)
		{
            var current = first;
            while (current != null)
            {
                if (current.next == node) return current;
                current = current.next;
            }

			return null;
        }

		private bool IsEmpty()
		{
			return first == null;
		}
	}
}