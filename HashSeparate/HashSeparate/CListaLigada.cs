using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSeparate
{
    class CListaLigada
    {
        private CNodo ancla;

        private CNodo trabajo;

        private CNodo trabajo2;

        internal CNodo Ancla
        {
            get { return ancla; }

            set { ancla = value; }
        }

        public CListaLigada()
        {
            Ancla = new CNodo();

            Ancla.Siguiente = null;
        }

        public void Transversa()
        {
            String salida = "";

            trabajo = Ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;

                salida = salida + String.Format("[ {0} ] o--> ", trabajo);

            }

            salida = salida + "null";

            Console.WriteLine(salida);
            //Console.WriteLine();
        }

        public void Adicionar(int pLlave, string pValor)
        {
            trabajo = Ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
            }

            CNodo nuevo = new CNodo();

            nuevo.Llave = pLlave;
            nuevo.Valor = pValor;
            
            nuevo.Siguiente = null;

            trabajo.Siguiente = nuevo;

        }

        // Vacia la Lista
        public void Vaciar()
        {
            ancla.Siguiente = null;

            // En lenguajes no administrados hay que liberar la memoria adecuadamente
            // Aqui aprovechamos el recolector de basura 
        }

        // Indica si la lista esta vacia o no
        public bool EstaVacio()
        {
            if (ancla.Siguiente == null)
                return true;
            else
                return false;

        }

        // Regresa el nodo con la primera ocurrencia del dato
        // Uso Recursiva?
        public CNodo Buscar(int pLlave)
        {
            if (EstaVacio() == true)
            {
                return null;
            }

            trabajo2 = ancla;

            while (trabajo2.Siguiente != null)
            {

                trabajo2 = trabajo2.Siguiente;

                if (trabajo2.Llave == pLlave)
                {
                    return trabajo2;
                }
            }

            //Si no se encontro, regresamos un null
            return null;

        }

        // Busca el indice donde se encuentra la primera ocurrencia del dato
        public int BuscarIndice(int pLlave)
        {
            int indice = -1;

            trabajo = Ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;

                indice++;

                if (trabajo.Llave == pLlave)
                {
                    return indice;
                }

            }

            return -1;
        }

        // Encuentra el Nodo Anterior
        // Si esta en el primer nodo se regresa el ancla
        // Si el dato no existe se regresa el ultimo nodo
        public CNodo BuscarAnterior(int pLlave)
        {
            trabajo2 = Ancla;
            while (trabajo2.Siguiente != null && trabajo2.Siguiente.Llave != pLlave)
            {
                trabajo2 = trabajo2.Siguiente;
            }

            return trabajo2;
        }

        // Borra la primera ocurrencia del dato

        public void Borrar(int pLlave)
        {
            // Verificamos que se tenga datos
            if (EstaVacio() == true)
            {
                return;
            }

            CNodo anterior = BuscarAnterior(pLlave);

            CNodo encontrado = Buscar(pLlave);

            if (encontrado == null)
            {
                return;
            }

            anterior.Siguiente = encontrado.Siguiente;

            encontrado.Siguiente = null;

        }

        // Inserta el dato pValor 
        // despues de la primera ocurrencia del dato pasado a pDonde

        public void Insertar(int pDonde, int pLlave, string pValor)
        {
            // Encontramos la posicion donde vamos a insertar
            trabajo = Buscar(pDonde);

            // Verificamos que exista donde vamos a insertar
            if (trabajo == null)
            {
                return;
            }

            // Creamos el nodo temporal a insertar

            CNodo temp = new CNodo();

            temp.Llave = pLlave;
            temp.Valor = pValor;

            // Conectamos el temporal a la lista
            temp.Siguiente = trabajo.Siguiente;

            // Conectamos trabajo a temporal
            trabajo.Siguiente = temp;


        }

        public void InsertarInicio(int pLlave, string pValor)
        {
            // Creamos el nodo temporal
            CNodo temp = new CNodo();

            temp.Llave = pLlave;
            temp.Valor = pValor;

            // Conectamos el temporal a la Lista 
            temp.Siguiente = Ancla.Siguiente;

            // Conectamos el ancla al temporal
            Ancla.Siguiente = temp;

        }


        public CNodo ObtenerPorIndice(int pIndice)
        {
            trabajo2 = null;
            int indice = -1;

            trabajo = Ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                indice++;

                if (indice == pIndice)
                {
                    trabajo2 = trabajo;
                }
            }

            return trabajo2;
        }

        // Creamos un indexer
        public int this[int pIndice]
        {
            get
            {
                // Esto puede crear una excepcion si trabajo es igual a null
                // Colocar codigo de seguridad o usar int?
                trabajo = ObtenerPorIndice(pIndice);

                return trabajo.Llave;
            }

            set
            {
                trabajo = ObtenerPorIndice(pIndice);
                if (trabajo != null)
                {
                    trabajo.Llave = value;
                }
            }

        }


    }
}




