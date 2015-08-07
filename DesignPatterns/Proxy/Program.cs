using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            EX1();

            Console.ReadKey();
        }

        #region Exemplo 1

        public static void EX1()
        {
            Exemplo1.Proxy proxy = new Exemplo1.Proxy();
            proxy.Operation();
        }

        #endregion Exemplo 1
    }
}