using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasAntesExamenSegundaEvaluacion
{
    class Nodo
    {
        int elem;
        Nodo siguiente;

        public Nodo(int elem)
        {
            this.elem = elem;
            siguiente = null;
        }

        public int getElem() { return elem; }
        public Nodo getSiguiente()
        {
            return siguiente;
        }

        public void SetSiguiente(Nodo siguiente)
        {
            this.siguiente = siguiente;
        }
    }

    class Pila
    {
        int size;
        Nodo ultimo;

        public Pila()
        {
            size = 0;
            ultimo = null;
        }

        public int GetSize()
        {
            return size;
        }

        public Nodo GetUltimo()
        {
            return ultimo;
        }


        public void Push(int elem)
        {
            Nodo nuevo = new Nodo(elem);
            Nodo n = ultimo;
            ultimo = nuevo;
            nuevo.SetSiguiente(n);
            ++size;
        }

        public void Pull()
        {
            if (size == 0)
            {
                
            }
            else
            {
                Nodo aux = ultimo;
                ultimo = ultimo.getSiguiente();
                aux.SetSiguiente(null);
                --size;
            }
        }

        public string ToString()
        {
            string cadena = " ";
            Nodo n = ultimo;

            while (n != null)
            {
                cadena = cadena + n.getElem();
                n = n.getSiguiente();
            }

            return cadena;
        }
         
    }
}
