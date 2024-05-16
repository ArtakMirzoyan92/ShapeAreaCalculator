using ShapeAreaCalculator.IServices;

namespace ShapeAreaCalculator.Calculations
{
    public class ShapeCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.Area();
        }
    }
}
