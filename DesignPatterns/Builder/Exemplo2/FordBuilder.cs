using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Exemplo2
{
    /// <summary>
    /// Builder concreto
    /// </summary>
    public class FordBuilder : AbstractBuilderCarro
    {
        public override void BuildNome()
        {
            _carro.Nome = "Ford";
        }

        public override void BuildModelo()
        {
            _carro.Modelo = "Fiesta";
        }

        public override void BuildMotor()
        {
            _carro.Motor = "Flex 1.4";
        }
    }
}
