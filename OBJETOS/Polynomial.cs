using System;

namespace Polinomio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polynomial P1 = new Polynomial();
            Polynomial P2 = new Polynomial(2, 3);
            Polynomial P3 = new Polynomial(4);


            P1.PrintData();
            Console.WriteLine(P1.GetValue(3));
            P2.PrintData();
            Console.WriteLine(P2.GetValue(4));
            P3.PrintData();
            Console.WriteLine(P2.GetValue(7));
        }
    }


    class Polynomial
    {

        int coefficient1;
        int coefficient2;
        int coefficient3;

        public Polynomial()
        {
            coefficient1 = 0;
            coefficient2 = 0;
            coefficient3 = 0;

        }
        public Polynomial(int coefficient1, int coefficient3)
        {
            this.coefficient1 = coefficient1;
            coefficient2 = 1;
            this.coefficient3 = coefficient3;

        }
        public Polynomial(int coefficient1)
        {
            this.coefficient1 = coefficient1;

        }

        public double GetValue(double xvalue)
        {
            
            
            double result = Math.Pow(coefficient1 * xvalue, 2) + coefficient2 * xvalue + coefficient3;



            return result;
        }

        public void PrintData()
        {

            Console.WriteLine("El resultado de la operación  " + coefficient1 + "x^2 +" + coefficient2 + "x +" + coefficient3 + " es igual a ");
        }


        public string Write()
        {


            return "El resultado de la operación  " + coefficient1 + "x^2 +" + coefficient2 + "x +" + coefficient3 + " es igual a ";
        }
    }


}
