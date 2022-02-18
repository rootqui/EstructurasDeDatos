using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSeparate

{
    class CNodo
    {
        // Atributo Dato que almacena informacion del nodo
        private int llave;
        private string valor;

        // Atributo Siguiente es la referencia a otro nodo
        // ya que el siguiente del nodo actual es otro Nodo
        private CNodo siguiente = null;


        // Propiedades de Llave
        public int Llave
        {
            get { return llave; }

            set { llave = value; }
        }

        // Propiedades de Valor
        public string Valor
        {
            get { return valor; }

            set { valor = value; }
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
            return string.Format("[ {0}, {1} ]", llave, valor);
        }


    }


}

