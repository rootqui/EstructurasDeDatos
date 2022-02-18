using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolGenerico
{
    class Program
    {
        static void Main(string[] args)
        {

            CArbol arbol = new CArbol();

            CNodo raiz = arbol.Insertar("a", null);

            arbol.Insertar("b", raiz);
            arbol.Insertar("c", raiz);



            CNodo n = arbol.Insertar("d", raiz);
            arbol.Insertar("h", n);

            n = arbol.Insertar("e", raiz);
            arbol.Insertar("i", n);

            n = arbol.Insertar("j", n);
            arbol.Insertar("p", n);
            arbol.Insertar("q", n);

            //arbol.TransversaPreO(raiz);

            n = arbol.Insertar("f", raiz);
            arbol.Insertar("k", n);
            arbol.Insertar("l", n);
            arbol.Insertar("m", n);

            n = arbol.Insertar("g", raiz);
            arbol.Insertar("n", n);


            arbol.TransversaPreO(raiz);
            Console.WriteLine("----------------------");
            //arbol.TransversaPostO(raiz);

            Console.WriteLine("----------------------");

            CNodo encontrado = arbol.Buscar("k", raiz);
            if (encontrado != null)
            {
                Console.WriteLine(encontrado.Dato);
            }
            else
            {
                Console.WriteLine("No lo encontre");
            }


            Console.ReadLine();
        }
    }
}
