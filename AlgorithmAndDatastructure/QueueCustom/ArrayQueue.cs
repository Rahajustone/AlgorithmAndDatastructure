using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmAndDatastructure.QueueCustom
{
	public class ArrayQueue<T> : IEnumerable<T>
	{
        private T[] _queue;
        private int _head;
        private int _tail;

        public int Count => _tail - _head;
        public bool IsEmpty => Count == 0;

        public ArrayQueue()
		{
            const int defaultSize = 4;
            _queue = new T[defaultSize];
		}

        public ArrayQueue(int capacity)
        {
            _queue = new T[capacity];
        }

        public void Enqueque(T item)
        {
            if (_queue.Length ==_tail)
            {
                T[] largerqueque = new T[Count * 2];
                Array.Copy(_queue, largerqueque, Count);
                _queue = largerqueque;
            }

            _queue[_tail++] = item;
        }

        public void Dequeque()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            _queue[_head++] = default(T);
            if (IsEmpty)
            {
                _head = _tail = 0;
            }
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }


            return _queue[_head];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = _head; i < _tail; i++)
            {
                yield return _queue[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();        
        }
    }
}

