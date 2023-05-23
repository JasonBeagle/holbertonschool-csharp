using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int a = 3;
            int b = 4;

            Assert.AreEqual(7, Operations.Add(a, b));
            Assert.AreNotEqual(9, Operations.Add(a, b));
            Assert.AreEqual(a + b, Operations.Add(a, b));
        }
    }
}