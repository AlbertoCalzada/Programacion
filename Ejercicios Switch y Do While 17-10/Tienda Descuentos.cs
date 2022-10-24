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
            double finalprice = 0;
            double discount = 0.2;
            for (int i=1;i<=numproducts ; i=i+1) 
            {
                for (int j = 1; j <= numdiscounts; j = j + 1)
                {
                    
                    if (j<=numdiscounts && i==1 )
                    {
                        
                        Console.WriteLine("20% descuento");
                        finalprice = finalprice + price; 
                        Console.WriteLine(finalprice);
                    } else if(j <= numdiscounts && i == 2)
                    {
                        discount = discount / 2;
                        Console.WriteLine("10%descuento");
                    }else if (j <= numdiscounts && i == 3)
                    {
                        discount = discount / 2;
                        Console.WriteLine("5%descuento");
                    }




                        Console.WriteLine("segundo bucle");
                    
                }
                Console.WriteLine("primer bucle");
            }


            return numproducts;
        }
    }

}
