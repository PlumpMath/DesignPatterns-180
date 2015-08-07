using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Exemplo1
{
    public class ConcreteOb2Family1 : AbstractFamily1
    {
        public override void Details()
        {
            Console.WriteLine("Concrete Object 2 from the family 1");
        }
    }
}
