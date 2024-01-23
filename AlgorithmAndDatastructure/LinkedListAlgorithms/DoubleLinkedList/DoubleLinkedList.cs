using System;
namespace AlgorithmAndDatastructure.LinkedListAlgorithms.DoubleLinkedList
{
	public class DoubleLinkedList
	{
		private class DoubleNode
		{
			public DoubleNode previous;
			public DoubleNode next;
			public int data;
			public DoubleNode(int data)
			{
				this.data = data;
			}
		}

		private DoubleNode head;
        private DoubleNode tail;
		public int Count = 0;

		public void AddFirst(int value)
		{
			AddFirst(new DoubleNode(value));
		}

		public void AddLast(int value)
		{
			if (head == null)
			{
				head = tail = new DoubleNode(value);
			} else
			{
				var temp = new DoubleNode(value);
				tail.next = temp;
				temp.previous = tail;
				tail = temp;
			}

			Count++;
		}

		public void RemoveFirst()
		{
			if (head == null) return;
			if (head == tail)
			{
				head = tail = null;
				return;
			}
			head = head.next;
			Count--;

			if (IsEmpty())
			{
				tail = null;
			} else
			{
				head.previous = null;
			}
		}

		public void RemoveLast()
		{
			if (IsEmpty()) throw new Exception("Empty Linked list");
			if (Count == 0)
			{
				head = tail = null;
			} else
			{
				tail.previous.next = null;
				tail = tail.previous;
			}

			Count--;
		}


		private void AddFirst(DoubleNode node)
		{
			var temp = head;
			head = node;
			head.next = temp;

			if (IsEmpty())
			{
				tail = head;
			}
			else
			{
				temp.previous = head;
			}

			Count++;
		}


		private bool IsEmpty() => Count == 0;

	}
}

