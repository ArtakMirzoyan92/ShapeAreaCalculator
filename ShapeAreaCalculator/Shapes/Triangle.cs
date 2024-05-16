using ShapeAreaCalculator.Constants;
using ShapeAreaCalculator.IServices;

namespace ShapeAreaCalculator.Shapes
{
    public class Triangle :IShape
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        private const double Tolerance = 0.000001;

        public Triangle(double sideA, double sideB, double sideC)
        {
            ValidateSides(sideA, sideB, sideC);

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
       
        void ValidateSides(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException(TriangleConstants.NegativeSidesMessage);

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                throw new ArgumentException(TriangleConstants.InvalidSidesSumMessage);
        }

        public double Area()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        public bool IsRightTriangle()
        {
            double[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);
            return Math.Abs((Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)) - Math.Pow(sides[2], 2)) < Tolerance;
        }
    }
}
