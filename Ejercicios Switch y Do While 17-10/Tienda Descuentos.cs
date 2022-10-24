using System;

namespace TiendaPromociones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop();
        }



        static void Shop()
        {
            Console.WriteLine("¿Cada cuántos productos quieres aplicar el descuento?");
            int numdiscounts= int.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuantos productos quieres pasar por caja?");
            int numproducts= int.Parse(Console.ReadLine());
            Discounts(numdiscounts, numproducts);
            
            
        }

        static int Discounts(int numdiscounts, int numproducts)
        {
            Console.WriteLine("¿Cuánto cuesta este producto sin descuento?");
            double price = int.Parse(Console.ReadLine());
            double finalprice;
             double doscount = 0.2;
            for (int i=1;i<=numproducts ; i=i+1) 
            {
                for (int j = 1; j <= numdiscounts; j = j + 1)
                {
                    
                    if (j<=numdiscounts )
                    {

                        Console.WriteLine("20% descuento");

                    }
                    

                    Console.WriteLine("segundo bucle");
                    
                }
                Console.WriteLine("primer bucle");
            }


            return numproducts;
        }
    }

}
