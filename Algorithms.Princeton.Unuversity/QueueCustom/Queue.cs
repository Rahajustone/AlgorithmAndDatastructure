using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Princeton.Unuversity.QueueCustom
{
    public class Queue<T>
    {
        private Node<T> first, last;
        private class Node<T>
        {
            public T item;
            public Node<T> next;

            public Node(T item)
            {
                this.item = item;
            }
        }

        public void Enqueue(T item)
        {
            Node<T> Oldlast = last;
            last = new Node<T>(item);
            last.next = null;
            if (IsEmpty())
                first = last;
            else
                Oldlast.next = last;

        }
        public T Dequeue()
        {
            T item = first.item;
            first = first.next;

            if (IsEmpty()) last = null;

            return item;
        }

        bool IsEmpty()
        {
            return first == null;
        }

    }
}
