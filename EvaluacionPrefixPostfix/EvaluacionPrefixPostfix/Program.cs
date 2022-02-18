using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionPrefixPostfix
{
    class Program
    {
        static void Main(string[] args)
        {

            CStack miStack = new CStack();
            // recorrer 
            int n = 0;

            // operando
            int a = 0;
            int b = 0;

            //resultado
            int r = 0;

            string expresion;
            char caracter;

            #region Postfix

            // Evaluamos Postfix
            expresion = "352*+73*-";
            caracter = ' ';

            for (n = 0; n < expresion.Length; n++)
            {
                // Obtenemos si es numero
                caracter = expresion[n];

                // Verficamos si es numero
                if (caracter >= '0' && caracter <= '9')
                {
                    miStack.Push(Convert.ToInt32(caracter.ToString()));
                }
                else // es operador
                {
                    // hacemos dos pop
                    // postfix b -> a
                    b = miStack.Pop();
                    a = miStack.Pop();

                    // Verificamos que operador es  y aplicamos la operacion
                    if (caracter == '+')
                    {
                        r = a + b;
                        miStack.Push(r);
                    }
                    if (caracter == '-')
                    {
                        r = a - b;
                        miStack.Push(r);
                    }
                    if (caracter == '/')
                    {
                        r = a / b;
                        miStack.Push(r);
                    }
                    if (caracter == '*')
                    {
                        r = a * b;
                        miStack.Push(r);
                    }


                }

            }

            miStack.Transversa();
            #endregion

            //CStack miStack2 = new CStack();

            // Elimino los elementos de miStack

            miStack.Pop();

            // Evaluamos Prefix
            expresion = "-+3*52*73";
            caracter = ' ';

            for (n = expresion.Length - 1; n >= 0; n--)
            {
                // Obtenemos si es numero
                caracter = expresion[n];

                // Verficamos si es numero
                if (caracter >= '0' && caracter <= '9')
                {
                    // Se inserta en el stack
                    miStack.Push(Convert.ToInt32(caracter.ToString()));
                }
                else // es operador
                {
                    // hacemos dos pop
                    // prefix a -> b
                    a = miStack.Pop();
                    b = miStack.Pop();

                    // Verificamos que operador es  y aplicamos la operacion
                    if (caracter == '+')
                    {
                        r = a + b;
                        miStack.Push(r);
                    }
                    if (caracter == '-')
                    {
                        r = a - b;
                        miStack.Push(r);
                    }
                    if (caracter == '/')
                    {
                        r = a / b;
                        miStack.Push(r);
                    }
                    if (caracter == '*')
                    {
                        r = a * b;
                        miStack.Push(r);
                    }


                }

            }

            miStack.Transversa();

            Console.ReadLine();

        }
    }
}

