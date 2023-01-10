using System;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(0,4);
            Point p2 = new Point(2,1);
            Point p3 = new Point(4,7);
            Triangle t1 = new Triangle(p1,p2,p3);
            t1.Draw(p1);
            t1.Draw(p2);
            t1.Draw(p3);
        }
    }
}
