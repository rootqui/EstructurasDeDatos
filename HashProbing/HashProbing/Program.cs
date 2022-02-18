using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Open Addressing
//  Linear Probing
//  Quadratic Probing 

namespace HashProbing
{
    class Program
    {
        private static CCelda[] tabla;
        private static int cantidad;

        static void Main(string[] args)
        {
            int n = 0;

            // Inicializamos la tabla
            cantidad = 11;

            tabla = new CCelda[cantidad];

            for (n = 0; n < cantidad; n++)
            {
                tabla[n] = new CCelda();
            }

            // Mostrar();

            Insertar(23, "Hola");
            Insertar(51, "Manzana");
            Insertar(40, "Pera");
            Insertar(62, "Mango");

            Mostrar();

            Console.ReadLine();

            
        }

        public static void Mostrar()
        {
            int n = 0;

            for (n = 0; n < cantidad; n++)
            {
                Console.WriteLine("{0} [{1},{2}]",n ,tabla[n].Llave, tabla[n].Valor);
            }
        }

        public static int HashFuncion(int pLlave, int pIntento)
        {
            int indice = 0;

            // Linear Probing
            indice = (pLlave + pIntento) % cantidad;

            // Quadratic Probing
            //indice = (pLlave + pIntento*pIntento) % cantidad;

            return indice;

        }

        public static void Insertar(int pLlave, string pValor)
        {
            // Contador de intentos
            int i = 0;

            int indice = 0;
            bool ocupado = false;

            while (ocupado == false)
            {
                // Calculamos el indice
                indice = HashFuncion(pLlave, i);

                // Verificamos si esta vacia la celda 
                if (tabla[indice].MiEstado == Estado.vacio)
                {
                    // Calculamos el indice
                    ocupado = true;
                    tabla[indice].Llave = pLlave;
                    tabla[indice].Valor = pValor;
                    tabla[indice].MiEstado = Estado.ocupado;

                }
                else
                {
                    // Avanzamos al siguiente intento
                    i++;
                }

            }

        }


    }
}
