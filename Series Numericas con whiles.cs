using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace Practica_de_Ejercicios
{

    class Program
    {
        static void Main(string[] args)
        {



            Ejercicio4();
            //Console.WriteLine("Cuantos numeros quieres sumar?");
            //int asknum = int.Parse(Console.ReadLine());
            //while (asknum == 0)
            //{
            //    Console.WriteLine("Has introducido un numero incorrecto, prueba de nuevo porfavor");
            //    asknum = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Introduce " + asknum + " numeros");
            //int num1 = int.Parse(Console.ReadLine());
            //int suma = num1;
            //int contador = 1;
            
            //while (contador!=asknum)
            //{
                
                
            //    num1 = int.Parse(Console.ReadLine());
            //    contador++;
                
            //    suma = suma + num1;

            //}
            //Console.WriteLine("El resultado de tu suma es " +suma);














        }

        static void Ejercicio2()
        {
            Console.WriteLine("Escribeme dos numeros para ser sumados");
            int num1=int.Parse(Console.ReadLine());
            int num2= int.Parse(Console.ReadLine());
            int suma=num1 + num2;
            Console.WriteLine(suma);
            Console.WriteLine("Quieres continuar?, escribe 1(si) o 2 para el (no)");
            
            int decision= int.Parse(Console.ReadLine());
            while(decision==1)
            {
                Console.WriteLine("Escribeme dos numeros para ser sumados");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                suma = num1 + num2;
                Console.WriteLine(suma);
                Console.WriteLine("Quieres continuar?, escribe 1(si) o 2 para el (no)");

                decision = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Has salido del bucle");
        }

        static void Ejercicio3()
        {
            Console.WriteLine("Vamos a  descubrir esta serie numerica:  1, 9, 25, 49, ? ,? ,? ..");

            int numerodelaserie = 1;
            int valoracumulado = 8;
            int contador = 0;

            while (contador!= 7)
            {
                Console.WriteLine(numerodelaserie);
                numerodelaserie = numerodelaserie + valoracumulado;
                valoracumulado = valoracumulado + 8;
                contador++;

            }
            
            
        }

        static void Ejercicio4()
        {
            
            int primernumero = 4;
            int contador = 0;
            int bandera = 0;

            while (bandera!=6)
            {

                Console.WriteLine(primernumero);



                if (contador== 0)
                {
                    primernumero = primernumero + 52;
                    contador = 1;
                }
                else if(contador==1)
                {

                    primernumero = primernumero + 36;
                    contador = 0;
                }


                bandera++;
                



            }


        }
    }
}
