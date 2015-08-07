using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Exemplo2
{
    public class FabricaFiat : AbstractFabricaDeCarro
    {
        public override AbstractCarro CriarCarro()
        {
            return new CarroFiat();
        }
    }
}
