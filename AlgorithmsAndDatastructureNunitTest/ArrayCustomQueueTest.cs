using System;
using AlgorithmAndDatastructure.QueueCustom;
using NUnit.Framework;

namespace AlgorithmsAndDatastructureNunitTest
{
    [TestFixture]
	public class ArrayCustomQueueTest
	{
        [Test]
        public void Capacity_EnqueueItems_DoubleCapacity()
        {
            var queue = new ArrayCustomQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8); 
            Assert.That(queue.Capacity == 8, Is.True);
        }
    }
}
