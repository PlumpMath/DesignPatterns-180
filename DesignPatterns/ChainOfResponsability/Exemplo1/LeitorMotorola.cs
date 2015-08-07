using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Exemplo1
{
    public class LeitorMotorola : AbstractLeitor
    {
        public override void Ler()
        {
            Console.WriteLine("Leitura realiza pelo Leitor Motorola");

            if (_proximo != null)
                _proximo.Ler();
        }
    }
}
