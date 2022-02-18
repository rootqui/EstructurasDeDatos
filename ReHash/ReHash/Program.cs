using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ReHash
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable miTabla = new HashTable(11);

            miTabla.Insertar(23, "Hola");
            miTabla.Insertar(51, "Manzana");
            miTabla.Insertar(40, "Pera");
            miTabla.Insertar(62, "Mango");
            miTabla.Insertar(32, "Prueba");
            miTabla.Insertar(11, "de");
            miTabla.Insertar(21, "rehash");

            miTabla.Mostrar();

            miTabla.Insertar(4, "en C#");

            miTabla.Mostrar();

            // Clone
            // c-sharpcorner.com/article/cloning-objects-in-net-framework/


            //String[] msg1 = { "H", "o", "la" };
            //String[] msg2 = (String[])msg1.Clone();

            //Console.WriteLine("String msg1: {0}", msg1[2]);
            //Console.WriteLine("Clone String msg2: {0}", msg2[2]);
            //Console.WriteLine("Reference Equals:{0}", Object.ReferenceEquals(msg1, msg2));

            //string msg1 = "Hola";
            //string msg2 = (string )msg1.Clone();

            //msg1 = "HHHHHHHHHHHHH";

            //Console.WriteLine("String msg1: {0}", msg1);
            //Console.WriteLine("Clone String msg2: {0}", msg2);
            //Console.WriteLine("Reference Equals:{0}", Object.ReferenceEquals(msg1, msg2));
            //Console.WriteLine("Equals:{0}", Object.Equals(msg1, msg2));





            Console.ReadLine();

        }

    }
}
