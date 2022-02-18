using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReHash
{
    class HashTable
    {
        private CCelda[] tabla;
        private int cantidad;
        private int insertados;

        public HashTable(int pTamano)
        {
            int n = 0;
            cantidad = pTamano;
            insertados = 0;
            tabla = new CCelda[cantidad];

            for (n = 0; n < cantidad; n++)
            {
                tabla[n] = new CCelda();
            }
        }

        public int HashFuncion(int pLlave, int pIntento)
        {
            int indice = 0;

            // Linear Probing
            // indice = (pLlave + pIntento) % cantidad;

            // Quadratic Probing
            indice = (pLlave + pIntento * pIntento) % cantidad;

            return indice;
        }


        public void Insertar(int pLlave, string pValor)
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
                    insertados++;

                }
                else
                {
                    // Avanzamos al siguiente intento
                    i++;
                }

            }

            // Verificamos si es necesario para hacer rehash
            if (insertados >= ((double) cantidad*0.7))
            {
                Console.WriteLine("Es necesario hacer rehash, {0} de {1} ocupados", insertados, cantidad);
                ReHash();
            }

        }


        public void Mostrar()
        {
            int n = 0;

            for (n = 0; n < cantidad; n++)
            {
                Console.WriteLine("{0} [{1},{2}]", n, tabla[n].Llave, tabla[n].Valor);
            }
        }


        public int PrimoCercano(int pValor)
        {
            int primo = 0;
            bool divide = false;
            int n = 0;

            while (primo == 0)
            {
                divide = false;
                for (n = 2; n < pValor; n++)
                {
                    if (pValor % n == 0)
                    {
                        divide = true;
                        pValor++;
                        break;
                    }
                }

                if (divide == false)
                {
                    primo = pValor;
                }

            }

            return primo;

        }

        public void ReHash()
        {
            // Calculamos el nuevo tamano
            int nCantidad = PrimoCercano(cantidad*2);
            int cantAnterior = cantidad;
            int n = 0;
            int llave = 0;
            string valor = "";

            int i = 0;
            int indice = 0;
            bool ocupado = false;

            Console.WriteLine("Ahora la tabla sera de {0} espacios", nCantidad);

            // Creamos la nueva tabla
            CCelda[] temp = new CCelda[nCantidad];

            for (n = 0; n < nCantidad; n++)
            {
                temp[n] = new CCelda();
            }

            // Actualizamos cantida para que la funcion de hash funcione bien

            cantidad = nCantidad;

            // Recorremos la tabla y vamos insertando en la nueva

            for (n = 0; n < cantAnterior; n++)
            {
                // Verificamos si hay un elemento a insertar
                if (tabla[n].MiEstado == Estado.ocupado)
                {
                    llave = tabla[n].Llave;
                    valor = tabla[n].Valor;

                    ocupado = false;

                    // Hacemos la insercion
                    while (ocupado == false)
                    {
                        // Calculamos el indice
                        indice = HashFuncion(llave, i);

                        // Verificamos si esta vacia la celda
                        if (temp[indice].MiEstado == Estado.vacio)
                        {
                            ocupado = true;
                            temp[indice].Llave = llave;
                            temp[indice].Valor = valor;
                            temp[indice].MiEstado = Estado.ocupado;
                            insertados++;
                        }
                        else
                        {
                            // Avanzamos al siguiente intento
                            i++;
                        }
                    } 
                }

            }

            // Usamos el metodo Clone

            tabla = (CCelda[])temp.Clone();
            //Console.WriteLine("Reference Equals:{0}", Object.ReferenceEquals(tabla, temp));
        }




    }
}
