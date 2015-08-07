using System;
using System.Collections.Generic;

namespace Composite.Exemplo2
{
    public class Pasta : IArquivo
    {
        public List<IArquivo> Arquivos { get; set; }
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

        public void Adicionar(IArquivo arquivo)
        {
            arquivo.Nivel = Nivel + 1;
            Arquivos.Add(arquivo);
        }

        public void Imprimir()
        {
            string tabs = "";

            for (int i = 0; i < Nivel; i++)
                tabs += "  ";

            Console.WriteLine(tabs + "-" + Nome);

            for (int i = 0; i < Arquivos.Count; i++)
            {
                Arquivos[i].Imprimir();
            }
        }

        public Pasta(string nome)
        {
            Nome = nome;
            Arquivos = new List<IArquivo>();
        }

        public Pasta()
        {
        }
    }
}