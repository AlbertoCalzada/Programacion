using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace PruebasAntesExamenSegundaEvaluacion
{
    internal class Lista
    {
        Nodo primero;
        int size;

        public Lista()
        {
            size = 0;
            primero = null;
        }

        public int GetSize()
        {
            return size;
        }

        public Nodo GetSiguiente()
        {

            return primero;

        }

        public void AddFirst(int elem)
        {
            Nodo nuevo = new Nodo(elem);
            nuevo.SetSiguiente(primero);
            primero= nuevo;
            size++;
        }
        public void AddLast(int elem)
        {
            Nodo nuevo = new Nodo(elem);
            if (size == 0)
            {
                primero = nuevo;
            }
            else
            {

                Nodo n = primero;
                while (n.getSiguiente() != null)
                {
                    n = n.getSiguiente();
                }

                n.SetSiguiente(nuevo);

                ++size;
            }       
        }
        public void RemoveAt(int position)
        {
            if (position > size)
            {
                Console.WriteLine("Esa posición no existe");
            }
            else
            {
                Nodo n = primero;

                if (position == 1)
                {
                    primero=n.getSiguiente();
                    n.SetSiguiente(null);
                }
                else
                {
                    Nodo anterior = null;
                    for (int i = 1; i < position; ++i)
                    {
                        if (i == position - 1)
                        {
                            anterior = n;
                        }

                        n = n.getSiguiente();
                    }
                    anterior.SetSiguiente(n.getSiguiente());
                    n.SetSiguiente(null);
                }
                --size;

            }
           
        }

        public void RemoveElem(int elem)
        {
            Nodo n = primero;

            if (elem == n.getElem())
            {
                primero = n.getSiguiente();
                n.SetSiguiente(null);
            }
            else
            {
                Nodo anterior = null;

                while (n.getElem() != elem)
                {
                    anterior = n;
                    n = n.getSiguiente();
                }
                anterior.SetSiguiente(n.getSiguiente());
                n.SetSiguiente(null);
            }
            --size;
        }

        public string ToString()
        {
            Nodo n = primero;
            string cadena = " ";

            while (n!=null)
            {
                cadena = cadena + n.getElem();
                n=n.getSiguiente();
            }
            return cadena;
        }
    }
}
