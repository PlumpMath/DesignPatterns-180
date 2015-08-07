using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Exemplo1
{
    public class ConcreteBuilder : AbstractBuilder
    {
        public override void BuildName()
        {
            _object.Nome = "Builded name";
        }

        public override void BuildDescription()
        {
            _object.Description = "Builded description";
        }
    }
}
