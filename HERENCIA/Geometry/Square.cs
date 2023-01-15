using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class Square: GeometricFigure
    {
        double side;

        public Square(double side)
        {
            this.side = side;
            SetArea(side*side);
            SetPerimeter(side * 4);
        }
        public override void Print()
        {
            Console.WriteLine("El área y el perímetro del cuadrado  son : " + GetArea() + " cm de área, y " + GetPerimeter() + " cm de perímetro.");
        }
    }
}
