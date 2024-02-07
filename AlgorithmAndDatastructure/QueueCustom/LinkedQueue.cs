using System;
using System.Collections;
using System.Collections.Generic;
using AlgorithmAndDatastructure.LinkedListAlgorithms.LinkedListCustom;

namespace AlgorithmAndDatastructure.QueueCustom
{
	public class LinkedQueue<T> : IEnumerable<T>
	{
		private readonly CustomLinkedListGenerics<T> _list = new CustomLinkedListGenerics<T>();


        public LinkedQueue()
		{
		}

        public void Enqueue(T item)
        {
            _list.AddLast(item);
        }

        public void Dequeue()
        {
            _list.RemoveFirst();
        }

        public T Peek()
        {
            if (Count()==0) throw new InvalidCastException();

            return _list.Head;
        }

        public int Count()
        {
            return _list.GetSize();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}

