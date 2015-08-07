using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Exemplo1
{
    public class Director
    {
        private AbstractBuilder _builder;

        public Director(AbstractBuilder builder)
        {
            _builder = builder;
        }

        public void BuildObject()
        {
            _builder.BuildName();
            _builder.BuildDescription();
        }

        public Product GetObject()
        {
            return _builder.GetObject();
        }
    }
}
