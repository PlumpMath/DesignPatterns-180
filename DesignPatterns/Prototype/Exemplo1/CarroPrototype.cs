using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype.Exemplo1
{
    public abstract class CarroPrototype
    {
        public string Nome { get; set; }
        public double ValorCompra { get; set; }
        public string Ano { get; set; }

        public abstract CarroPrototype Clonar();

        public void ViewInfo()
        {
            Console.WriteLine("{0} - {1} : {2}", Ano, Nome, ValorCompra);
        }

    }
}
