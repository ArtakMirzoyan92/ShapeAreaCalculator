using ShapeAreaCalculator.Constants;
using ShapeAreaCalculator.Shapes;

namespace ShapeAreaCalculator.Tests.ShapesTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleArea_Sides3and4and5_6Returned()
        {
            // Arrange

            double sideA = 3, sideB = 4, sideC = 5;
            double expected = 6;
            const double delta = 0.000001;
            // Act

            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double actual = triangle.Area();

            // Assert

            Assert.AreEqual(expected, actual, delta);
        }


        [TestMethod]
        public void IsRightTriangle_Sides3and4and5_ReturnsTrue()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool actual = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsRightTriangle_Sides2and4and5_ReturnsFalse()
        {
            // Arrange
            double sideA = 2;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool actual = triangle.IsRightTriangle();

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), TriangleConstants.NegativeSidesMessage)]
        public void Triangle_NegativeSides_ThrowsArgumentException()
        {
            // Arrange & Act
            Triangle triangle = new Triangle(-1, 4, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), TriangleConstants.InvalidSidesSumMessage)]
        public void Triangle_InvalidSides_ThrowsArgumentException()
        {
            // Arrange & Act
            Triangle triangle = new Triangle(1, 2, 10);
        }
    }
}
