using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class CQueue
    {
        // El ancla es el encabezado del Queue
        private CNodo ancla;

        // Esta variable de referencia nos ayuda a trabajar con el Queue
        private CNodo trabajo;

        public CQueue()
        {
            // Instanciamos el ancla
            ancla = new CNodo();

            // Como es un Queue vacio su siguiente es null
            ancla.Siguiente = null;
        }

        // Enqueue
        // Agrega un elemento en el Queue
        public void Enqueue(int pDato)
        {
            // Trabajo al inicio
            trabajo = ancla;

            // Recorremos hasta encontrar el final
            while (trabajo.Siguiente != null)
            {
                // Avanzamos trabajo
                trabajo = trabajo.Siguiente;
            }

            // Creamos el nuevo nodo
            CNodo temp = new CNodo();

            // Insertamos el dato
            temp.Dato = pDato;

            // Enlazamos el ultimo nodo encontrado  con el nueva que ha sido creado
            trabajo.Siguiente = temp;

            // El nuevo nodo es el final del queue asignamos al siguient null
            temp.Siguiente = null;

        }

        // Dequeque
        // Elimina un elemento en el Queue
        public int Dequeue()
        {
            // Colocar una excepcion cuando se intente hacer un dequeue a un queue vacio

            int valor = 0;

            if (ancla.Siguiente != null)
            {
                // Obtenemos el nodo y su dato
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;

                // Lo llevamos fuera del Queue
                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;
            }

            return valor;

        }

        // Peek
        // Obtiene el valor del Queue,
        // el primer elemento agregado al Queue
        public int Peek()
        {
            // Colocar una excepcion cuando se intente hacer un peek a un queue vacio

            int valor = 0;

            // Si hay un elemento en el queue se obtiene el valor   
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
                int d = trabajo.Dato;
                Console.Write(" <- [{0}]", d);
            }

            Console.WriteLine();

        }



    }
}

