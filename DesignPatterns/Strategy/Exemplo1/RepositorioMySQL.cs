using System;

namespace Strategy.Exemplo1
{
    public class RepositorioMySQL : IRepositorio
    {
        public void InserirDados(string dados)
        {
            Console.WriteLine("Dados inseridos pelo MySQL.\n{0}", dados);
        }

        public void AlterarDados(string dados)
        {
            Console.WriteLine("Dados alterados pelo MySQL. \n{0}", dados);
        }

        public string ListarDados()
        {
            return "Dados listados pelo MySQL.";
        }
    }
}