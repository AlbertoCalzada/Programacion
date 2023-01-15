using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
     class Hexagon:GeometricFigure
    {
        double side;
        double apothem;

        public Hexagon(double side, double apothem)
        {
            this.side = side;
            this.apothem = apothem;
            SetPerimeter(side * 6);
            SetArea((GetPerimeter() * apothem) / 2);
        }
        public override void Print()
        {
            Console.WriteLine("El área y el perímetro del hexágono  son : " + GetArea() + " cm de área, y " + GetPerimeter() + " cm de perímetro.");
        }
    }
}
