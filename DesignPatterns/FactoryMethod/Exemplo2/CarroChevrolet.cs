using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod.Exemplo2
{
    public class CarroChevrolet : AbstractCarro
    {
        public override void Detalhes()
        {
            Console.WriteLine("Carro da Chevrolet");
        }
    }
}
