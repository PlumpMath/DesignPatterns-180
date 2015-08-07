using System;

namespace Facade.Exemplo2.Pessoa
{
    internal class Carteira
    {
        internal void Abrir()
        {
            Console.WriteLine("Carteira aberta");
        }

        internal void Fechar()
        {
            Console.WriteLine("Carteira fechada");
        }

        internal string MostrarCartao()
        {
            return "123456";
        }
    }
}