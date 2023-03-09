using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaListasColasPilas
{
    internal class Lista
    {
        NododePila primero;
        int size;

        public Lista()
        {
            size = 0;
            primero = null;
        }

        public void Add(int elem)
        {
            NododePila nuevo = new NododePila(elem);
            if (size == 0)
            {
                primero= nuevo;
            }
            else
            {
                
                NododePila n = primero;
                while (n.GetSiguiente() != null)
                {
                    n = n.GetSiguiente();
                }

                n.SetSiguiente(nuevo);
                
            }
            ++size;
        }

        public void RemoveAll()
        {
            if (size == 0)
            {
                Console.WriteLine("ya esta vacio primo");
            }
            else
            {
                primero=null;
            }
        }

        public void RemoveAt(int position)
        {
            
            if (position > size)
            {
                Console.WriteLine("Esta posicion no existe, que haces??");
            }
            else
            {
                NododePila n = primero;
                if (position == 1)
                {
                    primero=n.GetSiguiente();
                    n.SetSiguiente(null);
                }
                else
                {
                    NododePila anterior = null;
                 
                    for (int i = 1; i < position; i++)
                    {
                        if (i == position - 1)
                        {
                            anterior = n;
                        }
                        n = n.GetSiguiente();
                    }
                    anterior.SetSiguiente(n.GetSiguiente());
                    n.SetSiguiente(null);

                }
               
            }
        }
        public void RemoveElem(int elem)
        {
            NododePila n = primero;
            NododePila anterior = null;

            while (n!=null && n.getElem()!=elem) 
            {
                anterior = n;
                n = n.GetSiguiente();
            }

            anterior.SetSiguiente(n.GetSiguiente());
            n.SetSiguiente(null);

        }

        public string ToString()
        {
            NododePila n= primero;
            string cadena = " ";

            while (n!=null)
            {
                cadena += n.getElem();
                n= n.GetSiguiente();
            }
            return cadena;
        }
    }
}
