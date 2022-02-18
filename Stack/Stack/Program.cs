using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            CStack pila = new CStack();

            pila.Push(5);
            pila.Push(3);
            pila.Push(10);

            pila.Transversa();

            Console.WriteLine(pila.Pop());

            pila.Transversa();

            Console.WriteLine(pila.Peek());
            Console.WriteLine(pila.Peek());
            pila.Transversa();

            Console.ReadLine();

        }
    }
}
