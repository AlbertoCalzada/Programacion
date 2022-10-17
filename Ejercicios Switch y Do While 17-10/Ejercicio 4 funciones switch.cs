using System;

namespace Ejercicio_4_Do_whiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribeme 3 numeros");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es " + Numbers(a, b, c));

        }


        static int Numbers(int num1, int num2, int num3)
        {
            
            
            int result;
            
            switch (num1)
            {
                
                case 1:
                    result = num2 + num3;
                break;

                case 2:
                    result = num2 * num3;
                    break;
                case 3:
                    result = num2 / num3;
                    break;
                case 4:
                    result = num2 - num3;
                    break;

                default:
                    return 0;
                    break;
            }
            return result;

        }
    }
}
