using System;
using Algorithms.Princeton.Unuversity.Connectivity;

namespace Algorithms.Princeton.University.NUnitTest;

[TestFixture]
public class QuickFindUFTest
{
    [Test]
    [TestCase(1,2, false)]
    [TestCase(2,3, false)]
    [TestCase(3,4, false)]
    [TestCase(9,4, false)]
    [TestCase(3,8, false)]
    public void CreatedQuickFind_IsConnected_ReturnFalse(int p, int q, bool result)
    {
        var newInstance = new QuickFindUF(10);

        var  iSConnectedFalse = newInstance.IsConnected(p, q);

        Assert.That(iSConnectedFalse, Is.EqualTo(result));
    }

    [Test]
    [TestCase(1, 12)]
    [TestCase(21, 12)]
    [TestCase(31, 12)]
    [TestCase(1, 41)]
    public void CreatedQuickFind_IsConnected_ThrowAnExceptionOutOfRange(int p, int q)
    {
        var newInstance = new QuickFindUF(10);
        Assert.Throws<IndexOutOfRangeException>( () => newInstance.IsConnected(p,q));
    }

    [Test]
    [TestCase(1,2, true)]
    [TestCase(2,2, true)]
    [TestCase(3,4, true)]
    [TestCase(5,1, true)]
    [TestCase(6,2, true)]
    [TestCase(7,4, true)]
    [TestCase(9,4, true)]
    [TestCase(2,1, true)]
    public void CreatedQuickFind_Union_ReturnTrue(int p, int q, bool result)
    {
        var newConnectivity = new QuickFindUF(10);
        newConnectivity.Union(p, q);
        Assert.That(newConnectivity.IsConnected(p, q), Is.EqualTo(result));
    }

    [Test]
    [TestCase(1, 2, false)]
    [TestCase(2, 3, false)]
    [TestCase(3, 4, false)]
    [TestCase(5, 1, false)]
    [TestCase(4, 5, false)]
    [TestCase(7, 4, false)]
    [TestCase(9, 4, false)]
    [TestCase(2, 1, false)]
    public void CreatedQuickFind_Union_ReturnFalse(int p, int q, bool result)
    {
        var newConnectivity = new QuickFindUF(10);
        newConnectivity.Union(p, q);
        Assert.That(newConnectivity.IsConnected(p, q), Is.EqualTo(!result));
    }
}

