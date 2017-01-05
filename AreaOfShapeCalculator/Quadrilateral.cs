

namespace AreaOfShapeCalculator
{
    class Quadrilateral : ShapeProperties
    {
        public double topAndBottom { get; set; }

        public double sides { get; set; }

        public override double Area { get; set; }

        public double GetArea() 
        {
          Area = topAndBottom * sides;
            return Area;
        }
    }
}
