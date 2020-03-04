using System;
namespace AlgorithmAndDatastructure.StackAndQueues
{
    public class ArrayStack
    {
        private int _size { get; set; }
        private int[] _arr { get; set; }
        private int _top;
        private int _max;

        public ArrayStack(int size)
        {
            this._size = size;
            _arr = new int[size];
            _top = -1;
            _max = size;
        }

        public void Push(int data)
        {
            if (_top == _max-1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            _arr[++_top] = data;
        }

        public int Pop()
        {
            if(_top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }

            return _arr[_top--];
        }


        public void Print()
        {
            if(_top == -1)
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            for (int i = 0; i <= _top; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }

        public int Peek()
        {
            if(_top == -1)
            {
                Console.WriteLine("Stack is empty.");
                return -1;
            }

            return _arr[_top];
        }
    }
}
