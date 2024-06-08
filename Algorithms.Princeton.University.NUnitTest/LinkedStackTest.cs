using System;
using Algorithms.Princeton.Unuversity.Connectivity;
using Algorithms.Princeton.Unuversity.Stack;

namespace Algorithms.Princeton.University.NUnitTest;

[TestFixture]
public class LinkedStackTest
{
    LinkedStack<int> integerLinkedList = new LinkedStack<int>();
    LinkedStack<char> assciCharLinkedList = new LinkedStack<char>();

    [SetUp]
    public void SetUp()
    {
        for (int i = 0; i < 50; i++)
        {
            integerLinkedList.Push(i);
        }

        for (int i = 65; i <= 122; i++)
        {
            assciCharLinkedList.Push((char)i);
        }


    }

    [Test]
    public void LinkedStack_IsEmpty_ReturnTrue()
    {
        Assert.That(integerLinkedList.Count>0, Is.True);
    }

    [Test]
    public void LinkedStack_IsEmpty_ReturnFalse()
    {
        Assert.That(integerLinkedList.Count<0, Is.False);
    }

    [Test]
    public void LinkedStack_Contain_ReturnTrue()
    {
        Assert.That(integerLinkedList.Count, Is.EqualTo(50));
    }

    [Test]
    [TestCase(49)]
    [TestCase(34)]
    [TestCase(3)]
    [TestCase(2)]
    public void LinkedStack_ContainNumber_ReturnTrue(int n)
    {
        int currentNumber = -1;
        int currentStackSize = integerLinkedList.Count;
        for (int i = 0; i < currentStackSize; i++)
        {
            currentNumber = integerLinkedList.Pop();
            if (currentNumber == n) break;
        }
        Assert.IsTrue(currentNumber == n);
    }

    [Test]
    [TestCase(49)]
    public void LinkedStack_PoPIsTrue_ReturnTrue(int n)
    {
        var res = integerLinkedList.Pop();
        Assert.That(res, Is.EqualTo(n));
    }

    [Test]
    [TestCase(5)]
    [TestCase(10)]
    [TestCase(20)]
    [TestCase(25)]
    public void LinkedStack_PoPIsTrue_ReturnCount(int popTimes)
    {
        var currentElement = integerLinkedList.Count;
        for (int i = 0; i < popTimes; i++)
        {
            integerLinkedList.Pop();
        }
        int expected = currentElement - popTimes;
        Assert.That(integerLinkedList.Count, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(1,1)]
    [TestCase(2,2)]
    [TestCase(3,3)]
    [TestCase(4,4)]
    public void LinkedStack_PushPopShoudBeSame_ReturnTrue(int push, int pop)
    {
        var newLinkedStack = new LinkedStack<int>();
        newLinkedStack.Push(push);

        Assert.That(push, Is.EqualTo(pop));
    }
}
