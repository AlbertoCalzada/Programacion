using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaListasColasPilas
{
    internal class Pila
    {
        NododePila ultimo;
        int size;

        public Pila()
        {
            size= 0;
            ultimo = null;
        }

        public void Push(int elem)
        {
            NododePila nuevo = new NododePila(elem);

            nuevo.SetSiguiente(ultimo);
            ultimo = nuevo;
            ++size;
        }
    }
}
