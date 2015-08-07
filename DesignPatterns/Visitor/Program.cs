using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Visitor.Exemplo1;

namespace Visitor
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
            Arvore arvore = new Arvore(5);

            arvore.Add(2);
            arvore.Add(7);
            arvore.Add(23);
            arvore.Add(1);
            arvore.Add(15);
            arvore.Add(14);
            arvore.Add(12);
            arvore.Add(12);


            arvore.AceitaVisitante(new ExibirEmOrdemVisitor());
            arvore.AceitaVisitante(new ExibirParesVisitor());
        }

        #endregion
    }
}
