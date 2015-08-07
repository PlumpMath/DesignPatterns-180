using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.Exemplo1
{
    public class FordPrototype : CarroPrototype
    {
        protected FordPrototype(FordPrototype prototype)
        {
            this.Ano = prototype.Ano;
            this.Nome = prototype.Nome;
            this.ValorCompra = prototype.ValorCompra;
        }

        public FordPrototype()
        {
            this.Ano = "2014";
            this.Nome = "Fiesta";
            this.ValorCompra = 28000;
        }


        public override CarroPrototype Clonar()
        {
            return new FordPrototype(this);
        }
    }
}
