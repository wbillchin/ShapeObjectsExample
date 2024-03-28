using System;

namespace ShapeObjectsExample
{
    
    class Program
    {
        static void ModifyCircleByValue(Circle circle)
        {
            circle.Radius = 10; // Modifying the Radius property of the passed circle object
        }

        static void ModifyRectangleByReference(ref Rectangle rectangle)
        {
            rectangle.Width = 8; // Modifying the Width property of the passed rectangle object
        }

        static void Main(string[] args)
        {
            // Creating instances of Circle and Rectangle
            List<Circle> circlesListA = new List<Circle>();
            circlesListA.Add(new Circle(9));
            circlesListA.Add(new Circle(5));
            circlesListA.Add(new Circle(12.3));

            Rectangle rectangleA = new Rectangle(7, 5);

            Console.WriteLine("Original Circle Radius: " + circlesListA[0].Radius);
            ModifyCircleByValue(circlesListA[0]); // Pass by value
            Console.WriteLine("Modified Circle Radius (Pass by Value): " + circlesListA[0].Radius);

            Console.WriteLine("\nOriginal Rectangle Width: " + rectangleA.Width);
            ModifyRectangleByReference(ref rectangleA); // Pass by reference
            Console.WriteLine("Modified Rectangle Width (Pass by Reference): " + rectangleA.Width);

            double sumOfAreas = 0.0;
            foreach ( Circle aCircle in circlesListA)
            {
                double anArea = aCircle.CalculateArea();
                Console.WriteLine("circle area is " + anArea);
                sumOfAreas += anArea;
                Console.WriteLine("Sum of area is now " + sumOfAreas);
            }

            double averageAreaOfCirclesinListA = sumOfAreas / circlesListA.Count;
            Console.WriteLine("Average area of the circles is " + averageAreaOfCirclesinListA);


            List<Shape> shapeList = new List<Shape>();

            shapeList.Add(rectangleA);
            shapeList.AddRange(circlesListA);

            double secondSumOfAreas = 0.0;
            foreach (Shape aShape in shapeList)
            {
                Type aType = aShape.GetType();
                Console.WriteLine("shape type is " + aType.Name);

                double anArea = aShape.CalculateArea();
                Console.WriteLine("shape area is " + anArea);
                secondSumOfAreas += anArea;
                Console.WriteLine("Sum of area is now " + secondSumOfAreas);
            }

            double averageAreaOfAllShapes = secondSumOfAreas / shapeList.Count;
            Console.WriteLine("Average area of all the shapes is " + averageAreaOfAllShapes);


        }
    }
}
