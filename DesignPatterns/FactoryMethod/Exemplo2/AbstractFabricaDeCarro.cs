using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Exemplo2
{
    public abstract class AbstractFabricaDeCarro
    {
        public abstract AbstractCarro CriarCarro();
    }
}
