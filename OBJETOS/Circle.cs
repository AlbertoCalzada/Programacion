using System;

namespace Circle
{

    class Circle
    {

        int x;
        int y;
        double radio;
        const double PI = 3.141592;

        public Circle()
        {
            x = 0;
            y = 0;
            radio = 0;

        }

        public Circle(double newradio)
        {
            radio = newradio;
            x = 0;
            y = 0;

        }
        public Circle( int newx, int newy, double newradio)
        {
            radio = newradio;
            x = newx;
            y = newy;

        }



        public void SetArea()
        {
            
            double area = PI * radio * radio;

        }

        public double GetArea()
        {
            

            return PI * radio * radio;
        }

        public void SetLength()
        {
            double PI = 3.141592;
            double length = 2 * PI * radio;

        }

        public double GetLength()
        {
            double PI = 3.141592;
            return  2 * PI * radio;

        }

        public void PrintDate()
        {
            Console.WriteLine("Los datos son " + x + "x " + y + "y "+ radio + " radio ");

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing..");

            Circle C1;
            Circle C2;
            Circle C3;


            C1 = new Circle();
            C2 = new Circle(5);
            C3 = new Circle(5, 4, 3);

            C3.SetArea();
            C3.SetLength();
            
            C3.PrintDate();
            Console.WriteLine(C1.GetArea());
            Console.WriteLine(C2.GetArea());
            Console.WriteLine(C3.GetArea());
            Console.WriteLine(C1.GetLength());
            Console.WriteLine(C2.GetLength());
            Console.WriteLine(C3.GetLength());

        }
    }
}
