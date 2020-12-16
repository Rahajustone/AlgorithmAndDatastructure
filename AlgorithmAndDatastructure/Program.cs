using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
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
        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            List<int> rankedList = new List<int>();
            var rankedRatio = new Dictionary<int, int>();

            int k = 1;
            for (int i = 0; i < ranked.Count; i++)
            {
                if (!rankedRatio.ContainsKey(ranked[i]))
                {
                    rankedRatio.Add(ranked[i], k);
                    k++;
                }
            }

            for (int i = 0; i < player.Count; i++)
            {
                for (int j = 0; j < rankedRatio.Count; j++)
                {
                    if (player[i] >= rankedRatio.ElementAt(j).Key)
                    {
                        rankedList.Add(rankedRatio.ElementAt(j).Value);
                    }
                    if (j == rankedRatio.Count - 1)
                    {
                        rankedList.Add(rankedRatio.ElementAt(j).Value + 1);
                    }
                }
            }

            return rankedList;
        }


        static void Main(string[] args)
        {

            var a = climbingLeaderboard(new List<int> { 100, 90, 90, 80, 75, 60 }, new List<int> { 50, 65, 77, 90, 102 });

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }

            //var queue = new LinkedListedQueue();
            //queue.Queue(1);
            //queue.Queue(2);
            //queue.Queue(3);
            //queue.Queue(4);

            //var b = queue.Dequeue();

            //Console.WriteLine(b);


            //var arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            //ReverseArray.Reverse(arr);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

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




            // Insertion Sort Algorithms
            //var sortarray = new InsertionSortAlgorithms();
            //var arr = new int[] { 11, 2, 31, 14, 15, 1, 2, 4 };
            //sortarray.SelectionSort(arr);

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
