using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmAndDatastructure.QueueCustom
{
	public class ArrayCustomQueue<T> : IEnumerable<T>
	{
        private T[] _queue;
        private int _head;
        private int _tail;
        public int Count => _tail - _head;
        public bool IsEmpty => Count == 0;

        public int Capacity => _queue.Length;

        public ArrayCustomQueue()
		{
            const int defaultCapacity = 4;
            _queue = new T[defaultCapacity];
		}

        public ArrayCustomQueue(int capacity)
        {
            _queue = new T[capacity];
        }

        public void Enqueue(T item)
        {
            if (_queue.Length == _tail)
            {
                T[] newQueue = new T[Count * 2];
                Array.Copy(_queue, newQueue, Count);
                _queue = newQueue;
            }

            _queue[_tail++] = item;
        }

        public void Dequeue()
        {
            if (IsEmpty) throw new Exception("Queue is Empty");

            _queue[_head++] = default(T);
            if (IsEmpty)
            {
                _head = _tail = 0;
            }
        }

        public T Peek()
        {
            if (IsEmpty) throw new Exception("Queue is Empty");

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

