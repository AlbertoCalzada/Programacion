using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasAntesExamenSegundaEvaluacion
{
    internal class Cola
    {
        Nodo primero;
        Nodo ultimo;
        int size;

        public Cola()
        {
            primero = null;
            ultimo=null;
            size = 0;
        }

        public Nodo GetPrimero()
        {
            return primero;
        }
        public Nodo GetUltimo()
        {
            return ultimo;
        }
        public int GetSize()
        {
            return size;
        }

        public void Enqueue(int elem)
        {
            Nodo nuevo = new Nodo(elem);
            if (size == 0)
            {
                primero = nuevo;
            }
            else
            {
                ultimo.SetSiguiente(nuevo);
            }
            ultimo = nuevo;
            ++size;
            
        }

        public void Dequeue()
        {
            Nodo aux = primero;
            primero = primero.getSiguiente();
            aux.SetSiguiente(null);
            --size;
           
        }

        public string ToString()
        {
            string cadena = " ";
            Nodo n = primero;

            while (n != null)
            {
                cadena = cadena + n.getElem();
                n= n.getSiguiente();
            }

            return cadena;
        }


    }
}
