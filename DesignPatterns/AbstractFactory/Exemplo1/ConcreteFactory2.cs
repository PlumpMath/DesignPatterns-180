using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Exemplo1
{
    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractFamily1 CreateObjetFamily1()
        {
            return new ConcreteOb2Family1();
        }

        public override AbstractFamily2 CreateObjetFamily2()
        {
            return new ConcreteOb2Family2();
        }
    }
}
