using System;

namespace Ejercicio_5_Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Introduceme un numero para ver si es primo o no");
            int num1 = int.Parse(Console.ReadLine());
            bool primo = true;
            Console.WriteLine(VerdaderoFalso(num1, primo));
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

                } else if(numconsult==1)

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

                
              
                

            } while (counter<=numconsult);
        }
            

        
    }
}
