using System;
using System.Collections;

namespace AlgorithmAndDatastructure.CustomArray
{
    class MyCollectionClass : CollectionBase
    {
        public void Add(Object obj)
        {
            InnerList.Add(obj);
        }

        public void Remove(Object obj)
        {
            InnerList.Remove(obj);
        }

        public new void Clear()
        {
            InnerList.Clear();
        }

        public new int Count()
        {
            return InnerList.Count;
        }
    }
}