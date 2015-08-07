using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Exemplo1
{
    public abstract class AbstractBuilder
    {
        protected Product _object;

        public AbstractBuilder()
        {
            _object = new Product();
        }


        public abstract void BuildName();
        public abstract void BuildDescription();

        public Product GetObject()
        {
            return _object;
        }
    }
}
