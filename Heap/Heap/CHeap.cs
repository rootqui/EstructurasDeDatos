using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class CHeap
    {
        private int capacidad;
        private int tamano;
        private int[] elementos;

        public CHeap(int pCapacidad)
        {
            capacidad = pCapacidad;
            elementos = new int[capacidad];
        }

        public void Transversa()
        {
            int n = 0;
            for (n = 0; n <= tamano; n++)
            {
                Console.Write("{0}, ", elementos[n]);
            }

            Console.WriteLine();

        }

        public bool EstaLleno()
        {
            if (tamano >= capacidad)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insertar(int valor)
        {
            int n = 0;

            if (EstaLleno())
            {
                return;
            }
            else
            {
                for (n = tamano + 1; elementos[n / 2] > valor; n /= 2)
                {
                    elementos[n] = elementos[n / 2];
                }

                elementos[n] = valor;
                tamano++;
            }

        }

        public int BorrarMin()
        {
            int n = 0;
            int hijo = 0;
            int elementoMenor = 0;
            int ultimoElemento = 0;

            if (tamano <= 0)
            {
                return 0;
            }

            elementoMenor = elementos[1];
            ultimoElemento = elementos[tamano--];

            for (n = 1; n*2 <= tamano; n = hijo)
            {
                // Encontramos al menor
                hijo = n * 2;
                if (hijo != tamano && elementos[hijo+1]< elementos[hijo])
                {
                    hijo++;
                }

                // Percolamos
                if (ultimoElemento > elementos[hijo])
                {
                    elementos[n] = elementos[hijo];
                }
                else
                {
                    break;
                }
            }

            // Actulizamos
            elementos[n] = ultimoElemento;

            // Regresamos el menor
            return elementoMenor;


        }



    }
}
