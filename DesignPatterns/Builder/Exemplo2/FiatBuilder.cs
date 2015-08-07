using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder.Exemplo2
{
    /// <summary>
    /// Builder concreto
    /// </summary>
    public class FiatBuilder : AbstractBuilderCarro
    {
        public override void BuildNome()
        {
            this._carro.Nome = "Fiat";
        }

        public override void BuildModelo()
        {
            this._carro.Modelo = "Palio";
        }

        public override void BuildMotor()
        {
            this._carro.Motor = "Fire Flex 1.0";
        }
    }
}
