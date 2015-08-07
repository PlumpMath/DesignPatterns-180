using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton.Exemplo1
{
    public class CarroPopular
    {
        public string Nome { get; set; }

        public CarroPopular()
        {
            Nome = "Carro " + DateTime.Now;
        }
    }
}
