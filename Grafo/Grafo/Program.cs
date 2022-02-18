using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Orden Topologico
// geeksforgeeks.org/topological-sorting/

namespace Grafo
{
    class Program
    {
        static void Main(string[] args)
        {

            int nodo = 0;

            CGrafo miGrafo = new CGrafo(7);

            miGrafo.AdicionarArista(0, 1);
            miGrafo.AdicionarArista(0, 2);
            miGrafo.AdicionarArista(0, 3);
            miGrafo.AdicionarArista(1, 3);
            miGrafo.AdicionarArista(1, 4);
            miGrafo.AdicionarArista(2, 5);
            miGrafo.AdicionarArista(3, 2);
            miGrafo.AdicionarArista(3, 5);
            miGrafo.AdicionarArista(3, 6);
            miGrafo.AdicionarArista(4, 3);
            miGrafo.AdicionarArista(4, 6);
            miGrafo.AdicionarArista(6, 5);

            miGrafo.MuestraAdyacencia();

            miGrafo.CalcularIndegree();
            miGrafo.MostrarIndegree();

            Console.ForegroundColor = ConsoleColor.Cyan;
            do
            {
                // Encontramos el nodo con el indegree 0
                nodo = miGrafo.EncuentraI0();

                if (nodo != -1)
                {

                    // Imprimos el nodo
                    Console.Write("{0} -> ", nodo);

                    // Decrementamos los indegrees
                    miGrafo.DecrementaIndegree(nodo);

                }

            } while ( nodo != -1);


            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
