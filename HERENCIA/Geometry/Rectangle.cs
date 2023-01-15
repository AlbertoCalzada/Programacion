using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class Rectangle: GeometricFigure
    {
        double theBase;
        double height;

        public Rectangle(double theBase, double height)
        {
            this.theBase = theBase;
            this.height = height;
            SetArea(theBase * height);
            SetPerimeter(2 * theBase + 2 * height);
        }
        public override void Print()
        {
            Console.WriteLine("El área y el perímetro del rectángulo  son : " + GetArea() + " cm de área, y " + GetPerimeter() + " cm de perímetro.");
        }
    }
}
