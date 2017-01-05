using System;


namespace AreaOfShapeCalculator
{
    class Circle : ShapeProperties
    {

        public double radius { get; set; }
        public override double Area { get; set; }
        public double GetArea()
        {
            Area = Math.PI * (radius * radius);
            return Area;
        }
    }
}

