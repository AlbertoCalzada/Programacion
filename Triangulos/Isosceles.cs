using System;
using System.Collections.Generic;
using System.Text;

namespace Triangulos
{
    class Isosceles: Triangle
    {
        public Isosceles(Point p1, Point p2):base(p1,  p2)
        {
            this.p1 = p1;
            this.p2 = p2;

        }
    }
}
