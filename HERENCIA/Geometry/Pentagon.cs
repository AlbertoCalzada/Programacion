using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class Pentagon:GeometricFigure
    {
        double side;
        double apothem;

        public Pentagon(double side, double apothem)
        {
            this.side = side;
            this.apothem = apothem;
            SetArea((5 * side * apothem) / 2);
            SetPerimeter(side * 5);
        }
        public override void Print()
        {
            Console.WriteLine("El área y el perímetro del pentágono  son : " + GetArea() + " cm de área, y " + GetPerimeter() + " cm de perímetro.");
        }
    }
}
