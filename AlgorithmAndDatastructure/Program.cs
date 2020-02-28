using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using AlgorithmAndDatastructure.ArraysAlgorithms;
using AlgorithmAndDatastructure.LinkedListAlgorithms;
using AlgorithmAndDatastructure.NumericalAlgorithms;
using AlgorithmAndDatastructure.SearchingAlgorithms;

namespace AlgorithmAndDataStructure
{
    class Program
    {

        static void Main(string[] args)
        {
            var singleLinkedList = new SingleLinkedList();
            
            singleLinkedList.Append(1);
            singleLinkedList.Append(2);
            singleLinkedList.Append(3);
            singleLinkedList.Append(4);
            singleLinkedList.Append(5);
            singleLinkedList.Append(6);
            singleLinkedList.Append(7);
            singleLinkedList.Append(8);
            //singleLinkedList.PrintLinkedList();

            //Console.WriteLine(singleLinkedList.GetHeadValue());

            //singleLinkedList.Clear();
            singleLinkedList.PrintLinkedList();

            Console.WriteLine(singleLinkedList.GetTheFirstNode());
            Console.WriteLine(singleLinkedList.GetTheLastNode());

            //Console.WriteLine(singleLinkedList.GetCountNode());




            Console.Read();
        }
    }
}
