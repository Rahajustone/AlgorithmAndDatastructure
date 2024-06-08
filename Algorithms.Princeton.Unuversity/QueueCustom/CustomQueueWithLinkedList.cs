using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Princeton.Unuversity.QueueCustom
{
    public class CustomQueueWithLinkedList<T>
    {
        private Node<T> _head = null;
        private Node<T> _tail = null;
        public int Count = 0;
        public class Node<T>
        {
            public T Value;
            public Node<T> next;
            public Node(T value) { Value = value; }
        }

        public void Enqueue(T item)
        {
            if(_head == null) 
                _head = _tail = new Node<T>(item);
            else
            {
                var previousLastNode = _tail;
                _tail = new Node<T>(item);
                _tail.next = null;
                previousLastNode.next = _tail;
            }

            Count++;
        }

        public T Dequeue() {
            if (_head == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                var currentHead = _head;
                _head = _head.next;
                Count--;
                return currentHead.Value;
            }
        }

        public bool IsEmpty()
        {
            return _head == null;
        }

        public void PrintQueue() {
            var current = _head;
            while (current != null) {

                Console.WriteLine($"loop: {current.Value} Count: {Count}");
                current = current.next;
            }
            Console.WriteLine($"Count: {Count}");
        }
    }
}
