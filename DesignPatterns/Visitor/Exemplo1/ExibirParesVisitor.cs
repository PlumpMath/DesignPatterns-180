using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.Exemplo1
{
    public class ExibirParesVisitor : IArvoreVisitor
    {
        public void Visitar(No no)
        {
            if (no != null)
            {
                if (no.Chave % 2 == 0)
                    Console.WriteLine(no.Chave);

                this.Visitar(no.Direito);
            }
        }
    }
}
