using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            CHeap miHeap = new CHeap(13);

            miHeap.Insertar(1);
            miHeap.Insertar(2);
            //miHeap.Insertar(3);
            miHeap.Insertar(13);
            miHeap.Insertar(4);
            miHeap.Insertar(5);
            miHeap.Insertar(6);
            miHeap.Insertar(7);

            miHeap.Transversa();

            Console.WriteLine("Minimo {0}", miHeap.BorrarMin());
            miHeap.Transversa();

            Console.WriteLine("Minimo {0}", miHeap.BorrarMin());
            miHeap.Transversa();

            Console.WriteLine("Minimo {0}", miHeap.BorrarMin());
            miHeap.Transversa();

            Console.WriteLine("Minimo {0}", miHeap.BorrarMin());
            miHeap.Transversa();

            Console.WriteLine("Minimo {0}", miHeap.BorrarMin());
            miHeap.Transversa();

            Console.WriteLine("Minimo {0}", miHeap.BorrarMin());
            miHeap.Transversa();


            Console.ReadLine();
        }
    }
}

    /*
     * 
     *  Arbol de Indices 
     * 
     *
     *                         1
     *              2                   3
     *           4       5           6       7
     *        8    9  10   11     12   13           
     *
     * 
     */
