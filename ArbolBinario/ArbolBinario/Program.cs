using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            CArbolBusquedaBinaria arbol = new CArbolBusquedaBinaria();

            CNodo raiz = arbol.Insertar(6,null);

            arbol.Insertar(2, raiz);
            arbol.Insertar(8, raiz);
            arbol.Insertar(1, raiz);
            arbol.Insertar(4, raiz);
            arbol.Insertar(3, raiz);
            arbol.Insertar(5, raiz);
            arbol.Insertar(7, raiz);
            arbol.Insertar(11, raiz);
            arbol.Insertar(9, raiz);
            arbol.Insertar(10, raiz);
            arbol.Insertar(0, raiz);
            arbol.Insertar(-1, raiz);
            arbol.Insertar(12, raiz);
            arbol.Insertar(14, raiz);

            arbol.Transversa(raiz);

            Console.WriteLine("El menor es {0}", arbol.EncuentraMinimo(raiz));
            Console.WriteLine("El mayor es {0}", arbol.EncuentraMaximo(raiz));

            arbol.TransversaOrdenada(raiz);

            Console.WriteLine();
            CNodo padre = arbol.BuscarPadre(11, raiz);
            Console.WriteLine(padre.Dato);


            Console.ReadLine();
        }
    }
}
