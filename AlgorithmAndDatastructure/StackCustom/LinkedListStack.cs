using System;
namespace AlgorithmAndDatastructure.StackCustom
{
	public class LinkedListStack
	{
		public LinkedListStack()
		{
		}

		class LinkedListNode
		{
			public LinkedListNode next;
			public int data;

			public LinkedListNode(int value)
			{
				this.data = value;
			}
        }

		LinkedListNode head =null;

		public void Push(int value)
		{
            var newNode = new LinkedListNode(value);

            if (head == null)
			{
				head = newNode;
				return;
			}

			newNode.next = head;
			head = newNode;
		}

		public int Pop()
		{
			if (head == null) throw new Exception("Stak is empty!");
			var res = head.data;
			head = head.next;

			return res;
		}

	}
}

