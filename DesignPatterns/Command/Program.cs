using System;
using Command.Exemplo1;

namespace Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            EX1();

            Console.ReadKey();
        }

        #region EX1

        public static void EX1()
        {
            Receptor receptor = new Receptor();
            Invocador invocador = new Invocador(new ComandoConcreto(receptor));

            invocador.Action();

            invocador = new Invocador(new ComandoConcreto2(receptor));
            invocador.Action();
        }

        #endregion EX1
    }
}