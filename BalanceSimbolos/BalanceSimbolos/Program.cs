using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceSimbolos
{
    class Program
    {
        static void Main(string[] args)
        {
            string expresion = " ";
            char s = ' ';

            CStack pila = new CStack();

            // Pedimos a la expresion a evaluar
            Console.WriteLine("Ingrese la expresion a evaluar:");
            expresion = Console.ReadLine();

            foreach (char c in expresion)
            {
                // Verificamos que sea el simbolo de apertura
                if (c == '(' || c == '{' || c == '[')
                {
                    // Lo colocamos en el stack
                    pila.Push(c);
                }

                // Verificamos el simbolo de cierre
                if(c == ')' || c == '}' || c == ']')
                {
                    if (pila.StackVacio())
                    {
                        Console.WriteLine("Exceso de simbolos de cierre.");
                    }
                    else
                    {
                        // Obtenemos el carecter correspondiente
                        s = pila.Pop();

                        // Verificamos que coincidan
                        if ( s == '(' && c != ')')
                        {
                            Console.WriteLine("Se esperaba )");
                        }

                        if (s == '{' && c != '}')
                        {
                            Console.WriteLine("Se esperaba }");
                        }

                        if (s == '[' && c != ']')
                        {
                            Console.WriteLine("Se esperaba ]");
                        }
                    }
                }

            }

            if (pila.StackVacio() == false)
            {
                Console.WriteLine("Exceso de Simbolos de Apertura");
            }

            Console.ReadLine();

        }
    }
}

