using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Exemplo2
{
    public class FiatFactory : AbstractFabricaDeCarro
    {
        public override AbstractCarroPopular CriarCarroPopular()
        {
            return new Palio();
        }

        public override AbstractCarroSedan CriarCarroSedan()
        {
            return new Siena();
        }
    }
}
