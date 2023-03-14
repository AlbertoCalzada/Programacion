using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasAntesExamenSegundaEvaluacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista lista= new Lista();
            //lista.AddFirst(1);
            //lista.AddLast(2);
            //lista.AddLast(3);
            //lista.AddFirst(5);
            //lista.RemoveAt(4);
            //Console.WriteLine(lista.ToString());
            Pila pila = new Pila();
            pila.Push(1);
            pila.Push(2);
            pila.Push(3);
            pila.Push(4);
            pila.Pull();
            Console.WriteLine(pila.ToString());
            Console.ReadLine();
        }
    }
}
