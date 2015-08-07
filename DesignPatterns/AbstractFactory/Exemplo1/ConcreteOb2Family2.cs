using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Exemplo1
{
    public class ConcreteOb2Family2 : AbstractFamily2
    {
        public override void Details()
        {
            Console.WriteLine("Concrete Object 2 from the family 2");
        }
    }
}
