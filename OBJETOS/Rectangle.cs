using System;

namespace Rectangle
{


    class Rectangle
    {
        double vertex1;
        double vertex2;
        double vertex3;
        double vertex4;

        public Rectangle(double newvertex1, double newvertex2, double newvertex3, double newvertex4)
        {
            vertex1 = newvertex1;
            vertex2 = newvertex2;
            vertex3 = newvertex3;
            vertex4 = newvertex4;




        }

        public Rectangle(double newvertex1, double newvertex2, double newvertex3)
        {

            vertex1 = newvertex1;
            vertex2 = newvertex2;
            vertex3 = newvertex3;
            vertex4 = 0.0;


        }

        public void GetArea(double newvertex1, double newvertex2, double newvertex3)
        {
            vertex1 = newvertex1;
            vertex2 = newvertex2;
            vertex3 = newvertex3;
            double area = (newvertex1 + newvertex2) * newvertex3;

        }

        public void PrintData()
        {

            Console.WriteLine("Los datos son " + vertex1 + vertex2 + vertex3 + vertex4);

        }



    }

    class Point
    {

        double x;
        double y;


        public Point()
        {

            x = 0;
            y = 0;

        }

        public Point(double newx, double newy)
        {

            x = newx;
            y = newy;

        }

        public void SetX(double newx)
        {

            x = newx;
        }

        public double GetX()
        {

            return x;
        }

        public void SetY(double newy)
        {

            y = newy;
        }

        public double GetY()
        {

            return y;
        }

    }











    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
