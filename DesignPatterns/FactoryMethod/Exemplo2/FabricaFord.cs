using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Exemplo2
{
    public class FabricaFord : AbstractFabricaDeCarro
    {
        public override AbstractCarro CriarCarro()
        {
            return new CarroFord();
        }
    }
}
