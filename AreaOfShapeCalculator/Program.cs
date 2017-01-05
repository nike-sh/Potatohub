using System;

namespace AreaOfShapeCalculator
{
    class Program : Quadrilateral
    {
        static void Main()
        {
            Console.WriteLine("To work out the area please choose a shape: q for quadrelateral, t for triangle & c for circle");
            var shapeOptions = Console.ReadLine();
            if (shapeOptions == "q")
            {
                calculateQuadrilateral();
            }  
            else if(shapeOptions == "t")
            {
                calculateTriangle();
            }         
            else if(shapeOptions == "c")
            {
                calculateCircle();
            }


        }

        public static void calculateQuadrilateral()
        {
            Quadrilateral square = new Quadrilateral();

            Console.WriteLine("Whats the Length of top & bottom:");
            square.sides = double.Parse(Console.ReadLine());

            Console.WriteLine("Whats the Length Of sides:");
            square.topAndBottom = double.Parse(Console.ReadLine());

            square.GetArea();

            Console.WriteLine(" The area is " + square.Area);
            Console.ReadLine();
        }
        public static void calculateTriangle()
        {
            Triangle triangle = new Triangle();

            Console.WriteLine("Whats the length of side A:");
            triangle.sideA = double.Parse(Console.ReadLine());

            Console.WriteLine("Whats the length of side B:");
            triangle.sideB = double.Parse(Console.ReadLine());

            Console.WriteLine("Whats the degree of angle C:");
            triangle.angleC = double.Parse(Console.ReadLine());

            triangle.GetArea();

            Console.WriteLine(" The area is " + triangle.Area);
            Console.ReadLine();
        }

        public static void calculateCircle()
        {
            Circle circle = new Circle();

            Console.WriteLine("Whats the length of the radius: ");
            circle.radius = double.Parse(Console.ReadLine());

            circle.GetArea();

            Console.WriteLine(" The area is " + circle.Area);
            Console.ReadLine();

        }
    }
}
