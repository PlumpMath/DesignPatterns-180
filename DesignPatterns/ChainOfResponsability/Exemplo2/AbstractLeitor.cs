using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Exemplo2
{
    public abstract class AbstractLeitor
    {
        protected AbstractLeitor _proximo;

        public abstract void Ler();

        public void AddCorrente(AbstractLeitor proximo)
        {
            if (_proximo == null)
                _proximo = proximo;
            else
            {
                _proximo.AddCorrente(proximo);
            }
        }
    }
}
