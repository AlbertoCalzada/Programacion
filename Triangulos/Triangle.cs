using System;
using System.Collections.Generic;
using System.Text;

namespace Triangulos
{
    class Triangle
    {
        Point p1;
        Point p2;
        Point p3;

        public Triangle(Point p1, Point p2, Point p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }
        public void Draw(Point p1)
        {
            for(int i=0; i < 10; ++i) //Fila
            {
                Console.Write(" ");

                for(int j = 0; j < 10; ++j) //Columna
                {

                    if (i == p1.GetX() && j == p1.GetY())
                    {
                        Console.Write(" * ");
                    }
                    Console.Write(" ");
                }
            }
        }
        public Point GetP1()
        {
            return p1;
        }

        public void SetP1(Point value)
        {
            p1 = value;
        }
        public Point GetP2()
        {
            return p2;
        }

        public void SetP2(Point value)
        {
            p2 = value;
        }
        public Point GetP3()
        {
            return p3;
        }

        public void SetP3(Point value)
        {
            p3 = value;
        }


    }
}
