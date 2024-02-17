using System;
using Collection = System.Collections;
using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Diagnostics;
//using System.Linq;
//using System.Reflection;
using CustomHashTable = AlgorithmAndDatastructure.HashingAlgorithms;
//using AlgorithmAndDatastructure.LinkedListAlgorithms.LinkedListCustom;
//using AlgorithmAndDatastructure.StackCustom;
//using AlgorithmAndDatastructure.Dictionary;

namespace AlgorithmAndDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            var customHashTable = new CustomHashTable.HashTable();
            customHashTable.Put(1, "one");
            customHashTable.Put(2, "two");
            customHashTable.Put(3, "Three");
            customHashTable.Put(new int[6], "Array");

            Console.WriteLine(customHashTable.Get(1));
            Console.WriteLine(customHashTable.Get(2));
            Console.WriteLine(customHashTable.Get(3));
            Console.WriteLine(customHashTable.Get(new int[6]));

        }
    }
}
