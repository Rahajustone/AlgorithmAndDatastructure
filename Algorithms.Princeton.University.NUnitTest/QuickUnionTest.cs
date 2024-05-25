using Algorithms.Princeton.Unuversity.Connectivity;

namespace Algorithms.Princeton.University.NUnitTest;

[TestFixture]
public class QuickUnionTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(1,2,true)]
    public void Test1(int p, int q, bool result)
    {
        var newConnectivity = new QuickUnion(10);
        newConnectivity.Union(p, q);
        Assert.That(newConnectivity.IsConnected(p, q), Is.EqualTo(result));
    }
}
