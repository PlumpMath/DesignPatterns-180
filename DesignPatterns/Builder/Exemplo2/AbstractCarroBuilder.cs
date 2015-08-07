using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Exemplo2
{
    /// <summary>
    /// Builder abstrato
    /// </summary>
    public abstract class AbstractBuilderCarro
    {
        protected Carro _carro;

        public AbstractBuilderCarro()
        {
            _carro = new Carro();
        }

        public abstract void BuildNome();
        public abstract void BuildModelo();
        public abstract void BuildMotor();

        public Carro GetCarro()
        {
            return _carro;
        }
    }
}
