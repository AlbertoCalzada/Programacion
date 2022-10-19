using System;

namespace Ejercicio_5_Funciones
{
    class Program
    {
        static void Main(string[] args)
        {

            Ejercicio5();
            //Console.WriteLine("Introduceme un numero para ver si es primo o no");
            //int num1 = int.Parse(Console.ReadLine());
            //bool primo = true;
            //Console.WriteLine(VerdaderoFalso(num1, primo));
        }



        static void Ejercicio5()
        {
            Console.WriteLine("Dime el número que quieras saber si es primo o compuesto: ");
            int primenum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Para saber si el número es primo escribe true");
            Console.WriteLine("Para saber si el número es compuesto escribe false");
            bool prime;
            prime = bool.Parse(Console.ReadLine());

            bool answer = ISPrimeNumber(primenum, prime);
            if (prime == true && answer == true)
            {
                Console.WriteLine("El número " + primenum + " es primo");
            }
            else
            {
                if (prime == true)
                {
                    Console.WriteLine("El número " + primenum + " no es primo");
                }
                else
                {
                    if (answer == false)
                    {
                        Console.WriteLine("El número no es compuesto");
                    }
                    else
                    {
                        Console.WriteLine("El número es compuesto");
                    }
                }
            }

        }
        static bool ISPrimeNumber(int num, bool isPrime)
        {
            int counter;
            counter = 2;
            bool prime;
            prime = true;
            do
            {
                if (num % counter == 0)
                {
                    prime = false;
                }
                counter++;
            } while (counter < num && prime);
            if (isPrime == true)
            {
                return prime;
            }
            else
            {
                return !prime;
            }
        }



        static string VerdaderoFalso(int numconsult, bool b)
        {
            //int result;

            //bool primo = true;

            int counter = 2;
            bool prime = true;
            do
            {
                int result = numconsult % counter;


                if (result == 0)
                {


                    prime = false;
                    return "El numero no es primo";

                }
                else if (numconsult == 1)

                {
                    Console.WriteLine("Valor incorrecto, introduce otro numero");
                    numconsult = int.Parse(Console.ReadLine());

                }

                counter++;





            } while (counter != numconsult);

            return "El numero es primo";
        }





        static void Ejercicioprimo()
        {
            Console.WriteLine("Introduce un numero para saber si es primo");
            int numconsult = int.Parse(Console.ReadLine());
            int counter = 2;
            bool prime = true;
            do
            {
                int result = numconsult % counter;


                if (result == 0)
                {


                    prime = false;
                }

                counter++;





            } while (counter <= numconsult);
        }



    }
}
