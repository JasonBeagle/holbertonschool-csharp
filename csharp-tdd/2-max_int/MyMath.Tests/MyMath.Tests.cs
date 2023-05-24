using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
            public void ReturnsMax()
            {
                List<int> TempList = new List<int> { 5, 10, 2, 8, 3 };

                Assert.AreEqual(10, MyMath.Operations.Max(TempList));
            }

        [Test]
            public void EmptyList()
            {
                // Arrange
                List<int> TempList = new List<int>();

                Assert.AreEqual(0, MyMath.Operations.Max(TempList));
            }
    }
}
