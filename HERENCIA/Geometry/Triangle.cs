using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Geometry
{
    class Triangle: GeometricFigure
    {
        double theBase;
        double height;

        public Triangle(double theBase, double height)
        {
            this.theBase = theBase;
            this.height = height;
            SetArea((theBase * height) / 2);
            SetPerimeter(theBase + (2 * Math.Sqrt((Math.Pow(theBase, 2) + Math.Pow(height, 2)) / 2)));
        }

        public override void Print()
        {
            Console.WriteLine("El área y el perímetro del triángulo  son : " + GetArea() + " cm de área, y " + GetPerimeter() + " cm de perímetro.");
        }
    }
}
