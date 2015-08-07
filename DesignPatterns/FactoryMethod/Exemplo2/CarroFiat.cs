using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Exemplo2
{
    public class CarroFiat : AbstractCarro
    {
        public override void Detalhes()
        {
            Console.WriteLine("Carro da Fiat");
        }
    }
}
