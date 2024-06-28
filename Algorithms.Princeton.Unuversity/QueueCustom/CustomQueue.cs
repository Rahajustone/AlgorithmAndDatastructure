using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Princeton.Unuversity.QueueCustom
{
    public class CustomQueue
    {
        private Node head;
        private Node tail;
        public int Count = 0;

        private class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }
            public Node(int data)
            {
                Data = data;
                Next = null;
            }

        
        }
        public CustomQueue()
        {
            
        }

        public void Enqueue(int data)
        {
            if (head == null) {
                head = tail = new Node(data);
            } else {
                var newNodeToTail = new Node(data);
                tail.Next = newNodeToTail;
                tail = newNodeToTail;
            }
        }

        public int Dequeue()
        {
            var result = head.Data;
            head = head.Next;

            if (head == null)
            {
                head = null;
                tail = null;
            }

            return result;
        }

        public bool IsEmpty() => head == null ;

        public void PrintQueue() {
            var temp = head;
            while (temp != null) {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
    }
}
