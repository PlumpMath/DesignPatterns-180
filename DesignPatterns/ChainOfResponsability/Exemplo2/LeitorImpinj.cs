using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Exemplo2
{
    public class LeitorImpinj : AbstractLeitor
    {
        public override void Ler()
        {
            Console.WriteLine("Leitura realiza pelo Leitor Impinj");

            if(_proximo != null)
                _proximo.Ler();
        }
    }
}
