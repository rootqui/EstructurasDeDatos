using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeInfixAPostfix

{
    class CStack
    {
        // El ancla es el encabezado del Stack
        private CNodo ancla;

        // Esta variable de referencia nos ayuda a trabajar con el stack
        private CNodo trabajo;

        public CStack()
        {
            // Instanciamos el ancla
            ancla = new CNodo();

            // Como es un Stack vacio su siguiente es null
            ancla.Siguiente = null;
        }

        // Push
        // Agrega un elemento en el Stack
        public void Push(char pDato)
        {
            // Creamos un nodo temporal
            CNodo temp = new CNodo();
            temp.Dato = pDato;

            // Conectamos el temporal a la lista
            temp.Siguiente = ancla.Siguiente;

            // Conectamos el ancla al temporal
            ancla.Siguiente = temp;
        }

        // Pop
        // Elimina un elemento en el Stack
        public char Pop()
        {
            // Colocar una excepcion cuando se intente hacer un pop a un stack vacio

            char valor = ' ';

            if (ancla.Siguiente != null)
            {
                // Obtenemos el dato correspondiente
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;

                // Lo eliminamos del Stack
                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;

            }

            return valor;

        }

        // Peek
        // Obtiene el valor del Stack,
        // el ultimo elemento agregado al Stack
        public char Peek()
        {
            // Colocar una excepcion cuando se intente hacer un pop a un stack vacio

            char valor = ' ';

            if (ancla.Siguiente != null)
            {
                // Obtenemos el dato Correspondiente
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;
            }

            return valor;
        }

        // Transversa

        public void Transversa()
        {
            // Trabajo al inicio
            trabajo = ancla;

            // Recorremos hasta encontrar el final
            while (trabajo.Siguiente != null)
            {
                // Avanzamos trabajo
                trabajo = trabajo.Siguiente;

                // Obtenemos el dato y lo mostramos
                char d = trabajo.Dato;
                Console.WriteLine("[{0}]", d);
            }

        }

        public bool EstaVacio()
        {
            if (ancla.Siguiente == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}



