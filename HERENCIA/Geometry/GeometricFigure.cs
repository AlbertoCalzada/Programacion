using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    class GeometricFigure
    {
        double area;
        double perimeter;

        public GeometricFigure()
        {
            area = 0;
            perimeter = 0;
        }

        protected void SetArea(double area)
        {
            this.area = area;
        }
        protected double GetArea()
        {
            return area;
        }
        protected void SetPerimeter(double perimeter)
        {
            this.perimeter = perimeter;
        }
        protected double GetPerimeter()
        {
            return perimeter;
        }

        public virtual void Print()
        {
            Console.WriteLine("El área y el perímetro de la figura geométrica son : " +area+ " cm de área, y "+ perimeter + " cm de perímetro.");
        }
    }

}
