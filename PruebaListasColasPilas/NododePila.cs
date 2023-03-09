using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaListasColasPilas
{
    internal class NododePila
    {
        NododePila siguiente;
        int elem;

        public NododePila(int elem)
        {
            this.elem=elem;
            siguiente = null;           
        }

        public int getElem() { return elem; }
        public void setElem(int elem)
        {
            this.elem = elem;
        }
        public NododePila GetSiguiente()
        {
            return siguiente;
        }
        public void SetSiguiente(NododePila n)
        {
            this.siguiente = n;
        }


    }
}
