using System;
using Strategy.Exemplo1;

namespace Strategy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //EX1();

            Console.ReadKey();
        }

        #region Exemplo1

        public static void EX1()
        {
            Servico servicoDeDados = new Servico(new RepositorioMSSQL());
            servicoDeDados.InserirDados("Guilherme, 23/08/1992");

            servicoDeDados = new Servico(new RepositorioMySQL());
            servicoDeDados.InserirDados("Guilherme, 23/08/1992");
        }

        #endregion Exemplo1
    }
}