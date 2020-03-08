using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using AlgorithmAndDatastructure.ArraysAlgorithms;
using AlgorithmAndDatastructure.LinkedListAlgorithms;
using AlgorithmAndDatastructure.NumericalAlgorithms;
using AlgorithmAndDatastructure.SearchingAlgorithms;
using AlgorithmAndDatastructure.SortingAlgorithms;
using AlgorithmAndDatastructure.StackAndQueues;

namespace AlgorithmAndDataStructure
{
    class Program
    {

        static void Main(string[] args)
        {
            var arr = new int[] { 21,21,21,21,21,211, 11, 8, 7, 21, 2, 3, 4, 5, 6, 7 };

            var obj = new SortingAlgorithms();
            obj.InsertionSortTest(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            //ReverseArray.Reverse(arr);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //var arr = new ArrayStack(21);
            //arr.Push(1);
            //arr.Push(2);
            //arr.Push(3);
            //arr.Push(4);
            //arr.Push(5);
            //arr.Push(7);
            ////arr.Print();

            ////Console.WriteLine(arr.Pop());

            //arr.Print();


            //// LinkedListedStack

            //var stack = new LinkedListedStack();
            //stack.Push(1);
            //stack.Pop();

            ////for (int i = 0; i < 10; i++)
            ////{
            ////    stack.Push(i);
            ////}

            //stack.PrintData();




            //// Insertion Sort Algorithms
            //var sortarray = new InsertionSortAlgorithms();
            //var arr = new int[]{ 11, 2, 31, 14, 15, 1, 2, 4};
            //sortarray.InsertionSort(arr);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}


            //var singleLinkedList = new SingleLinkedList();

            //singleLinkedList.Append(1);
            //singleLinkedList.Append(2);
            //singleLinkedList.Append(3);
            //singleLinkedList.Append(4);
            //singleLinkedList.Append(5);
            //singleLinkedList.Append(6);
            //singleLinkedList.Append(7);
            //singleLinkedList.Append(8);
            ////singleLinkedList.PrintLinkedList();

            //Console.WriteLine(singleLinkedList.GetHeadValue());

            //singleLinkedList.Clear();
            //singleLinkedList.PrintLinkedList();

            //Console.WriteLine(singleLinkedList.GetTheFirstNode());
            //Console.WriteLine(singleLinkedList.GetTheLastNode());

            //Console.WriteLine(singleLinkedList.GetCountNode());

            //Console.Read();
        }
    }
}
