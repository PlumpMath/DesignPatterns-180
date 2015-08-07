using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Exemplo2
{
    public class CarroFord : AbstractCarro
    {
        public override void Detalhes()
        {
            Console.WriteLine("Carro da Ford");
        }
    }
}
