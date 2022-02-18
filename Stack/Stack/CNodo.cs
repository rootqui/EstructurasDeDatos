using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class CNodo
    {
        // Atributo Dato que almacena informacion del nodo
        private int dato;

        // Atributo Siguiente es la referencia a otro nodo
        // ya que el siguiente del nodo actual es otro Nodo
        private CNodo siguiente = null;


        // Propiedades de Dato
        public int Dato
        {
            get { return dato; }

            set { dato = value; }
        }

        // Propiedades de Siguiente
        internal CNodo Siguiente
        {
            get { return siguiente; }

            set { siguiente = value; }
        }

        // Metodo ToString para CNodo
        public override string ToString()
        {
            return string.Format("[ {0} ]", dato);
        }


    }


}

