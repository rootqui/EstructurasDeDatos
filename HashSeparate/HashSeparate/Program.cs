using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSeparate
{
    // Tablas Hash
    // Separate Chaining
    class Program
    {
        // Cantidad de celdas en la tabla
        private static int tamano = 10;
        private static CListaLigada[] tabla;

        static void Main(string[] args)
        {
            int n = 0;

            // Necesitamos un arreglo de listas ligadas para crear la tabla
            tabla = new CListaLigada[tamano];

            // Inicializamos la tabla
            for (n = 0; n < tamano; n++)
            {
                tabla[n] = new CListaLigada();
            }

            Mostrar();

            Console.WriteLine("---------------------------------");

            Insertar(57,"Hola");
            Insertar(45,"Manzana");
            Insertar(42,"Pera");
            Insertar(83,"Azul");
            Insertar(30,"Rojo");
            Insertar(94,"C#");
            Insertar(73,"C++");
            Insertar(97,"Saludos");

            Mostrar();
            
            Console.WriteLine("---------------------------------");

            Console.ReadLine();

        }

        public static void Mostrar()
        {
            int n = 0;

            for (n = 0; n < tamano; n++)
            {
                Console.Write("({0})", n);
                tabla[n].Transversa();
                Console.WriteLine(); 
            }
        }

        public static int HashFuncion(int pLlave)
        {
            int indice = 0;

            //Funcion
            indice = pLlave % tamano;

            return indice;
        }

        public static void Insertar(int pLLave, string pValor)
        {
            int indice = HashFuncion(pLLave);

            tabla[indice].Adicionar(pLLave, pValor);
        }

    }
}
