using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmAndDatastructure.LinkedListAlgorithms.LinkedListCustom
{
	public class CustomLinkedListGenerics<T> : IEnumerable<T>
	{
        private class CustomNode<T>
        {
            public CustomNode<T> next;
            public T value { get; set; }

            public CustomNode(T value)
            {
                this.value = value;
            }
        }
        public T Head => first.value;
        private CustomNode<T> first;
        private CustomNode<T> last;
        private int size { get; set; } = 0;


        public void AddLast(T item)
        {
            var node = new CustomNode<T>(item);
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

        public void AddFirst(T item)
        {
            var node = new CustomNode<T>(item);
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

        public int IndexOf(T item)
        {
            int index = 0;
            var current = first;
            while (current != null)
            {
                if (  current.value.Equals(item)) return index;
                current = current.next;
                index++;
            }

            return -1;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public void RemoveFirst()
        {
            if (first == null) throw new InvalidOperationException("List is empty");
            if (first == last)
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
                size = 0;
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

        public T[] ToArray()
        {
            T[] arr = new T[size];
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

            CustomNode<T> previous = null;
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

        public void PrintNodes()
        {
            var current = first;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }

        private CustomNode<T> GetPreviousNode(CustomNode<T> node)
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

        public IEnumerator<T> GetEnumerator()
        { 
            var current = first;
            while (current != null)
            {
                yield return current.value;
                current = current.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}