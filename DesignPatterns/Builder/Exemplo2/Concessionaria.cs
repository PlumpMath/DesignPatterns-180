using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Exemplo2
{
    /// <summary>
    /// Director
    /// </summary>
    public class Concessionaria
    {
        private AbstractBuilderCarro _builder;

        public Concessionaria(AbstractBuilderCarro builder)
        {
            _builder = builder;
        }

        public void BuildCarro()
        {
            _builder.BuildNome();
            _builder.BuildModelo();
            _builder.BuildMotor();
        }

        public Carro GetCarro()
        {
            return _builder.GetCarro();
        }

    }
}
