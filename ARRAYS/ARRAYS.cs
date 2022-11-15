using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            insidearray(5);
        }

        
        static void insidearray(int n)
        {
            int[] inside = new int[n];
            Random r = new Random();
            for (int i = 0; i < inside.Length; ++i)
            {
                inside[i] = r.Next(0, 101);
                Console.WriteLine(inside[i]);
            }
            Console.WriteLine("Introduceme un numero para saber si esta dentro del array");
            int inserted = int.Parse(Console.ReadLine());
            for (int i = 0; i < inside.Length; ++i)
            {
                for (int j = 1; inserted != inside[]; ++j)
                {
                    if (inserted == inside[i])
                    {

                        Console.WriteLine("El número esta dentro del array");
                    }
                    else
                    {
                        Console.WriteLine("El numero no esta dentro del array, introduce otro número por favor");
                        inserted = int.Parse(Console.ReadLine());
                    }
                }
                    
            }

        }
        
        
        static void Multiples(int max) //400 es el valor maximo
        {
            int[] multiples = new int[20];
            Random r = new Random();
            //rellenando el array
            for (int i = 0; i < multiples.Length; ++i)
            {
                multiples[i] = r.Next(0, max);
            }
            Console.WriteLine("Quieres resaltar los múltiplos de 5 o 7");
            int resalted = int.Parse(Console.ReadLine());
            if(resalted == 5)
            {
                for (int i = 0; i < multiples.Length; ++i)
                {
                    if (multiples[i] % 5 == 0)
                    {
                        Console.WriteLine("["+multiples[i]+"]");
                    }
                    else
                    {
                        Console.WriteLine(multiples[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < multiples.Length; ++i)
                {
                    if (multiples[i] % 7 == 0)
                    {
                        Console.WriteLine("[" + multiples[i] + "]");
                    }
                    else
                    {
                        Console.WriteLine(multiples[i]);
                    }
                }
            }
        }
        
        
        static void TempArray()
        {
            int[] temp = new int[12];
            Random r = new Random();
            //rellenando el array
            for(int i =0; i < temp.Length; ++i)
            {
                if(i<5|| i > 9)
                {
                    temp[i] = r.Next(5, 20);
                }
                else
                {
                    temp[i] = r.Next(15, 30);
                }
                
                Console.WriteLine(temp[i]);
            }
            //dibujando el array
            string asterisk = "*";

            for(int i = 0; i < temp.Length; ++i)
            {
                Console.WriteLine();
                
             for(int j=0; j < temp[i]; ++j)
                {
                    Console.Write(asterisk+" ");
                }
            }
        }
        
        
        static void Ejercicio5(int narray, int min, int max)
        {
            int[] array = new int[narray];
            Random r = new Random();
            //dando valores al array
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = r.Next(min, max);
                Console.Write(array[i] + " ");
            }
            //ordenando el array de menor a mayor
            // comparar 5 , 2 ,3 ,4 ,7,5,9,4,12,85
            Console.WriteLine();
            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = i + 1; j < array.Length; ++j)
                {
                    if (array[i] > array[j])
                    {
                        int oldnum = array[i];
                        int newnum = array[j];
                        array[j] = oldnum;
                        array[i] = newnum;
                    }
                }
            }
            for (int i = 0; i < array.Length; ++i)
            {
                Console.Write(array[i] + " ");
            }
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
            int lower = array[0];

            for (int i = 1; i < array.Length; ++i)
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

        static void OneToRigth()
        {
            Random array = new Random();
            int[] nums = new int[20];
            for (int index = 0; index < nums.Length; index = index + 1)
            {
                nums[index] = array.Next(0, 50);
                Console.Write(nums[index] + " ");
            }
            int last = nums[nums.Length - 1];
            for (int index = nums.Length - 2; index >= 0; --index)
            {
                nums[index + 1] = nums[index];
            }
            nums[0] = last;
            Console.WriteLine();
            for (int index = 0; index < nums.Length; ++index)
            {
                Console.Write(nums[index] + " ");
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
                //elevando al cuadrado 
                for (int i = 0; i < array2.Length; ++i)
                {
                    array2[i] = Math.Pow(array1[i], 2);
                    Console.WriteLine("el array2 es " + array2[i]);

                }
                Console.WriteLine();
                //elevando al cubo 
                for (int i = 0; i < array3.Length; ++i)
                {

                    array3[i] = Math.Pow(array1[i], 3);
                    Console.WriteLine("el array3 es " + array3[i]);


                }

            }
        }
    }
}
