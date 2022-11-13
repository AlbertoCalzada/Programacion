using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio4();
        }

        static void Ejercicio1()
        {
            //crear array
            Console.WriteLine("Introduce 10 numeros ");
            int[] tennums = new int[10];
            for (int i = 0; i < tennums.Length; ++i)
            {

                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce otro numero ");
                tennums[i] = num1;

            }
            // mostrar al reves el array
            for (int i = tennums.Length - 1; i >= 0; --i)
            {

                Console.WriteLine("este seria el array al reves " + tennums[i]);
            }
        }

        static void Ejercicio2()
        {
            Random r = new Random();
            int[] array = new int[15];
            //creación del array
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = r.Next(0, 50);
                Console.WriteLine(array[i]);
            }

            //sacar valor mas alto y el mas bajo
            int higher = array[0];
            int lower = array[1];

            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] > higher)
                {
                    higher = array[i];

                }
                if (array[i] < lower)
                {
                    lower = array[i];
                }
            }
            Console.WriteLine("el mayor es " + higher + " y el menor es " + lower);

        }

        static void Ejercicio3()
        {
            int[] array = new int[20];
            Random r = new Random();
            // creacion del array
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = r.Next(0, 50);
                Console.WriteLine("array 1: " + array[i]);
            }
            //rotar
            for (int i = 0; i < array.Length - 1; ++i)
            {
                array[i] = array[i + 1];
                Console.WriteLine("array 2 " + array[i]);
            }

        }

        static void Ejercicio4()
        {
            double[] array1 = new double[20];
            double[] array2 = new double[20];
            double[] array3 = new double[20];
            Random r = new Random();
            //rellenando el primero
            for (int i = 0; i < array1.Length; ++i)
            {
                array1[i] = r.Next(0, 101);
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine();
            //elevando al cuadrado el segundo
            for(int i= 0; i < array2.Length; ++i)
            {
                array2[i] = Math.Pow(array1[i], 2);
                Console.WriteLine("el array2 es " + array2[i]);
                
            }
            Console.WriteLine();
            //elevando al cubo el tercero
            for (int i = 0; i < array3.Length; ++i)
            {
                /*array3[i] = array1[i] * array1[i] * array1[i]*/;
                array3[i] = Math.Pow(array1[i], 3);
                Console.WriteLine("el array3 es " + array3[i]);
                

            }

        }
    }
}
