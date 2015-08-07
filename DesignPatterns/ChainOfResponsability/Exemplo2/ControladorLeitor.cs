using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Exemplo2
{
    public class ControladorLeitor
    {
        public AbstractLeitor _primeiro;

        public void Ler()
        {
            _primeiro.Ler();
        }

        public void AddCorrente(AbstractLeitor corrente)
        {
            if (_primeiro == null)
                _primeiro = corrente;
                else
            _primeiro.AddCorrente(corrente);
        }
    }
}
