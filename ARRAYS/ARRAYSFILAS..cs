
using System;

namespace ArraysFilas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el numero de filas");
            int row = int.Parse(Console.ReadLine());
            //Console.WriteLine("Introduce el numero de columnas");
            //int col = int.Parse(Console.ReadLine());
            //NrowNcol(row, col);
            Exercise2(row);
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
        static void Exercise2(int row)
        {
            int col = row;
            int[,] array = new int[row,col];
            Random r = new Random();

            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    array[i, j] = r.Next(0, 101);
                    Console.Write(array[i, j] + "\t");

                }
                Console.WriteLine();
            }
            // diagonal
            int total = 0;
            for (int i = 0; i < row; ++i)
            {
                
                for (int j = 0; j < col; ++j)
                {
                    if (i == j)
                    {
                        total = total + array[i, j];
                    }
                    
                }
                
            }
            double result = total / row;
            Console.WriteLine("La diagonal suma " + result);
        }

        static void Exercise3(int [,]array, int [,]array2)
        {
            array = new int[4, 4];
            array2 = new int[4, 4];
        }



    }
}
