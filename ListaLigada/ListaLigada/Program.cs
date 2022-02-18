using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ListaLigada
{
    class Program
    {
        static void Main(string[] args)
        {

            CListaLigada miLista = new CListaLigada();

            miLista.Adicionar(3);
            miLista.Adicionar(5);
            miLista.Adicionar(7);
            miLista.Adicionar(9);
            miLista.Adicionar(11);
            miLista.Adicionar(15);

            miLista.Transversa();

            Console.WriteLine(miLista[3]);

            miLista[3] = 55;

            miLista.Transversa();

            //miLista.Transversa();

            //miLista.InsertarInicio(4);

            //miLista.Transversa();

            //Console.WriteLine(miLista.ObtenerPorIndice(5));

            //miLista.Transversa();

            //miLista.Insertar(151, 20);

            //miLista.Transversa();



            //miLista.Transversa();

            //miLista.Borrar(15);

            //miLista.Transversa();



            //Console.WriteLine(miLista.BuscarIndice(3));
            //Console.WriteLine(miLista.BuscarIndice(7));
            //Console.WriteLine(miLista.BuscarIndice(11));
            //Console.WriteLine(miLista.BuscarIndice(52));

            //Console.WriteLine(miLista.BuscarAnterior(31));


            //miLista.Transversa();
            //Console.WriteLine(miLista.EstaVacio());

            ////Console.WriteLine(miLista.Ancla.Siguiente);

            //miLista.Vaciar();

            //miLista.Transversa();
            //Console.WriteLine(miLista.EstaVacio());

            //CNodo e = miLista.Buscar(12);

            //Console.WriteLine(e);

            Console.ReadLine();

        }
    }
}









//String a = "+---+---+\n"     
//         + "| {0} | o----->\n"
//         + "+---+---+";

//String res = string.Format(a, 1);
//String res2 = string.Format(a, 2);

//Console.WriteLine(res +  res2);
