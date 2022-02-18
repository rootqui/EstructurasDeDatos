using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReHash

{

    enum Estado
    {
        vacio, ocupado, borrado
    }

    class CCelda
    {
        private int llave;

        private string valor;

        private Estado miEstado;

        public int Llave
        {
            get{ return llave; }

            set{ llave = value; }
        }

        public string Valor
        {
            get{ return valor; }

            set{ valor = value; }
        }

        internal Estado MiEstado
        {
            get{ return miEstado; }

            set{ miEstado = value; }
        }

        public CCelda()
        {
            Llave = 0;
            Valor = "";
            miEstado = Estado.vacio;
        }
        
    }

}

