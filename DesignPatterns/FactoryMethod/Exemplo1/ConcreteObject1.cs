using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Exemplo1
{
    public class ConcreteObject1 : AbstractObject
    {
        public override void ViewDetails()
        {
            Console.WriteLine("Concrete Object 1");
        }
    }
}
