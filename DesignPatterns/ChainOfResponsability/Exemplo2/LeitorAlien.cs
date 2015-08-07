using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Exemplo2
{
    public class LeitorAlien : AbstractLeitor
    {
        public override void Ler()
        {
            Console.WriteLine("Leitura relizada por Leitor Alien");

            if (_proximo != null)
                _proximo.Ler();
        }
    }
}
