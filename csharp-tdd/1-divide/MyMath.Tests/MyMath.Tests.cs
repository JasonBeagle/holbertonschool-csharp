using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
            public void WorkingFunction()
            {
                // Arrange
                int[,] matrix = new int[,]
                {
                    { 10, 20 },
                    { 30, 40 }
                };

                int[,] expected = new int[,]
                {
                    { 5, 10 },
                    { 15, 20 }
                };

                // Act
                int[,] result = Matrix.Divide(matrix, 2);

                // Assert
                Assert.AreEqual(expected, result);
            }

        [Test]
            public void DivideByZero()
            {
                // Arrange
                int[,] matrix = new int[,]
                {
                    { 10, 20 },
                    { 30, 40 }
                };
                // Act
                Assert.IsNull(MyMath.Matrix.Divide(matrix, 0));
                Assert.Pass();
            }

        [Test]
            public void ReturnsNull()
            {
                Assert.IsNull(MyMath.Matrix.Divide(null, 2));
                Assert.Pass();
            }
    }
}
