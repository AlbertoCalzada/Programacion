using System;

namespace Rectangle
{


    class Rectangle
    {
        Point tr;
        Point tl;
        Point br;
        Point bl;

        public Rectangle(Point tr, Point tl, Point br, Point bl)
        {

            this.tr = tr;
            this.tl = tl;
            this.br = br;
            this.bl = bl;



        }

        public Rectangle(Point tr, Point tl, Point br)
        {


            this.tr = tr;
            this.tl = tl;
            this.br = br;
            bl = new Point();


        }

        public float GetArea()
        {
            int rectbase = br.GetX() - bl.GetX();
            int rectHeight = tr.GetY() - br.GetY();

            return rectbase *rectHeight;


        }

        public string toString()
        {

            string result = "(" + x + "," + y + " )";
            return result;
        }



    }

    class Point
    {

        int x;
        int y;


        public Point()
        {

            x = 0;
            y = 0;

        }

        public Point(double x, double y)
        {

            this. x = x;
            this.y = y;

        }

        public void SetX(int newx)
        {

            x = newx;
        }

        public int GetX()
        {

            return x;
        }

        public void SetY(int newy)
        {

            y = newy;
        }

        public int GetY()
        {

            return y;
        }

    }











    internal class Program
    {
        static void Main(string[] args)
        {
            Point p00 = new Point(0, 0);
            Point p11 = new Point(1, 1);
            Point p13 = new Point(1, 3);
            Point p33 = new Point(3, 3);
            Point p31 = new Point(3, 1);

            Point p52= new Point(5, 2);
            Point p50 = new Point(5, 0);
            Point p02 = new Point(0, 2);

            Rectangle rect1 = new Rectangle(p33, p13, p31, p11);
            Rectangle rect2 = new Rectangle(p52, p02, p50);

            Console.WriteLine("Rectangulo 1 : " + rect1.toString());
            Console.WriteLine("Rectangulo 2 : " + rect2.toString());

            Console.WriteLine("fin");
        }

        // añadir metodo dibujar esto con asteriscos
    }
}
