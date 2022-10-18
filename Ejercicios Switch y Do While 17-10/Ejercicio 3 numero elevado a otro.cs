using System;

namespace Ejercicio3DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribeme dos numero, el primero sera elevado al segundo");
            double a = int.Parse(Console.ReadLine());
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine(PrimeroElevadoSegundo(a, b));
           

        }


        static double PrimeroElevadoSegundo(double num1, double num2)
        {
            int contador=1;
            double elevacion = num1;
            do
            {

                ;
                elevacion = elevacion * num1;
                contador++;
                
            } while (contador < num2);
            //double result = Math.Pow(num1, num2);




            return elevacion;


        }
    }
}
