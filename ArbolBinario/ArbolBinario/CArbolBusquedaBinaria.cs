using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class CArbolBusquedaBinaria
    {
        private CNodo raiz;
        private CNodo trabajo;

        private int i = 0;

        public CArbolBusquedaBinaria()
        {
            raiz = null;
        }

        public CNodo Raiz
        {
            get { return raiz; }
            set { raiz = value; }
        }

        // Insertar
        public CNodo Insertar(int pDato, CNodo pNodo)
        {
            CNodo temp = null;

            // Si no hay a quien insertar entonces creamos el nodo
            if (pNodo == null)
            {
                temp = new CNodo();
                temp.Dato = pDato;

                return temp;
            }

            if (pDato < pNodo.Dato)
            {
                pNodo.Izquierda = Insertar(pDato, pNodo.Izquierda);
            }

            if (pDato > pNodo.Dato)
            {
                pNodo.Derecha = Insertar(pDato,pNodo.Derecha);
            }

            return pNodo;

        }

        // Transversa
        public void Transversa(CNodo pNodo)
        {
            if (pNodo == null)
            {
                return;
            }

            // Proceso primero al nodo raiz
            for (int n = 0; n < i; n++)
            {
                Console.Write("  ");
            }

            Console.WriteLine(pNodo.Dato);

            // Si tengo nodo izquierda, proceso a la izquierda
            if (pNodo.Izquierda != null)
            {
                i++;
                Console.Write("I ");
                Transversa(pNodo.Izquierda);
                i--;
            }

            // Si tengo nodo derecha, proceso a la derecha
            if (pNodo.Derecha != null)
            {
                i++;
                Console.Write("D ");
                Transversa(pNodo.Derecha);
                i--;
            }
          
        }

        // Encuentra el minimo
        public int EncuentraMinimo(CNodo pNodo)
        {
            if (pNodo == null)
            {
                return 0;
            }

            trabajo = pNodo;
            int minimo = trabajo.Dato;

            while (trabajo.Izquierda != null)
            {
                trabajo = trabajo.Izquierda;
                minimo = trabajo.Dato;
            }

            return minimo;

            //int minimo = pNodo.Dato;

            //while (pNodo.Izquierda != null)
            //{
            //    pNodo = pNodo.Izquierda;
            //    minimo = pNodo.Dato;
            //}

            //return minimo;
        }

        // Maximo 
        public int EncuentraMaximo(CNodo pNodo)
        {
            if (pNodo == null)
            {
                return 0;
            }

            trabajo = pNodo;
            int maximo = trabajo.Dato;

            while (trabajo.Derecha != null)
            {
                trabajo = trabajo.Derecha;
                maximo = trabajo.Dato;
            }

            return maximo;


            //int maximo = pNodo.Dato;

            //while (pNodo.Derecha != null)
            //{
            //    pNodo = pNodo.Derecha;
            //    maximo = pNodo.Dato;
            //}

            //return maximo;

        }

        // Tranversa InOrder
        public void TransversaOrdenada(CNodo pNodo)
        {
            if (pNodo == null)
            {
                return;
            }

            // Si tengo izquierda, proceso  a la izquierda
            if (pNodo.Izquierda != null)
            {

                TransversaOrdenada(pNodo.Izquierda);

            }

            Console.Write("{0}, ", pNodo.Dato);

            // Si tengo derecha, proceso  a la derecha
            if (pNodo.Derecha != null)
            {

                TransversaOrdenada(pNodo.Derecha);

            }

        }


        public CNodo BuscarPadre(int pDato, CNodo pNodo)
        {
            CNodo temp = null;

            if (pNodo == null)
            {
                return null;
            }

            // Verifico si soy el padre
            if (pNodo.Izquierda != null)
            {
                if (pNodo.Izquierda.Dato == pDato)
                {
                    return pNodo;
                }
            }

            if (pNodo.Derecha != null)
            {
                if (pNodo.Derecha.Dato == pDato)
                {
                    return pNodo;
                }
            }

            // Si tengo izquierda, proceso a la izquierda
            if (pNodo.Izquierda != null && pDato < pNodo.Dato)
            {
                temp = BuscarPadre(pDato, pNodo.Izquierda);
            }

            // Si tengo dereacha, proceso a la derecha
            if (pNodo.Derecha != null && pDato > pNodo.Dato)
            {
                temp = BuscarPadre(pDato, pNodo.Derecha);
            }

            return temp;

        }



        /*
         
        borrar(nodo, dato)
        {
            if nodo es null regresamos nodo
            else
            {
                if(dato < nodo.dato)
                {
                    nodo.izq = borrar(nodo.izq, dato)
                }
                else if(dato > nodo.dato)
                {
                    nodo.der = borrar(nodo.der, dato)
                }
                else
                {
                    // casos sin hijos
                    if(nodo.izq == null && nodo.der == null)
                    {
                        nodo = null
                        return nodo
                    }

                    // caso un hijo, hacer el caso espejo
                    else if(nodoizq == null)
                    {
                        padre = EncuentraPadre(nodo)
                        padre.der = nodo.der
                        return nodo
                    }
                    // Caso con dos hijos
                    else
                    {
                        minimo = EncontrarMinimo(nodo.der)
                        nodo.dato = minmo.dato
                        nodo.der = borrar(nodo.der, minimo.dato)
                    }
                }
            }
        }
         
         
         
         */



    }
}
