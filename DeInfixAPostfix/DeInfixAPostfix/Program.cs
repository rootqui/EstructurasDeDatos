using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeInfixAPostfix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Equivale a 567*+89*

            string exp = "5+6*7-8*9";

            string res = "";
            int n = 0;

            CStack s = new CStack();

            // Recorremos caracter por caracter
            for (n = 0; n < exp.Length; n++)
            {
                // verificamos que sea un operando
                if (exp[n] >= '0' && exp[n] <= '9')
                {
                    // lo adicionamos al resultado
                    res += exp[n];
                }

                // Entonces es un operador
                else
                {
                    while (!s.EstaVacio() && MayorPrecedencia(s.Peek(),exp[n]))
                    {
                        res += s.Pop();
                    }

                    s.Push(exp[n]);

                }
                
            }


            while (!s.EstaVacio())
            {
                // res += s.Peek();
                // s.Pop();
                res += s.Pop();
            }

            Console.WriteLine("{0} en postfix es {1}", exp,res);

            Console.ReadLine();

            
        }


        // Ojo, es para demostrar como actuar ante diferentes precedencias
        // pero algunos de estos operadores tienen la misma precedencia

        public static bool MayorPrecedencia(char a, char b)
        {
            bool resultado = false;

            // es *
            if (a == '*')
            {
                resultado = true;
            }

            // es / 
            if (a == '/')
            {
                if (b == '*')
                {
                    resultado = false;
                }
                else
                {
                    resultado = true;
                }
            }

            // es +
            if (a == '+')
            {
                if (b == '*' || b == '/')
                {
                    resultado = false;
                }
                else
                {
                    resultado = true;
                }
            }

            // es -
            if (a == '-')
            {
                resultado = false;
            }

            return resultado;

        }
    }
}
