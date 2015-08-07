using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Exemplo2
{
    public class Fiesta : AbstractCarroPopular
    {
        public override void Detalhes()
        {
            Console.WriteLine("Fiesta");
        }
    }
}
