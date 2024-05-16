using ShapeAreaCalculator.Constants;
using ShapeAreaCalculator.Shapes;

namespace ShapeAreaCalculator.Tests.ShapesTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void CircleArea_RadiusWith5_ReturnsCorrectArea()
        {
            // Arrange

            double radius = 5;
            double expected = Math.PI * Math.Pow(radius, 2);
            const double delta = 0.000001;
            // Act

            Circle circle = new Circle(radius);
            double actual = circle.Area();

            // Assert

            Assert.AreEqual(expected, actual, delta);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), CircleConstants.NegativeRadiusMessage)]
        public void Circle_NegativeRadius_ThrowsArgumentException()
        {
            // Arrange & Act
            Circle circle = new Circle(-1);
        }
    }
}