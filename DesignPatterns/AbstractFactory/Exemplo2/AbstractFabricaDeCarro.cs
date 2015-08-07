using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Exemplo2
{
    public abstract class AbstractFabricaDeCarro 
    {
        public abstract AbstractCarroPopular CriarCarroPopular();

        public abstract AbstractCarroSedan CriarCarroSedan();
    }
}
