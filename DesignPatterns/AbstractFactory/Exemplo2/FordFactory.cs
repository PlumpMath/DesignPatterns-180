using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Exemplo2
{
    public class FordFactory : AbstractFabricaDeCarro
    {
        public override AbstractCarroPopular CriarCarroPopular()
        {
            return new Fiesta();
        }

        public override AbstractCarroSedan CriarCarroSedan()
        {
            return new FiestaSedan();
        }
    }
}
