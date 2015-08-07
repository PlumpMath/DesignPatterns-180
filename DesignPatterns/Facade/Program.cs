using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            //EX1();

            EX2();

            Console.ReadKey();
        }

        #region Exemplo 1

        public static void EX1()
        {
            Facade.Exemplo1.Facade.Operation();
        }

        #endregion Exemplo 1
        #region Exemplo 2

        public static void EX2()
        {
            Facade.Exemplo2.HomemFacade.SacarDinheiro(250);
        }

        #endregion Exemplo 2
    }
}