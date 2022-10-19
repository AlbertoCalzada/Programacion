using System;

namespace Ejercicio_Tarot
{
    class Program
    {
        static void Main(string[] args)
        {
            Tarot();
        }



        static void Tarot()
        {
            // calcular el numero del tarot 
            //año + mes + dia
            // sumando todas las cifras

            Console.WriteLine("introduce el dia");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("introduce el mes");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("introduce el año");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Tu numero del tarot es " + TarotNumber(year, month, day));

        }


        static int TarotNumber (int year, int month, int day) 
        {

            int sum = year + month + day;
           
            do
            {
                sum = DigitSum(sum);
            } while (sum > 10);
            return sum;
           
            
            //do
            //{
            //    int acum = 0;
            //    do
            //    {
            //        int aux = sum % 10; //el resto obtendremos
            //        acum = acum + aux;

            //        sum = sum / 10;

            //    } while (sum != 0);
            //    sum = acum;
            //} while (sum >= 10);
            //return sum;
            //acum = acum + sum;     





        }

        static int DigitSum(int a)
        {
            int acum = 0;
            do
            {
                int aux = a % 10; //el resto obtendremos
                acum = acum + aux;

                a = a / 10;

            } while (a != 0);
            return acum;
        }
    }
}
