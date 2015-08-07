using System;

namespace Flyweight.Exemplo1
{
    public class Imagem
    {
        private string Nome { get; set; }

        public Imagem(string nome)
        {
            Nome = nome;
        }

        public void DesenharImagem()
        {
            Console.WriteLine("desenho de {0}", Nome);
        }
    }
}