using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaListasColasPilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista= new Lista();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.RemoveAt(3);
            Console.WriteLine(lista.ToString()); 
            Console.ReadLine();
        }
    }
}
