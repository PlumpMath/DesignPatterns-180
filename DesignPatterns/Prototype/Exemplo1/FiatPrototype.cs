using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.Exemplo1
{
    public class FiatPrototype : CarroPrototype
    {
        protected FiatPrototype(FiatPrototype prototype)
        {
            this.Ano = prototype.Ano;
            this.Nome = prototype.Nome;
            this.ValorCompra = prototype.ValorCompra;
        }

        public FiatPrototype()
        {
            this.Ano = "2014";
            this.Nome = "Palio";
            this.ValorCompra = 32000;
        }

        public override CarroPrototype Clonar()
        {
            return new FiatPrototype(this);
        }
    }
}
