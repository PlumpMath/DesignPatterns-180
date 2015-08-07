using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Singleton.Exemplo1;

namespace Singleton
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
            FabricaDeCarro fabrica = FabricaDeCarro.Instance;

            fabrica.CriaCarroPopular();
            fabrica.CriaCarroPopular();
            fabrica.CriaCarroPopular();

            fabrica.GerarRelatorio();

            fabrica = FabricaDeCarro.Instance;

            fabrica.GerarRelatorio();
        }

        #endregion
    }
}
