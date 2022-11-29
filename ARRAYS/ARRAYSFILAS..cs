
using System;

namespace ArraysFilas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el numero de filas");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el numero de columnas");
            int col = int.Parse(Console.ReadLine());
            NrowNcol(row, col);
        }

        static int NrowNcol(int row, int col)
        {

            int[,] array = new int[row, col];
            Random r = new Random();

            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    array[i, j] = r.Next(0, 1001);
                    Console.Write(array[i, j] + "\t");

                }
                Console.WriteLine();
            }

            int higher = array[0, 0];
            int lower = array[0, 0];


            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {

                    if (array[i, j] > higher)
                    {
                        higher = array[i, j];
                    }
                    if (array[i, j] < lower)
                    {
                        lower = array[i, j];
                    }


                }

            }
            Console.WriteLine("el mas grande es " + higher + " el mas pequeño es " + lower);
            return lower;
        }

    }
}
