using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prototype.Exemplo1;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            EX1();

            Console.ReadKey();
        }

        #region EX1

        public static void EX1()
        {
            CarroPrototype prototype = new FiatPrototype();
            prototype.ViewInfo();

            CarroPrototype carroAntigo = prototype.Clonar();
            carroAntigo.Ano = "2005";
            carroAntigo.ValorCompra = 10000;
            carroAntigo.ViewInfo();

            prototype = new FordPrototype();
            prototype.ViewInfo();

            carroAntigo = prototype.Clonar();
            carroAntigo.Ano = "2005";
            carroAntigo.ValorCompra = 9000;
            carroAntigo.ViewInfo();

        }

        #endregion
    }
}
