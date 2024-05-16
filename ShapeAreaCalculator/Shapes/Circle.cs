using ShapeAreaCalculator.Constants;
using ShapeAreaCalculator.IServices;

namespace ShapeAreaCalculator.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException(CircleConstants.NegativeRadiusMessage);

            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
