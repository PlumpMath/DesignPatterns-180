using System;

namespace Strategy.Exemplo1
{
    public class RepositorioMSSQL : IRepositorio
    {
        public void InserirDados(string dados)
        {
            Console.WriteLine("Dados inseridos pelo SQL Server.\n{0}", dados);
        }

        public void AlterarDados(string dados)
        {
            Console.WriteLine("Dados alterados pelo SQL Server.\n{0}", dados);
        }

        public string ListarDados()
        {
            return "Dados listados pelo SQL Server.";
        }
    }
}