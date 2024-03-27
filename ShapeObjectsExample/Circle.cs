using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeObjectsExample
{
    // Circle subclass
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            // Area of a circle: π * r^2
            return Math.PI * Radius * Radius;
        }
    }
}
