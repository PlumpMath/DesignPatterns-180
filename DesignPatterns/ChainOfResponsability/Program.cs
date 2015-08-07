using ChainOfResponsability.Exemplo1;
using System;

namespace ChainOfResponsability
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            EX2();
            Console.ReadKey();
        }

        #region EX1

        public static void EX1()
        {
            LeitorAlien leitorAlien = new LeitorAlien();
            leitorAlien.AddCorrente(new LeitorImpinj());
            leitorAlien.AddCorrente(new LeitorMotorola());

            leitorAlien.Ler();
        }

        #endregion EX1

        #region EX2

        public static void EX2()
        {
            ChainOfResponsability.Exemplo2.ControladorLeitor controlador = new Exemplo2.ControladorLeitor();

            controlador.AddCorrente(new ChainOfResponsability.Exemplo2.LeitorAlien());
            controlador.AddCorrente(new ChainOfResponsability.Exemplo2.LeitorImpinj());
            controlador.AddCorrente(new ChainOfResponsability.Exemplo2.LeitorMotorola());

            controlador.Ler();
        }

        #endregion 
    }
}