using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Exemplo1
{
    public abstract class AbstractFactory
    {
        public abstract AbstractFamily1 CreateObjetFamily1();

        public abstract AbstractFamily2 CreateObjetFamily2();
    }
}
