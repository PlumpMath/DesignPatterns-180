using System;

namespace Composite.Exemplo2
{
    public class Arquivo : IArquivo
    {
        public int Nivel
        {
            get;
            set;
        }

        public string Nome
        {
            get;
            set;
        }

        public void Imprimir()
        {
            string tabs = "";

            for (int i = 0; i < Nivel; i++)
                tabs += "  ";

            Console.WriteLine(tabs + "-" + Nome);
        }

        public Arquivo(string nome)
        {
            Nome = nome;
        }

        public Arquivo()
        {
        }
    }
}