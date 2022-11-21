using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayMenu();
        }

        
        static void ArrayMenu()
        {
            int[] array = CreateRandomArray(10, 0, 10);
            Console.WriteLine("\n");
            Console.WriteLine("1.Función recibe un array y devuelve el número de 0 que hay dentro");
            Console.WriteLine("2.Función recibe un array y devuelve el resultado de sumar los números pares del array");
            Console.WriteLine("3.Función recibe un array y un entero y devuelve el número de veces que está ese número dentro del array");
            Console.WriteLine("4.Función recibe un array y dos valores(antiguo y nuevo) y la función va a sustituir el valor antiguo por el nuevo");
            Console.WriteLine("5.Función recibe un array y dos valores que van a representar la posciones en el array para luego intercambiar sus valores");
            Console.WriteLine("6.Función recibe un array y lo invierte");
            Console.WriteLine("7.Función que rota el array a la izquierda");
            Console.WriteLine("8.Salir del programa");
            Console.WriteLine("¿Que opción deseas?"); 
            int menu = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (menu)
            {
                case 1:
                    Console.WriteLine(" hay "+zerotimes(array) + " ceros en el array"); 
                    break;
                case 2:
                    Console.WriteLine("el resultado es "+Sumpairs(array));
                    break;
                case 3:
                    Console.WriteLine("hay " + ntimes(array,5)+ " en el array");
                    break;
                case 4:
                    reemplace(array, 2, 6); 
                    break;
                case 5:
                    swap(array, 2, 7);
                    break;
                case 6:
                    Invertarray(array);
                    break;
                case 7:
                    Rotateleft(array);
                    break;
                case 8:
                    Console.WriteLine("Fin del programa");
                    break;
            }
        }

        static void Rotateleft(int[] array)
        {

            for (int i = 0; i < array.Length; ++i)
            {
                if (i == 0)
                {
                    array[i] = array[array.Length-1];
                }
                else
                {
                    int last= array[array[i]]-1;
                    array[i] = last;
                }
                Console.Write(array[i] + " ");
            }
            
            //Console.WriteLine();
            //for (int i = 0; i < array.Length; ++i)
            //{
            //    Console.Write(array[i] + " ");
            //}
        }
        
        static void swap(int[] array, int position1, int position2)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                if (i == position1)
                {
                    int first = array[position1];
                    int last = array[position2];
                    array[position1] = last;
                    array[position2] = first;
                }
                Console.WriteLine(array[i] + " ");
            }
        }
        static int zerotimes(int[] array)
        {
            int zero = 0;
            int nzeros = 0;
            for (int i = 0; i < array.Length; ++i)
            {


                if (array[i] == zero)
                {
                    ++nzeros;
                }
                
            }
            

            return nzeros;
        }

        static int Sumpairs(int[] array)
        {
            int zero = 0;
            int sumnumpairs = 0;
            for (int i = 0; i < array.Length; ++i)
            {


                if (array[i] % 2 == zero)
                {
                    sumnumpairs = sumnumpairs + array[i];
                }

            }
            return sumnumpairs;
        }

        static int ntimes(int[] array, int number)
        {

            
            int nnumber = 0;
            for (int i = 0; i < array.Length; ++i)
            {


                if (array[i] == number)
                {
                    ++nnumber;
                }

            }

            return nnumber;
        }

        static void reemplace(int[] array, int oldnum, int newnum)
        {
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] == oldnum)
                {
                    array[i] = newnum;
                }
                Console.WriteLine(array[i] + " ");
            }

            
        }

        static void Invertarray(int[] array)
        {

            int secondcounter = 1;
            //array = new int[arraysize];
            for (int i = 0; i < array.Length; ++i)
            {
                if (i == 0)
                {
                    int first = array[i];
                    int last = array[array.Length - 1];
                    array[i] = last;
                    array[array.Length - 1] = first;
                }
                else
                {
                    if (i < (array.Length / 2))
                    {
                        int first = array[i];
                        int last = array[array.Length - secondcounter];
                        array[i] = last;
                        array[array.Length - secondcounter] = first;
                    }
                    
                    
                    
                }
                ++secondcounter;
                Console.Write(array[i]+ " " );
                
            }
        }


        static int [] CreateRandomArray(int arraysize, int min, int max) //para crear y rellenar array sin tener que repetir código
        {
            int[] array = new int[arraysize];
            Random r = new Random();

            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = r.Next(min, max);
                Console.Write(array[i] + " ");
            }
            return array;
        }
        static void insidearray(int n)
        {
            int[] inside = new int[n];
            Random r = new Random();
            
            for (int i = 0; i < inside.Length; ++i)
            {
                inside[i] = r.Next(0, 101);
                Console.WriteLine(inside[i]+ " ");
            }
            Console.WriteLine();
            bool intento = false;
            do
            {


                Console.WriteLine("Introduceme un numero para saber si esta dentro del array");
                int inserted = int.Parse(Console.ReadLine());

                for (int i = 0; i < inside.Length; ++i)
                {
                    if (inside[i] == inserted)
                    {
                        Console.WriteLine("esta dentro");
                        intento = true;
                    }
                }
                if (intento == false)
                {
                    Console.WriteLine("el numero introduce no se eucnetra intentalo de nuevo");
                }
            } while (intento != true);

            
            
            
            
                
                    
            

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
            for (int i = 0; i < multiples.Length; ++i)
            {
                if (multiples[i] % resalted == 0 && multiples[i] != 0)
                {
                    Console.Write("[" + multiples[i] + "]");
                }
                else
                {
                    Console.Write(" " + multiples[i] + " ");
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
                    temp[i] = r.Next(5, 18);
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
