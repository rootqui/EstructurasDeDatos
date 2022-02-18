using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class CNodo
    {
        private int dato;

        private CNodo izq;
        private CNodo der;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public CNodo Izquierda
        {
            get { return izq; }
            set { izq = value; }
        }

        public CNodo Derecha
        {
            get { return der; }
            set { der = value; }
        }

        public CNodo()
        {
            dato = 0;
            Izquierda = null;
            Derecha = null;
        }





    }


}
