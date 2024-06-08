using Algorithms.Princeton.Unuversity.QueueCustom;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Princeton.Unuversity
{
    [TestFixture]
    public class CustomQueueWithLinkedListTest
    {
        [Test]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void CreateQueueList_Enqueue_ReturnTrue(int num) {
            var queue = new CustomQueueWithLinkedList<int>();

            queue.Enqueue(num);
            var item = queue.Dequeue();

            Assert.That(item, Is.EqualTo(num));
        }

        [Test]
        [TestCase(1, 1, true)]
        [TestCase(2, 2, true)]
        [TestCase(3, 14, false)]
        [TestCase(4, 6, false)]
        public void CreateQueueList_Dequeue_ReturnTrue(int num, int target, bool expected)
        {
            var queue = new CustomQueueWithLinkedList<int>();

            queue.Enqueue(num);
            var item = queue.Dequeue();

            Assert.That(item == target, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("test", true, true)]
        [TestCase("test", true, true)]
        [TestCase("test", false, false)]
        [TestCase("test", false, false)]
        public void DoubleCheck_IsEmpty_RetrunCondition(string str, bool expected, bool dequeue)
        {
            var queue = new CustomQueueWithLinkedList<string>();

            queue.Enqueue(str);
            if (dequeue)
                queue.Dequeue();

            Assert.That(queue.IsEmpty(), Is.EqualTo(expected));
        }
    }
}
