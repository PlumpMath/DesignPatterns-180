using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.Exemplo1
{
    public class ExibirEmOrdemVisitor : IArvoreVisitor
    {
        public void Visitar(No no)
        {
            if (no != null)
            {
                Console.WriteLine(no.Chave);
                this.Visitar(no.Direito);
            }
        }
    }
}
