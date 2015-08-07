using System;
using State.Exemplo1;
using State.Exemplo2;

namespace State
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            EX1();
            //EX2();

            Console.ReadKey();
        }

        #region EX1

        public static void EX1()
        {
            Objeto objeto = new Objeto();

            objeto.MudaComportamento();
            objeto.MudaComportamento();
            objeto.MudaComportamento();
            objeto.MudaComportamento();
        }

        #endregion EX1

        #region EX2

        public static void EX2()
        {
            Mario newMario = new Mario();

            newMario.PegaPena();
            newMario.LevaDano();
            newMario.LevaDano();
            newMario.PegaCogumelo();
        }

        #endregion EX2
    }
}