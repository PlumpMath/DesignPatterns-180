using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interpreter.Exemplo1;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            EX1();

            Console.ReadKey();
        }

        #region EX1

        public static void EX1()
        {
            Variavel A = new Variavel("A");
            Variavel B = new Variavel("B");
            Variavel C = new Variavel("C");

            AbstractExpression soma = new SomarExpression(A, new SomarExpression(B, C));

            Contexto contexto = new Contexto();

            contexto.Assign(A, 5);
            contexto.Assign(B, 15);
            contexto.Assign(C, 5);

            Console.WriteLine(soma.Interpret(contexto));

        }

        #endregion
    }
}
