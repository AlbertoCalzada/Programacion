using System;

namespace Circle
{
    
    class Circle
    {

        double x;
        double y;
        double radio;

         
        public Circle()
        {
            x = 0;
            y = 0;
            radio = 1;

        }

        public Circle(double newradio)
        {
            radio=newradio;
            x = 0;
            y = 0;

        }
        public Circle(double newradio, double newx, double newy)
        {
            radio= newradio;
            x = newx;
            y = newy;

        }

        

        public void SetArea()
        {
            double PI = 3.141592;
            double area = PI * radio * radio;

        }

        public void SetLength()
        {
            double PI = 3.141592;
            double length = 2 * PI * radio;

        }

        public void PrintDate()
        {
            Console.WriteLine("Los datos son");

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
            C3 = new Circle(5,4,3);

            C3.SetArea();
            C3.SetLength();
            Console.WriteLine("El area y la longitud de ");
            C3.PrintDate();
        }
    }
}
