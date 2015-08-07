using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Exemplo1
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractObject CreateObjet()
        {
            return new ConcreteObject2();
        }
    }
}
