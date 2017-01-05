using System;

namespace AreaOfShapeCalculator
{
    class Triangle : ShapeProperties
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double angleC { get; set; }

        public override double Area { get; set; }

        public double GetArea()
        {
            Area = 0.5 * sideA * sideB * Math.Sin(angleC);
            return Area;
        }
    }
}
