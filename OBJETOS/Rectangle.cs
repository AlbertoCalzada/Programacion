using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clases3
{
    class Point
    {
        int X;
        int Y;

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(int newcoorX, int newcoorY)
        {
            X = newcoorX;
            Y = newcoorY;
        }

        public void SetX(int newX)
        {
            X = newX;
        }
        public void SetY(int newY)
        {
            Y = newY;
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }

        public string toString()
        {
            string result = ("" + X + ", " + Y + "");
            return result;
        }
    }

    class Rectangle
    {
        Point pointone;
        Point pointtwo;
        Point pointthree;
        Point pointfour;

        public Rectangle(Point pointone, Point pointtwo, Point pointthree, Point pointfour)
        {
            this.pointone = pointone;
            this.pointtwo = pointtwo;
            this.pointthree = pointthree;
            this.pointfour = pointfour;
        }
        public Rectangle(Point pointone, Point pointtwo, Point pointthree)
        {
            this.pointone = pointone;
            this.pointtwo = pointtwo;
            this.pointthree = pointthree;
            this.pointfour = new Point();
        }
        public double PerimeterCalc(double largeside, double shortside)
        {
            double result = largeside * 2 + shortside * 2;
            return result;
        }

        public int Area()
        {
            int rectBase = pointthree.GetX() - pointfour.GetX();
            int rectHeight = pointone.GetX() - pointthree.GetX();
            int result = rectBase * rectHeight;
            return result;

        }

        public string toString()
        {
            string pointTL = ("" + pointone.GetX() + ", " + pointone.GetY() + "" + pointtwo.GetX() + ", " + pointtwo.GetY() +
                "" + pointthree.GetX() + ", " + pointthree.GetY() + "" + pointfour.GetX() + ", " + pointfour.GetY());
            return pointTL;
        }

        public void ViewDates()
        {
            Console.WriteLine("El primer punto es: " + pointone);
            Console.WriteLine("El segundo punto es: " + pointtwo);
            Console.WriteLine("El tercer punto es: " + pointthree);
            Console.WriteLine("El cuarto punto es: " + pointfour);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p00 = new Point();
            Point p11 = new Point(1, 1);
            Point p13 = new Point(1, 3);
            Point p33 = new Point(3, 3);
            Point p31 = new Point(3, 1);

            Point p52 = new Point(5, 2);
            Point p50 = new Point(5, 0);
            Point p02 = new Point(0, 2);

            Rectangle rect1 = new Rectangle(p33, p13, p31, p11);
            Rectangle rect2 = new Rectangle(p02, p52, p50);

            Console.WriteLine("Rectangulo 1:\n " + rect1.toString());
            Console.WriteLine("Rectangulo 2:\n " + rect2.toString());
        }
    }
}
