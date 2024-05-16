using ShapeAreaCalculator.Calculations;
using ShapeAreaCalculator.Shapes;

namespace ShapeAreaCalculator.Tests.CalculationTests
{
    [TestClass]
    public class ShapeCalculatorTests
    {
        const double delta = 0.000001;

        [TestMethod]
        public void ShapeCalculator_AreaWithCircleRadius5_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            double expected = Math.PI * Math.Pow(radius, 2);


            Circle circle = new Circle(radius);
            ShapeCalculator calculator = new ShapeCalculator();

            // Act
            double actual = calculator.CalculateArea(circle);

            // Assert
            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void ShapeCalculator_AreaWithTriangleSides3and4and5_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double expected = 6;


            Triangle triangle = new Triangle(sideA, sideB, sideC);
            ShapeCalculator calculator = new ShapeCalculator();

            // Act
            double actual = calculator.CalculateArea(triangle);

            // Assert
            Assert.AreEqual(expected, actual, delta);
        }
    }
}
