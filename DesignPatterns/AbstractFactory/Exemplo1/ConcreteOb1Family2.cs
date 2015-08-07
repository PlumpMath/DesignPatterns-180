using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Exemplo1
{
    public class ConcreteOb1Family2 : AbstractFamily2
    {
        public override void Details()
        {
            Console.WriteLine("Concrete Object 1 from the family 2");
        }
    }
}
