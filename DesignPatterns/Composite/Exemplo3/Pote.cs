using System;

namespace Composite.Exemplo3
{
    public class Pote : IConteudo
    {
        private IConteudo Conteudo { get; set; }

        public string Nome
        {
            get;
            set;
        }

        public void AdicionarConteudo(IConteudo conteudo)
        {
            if (Conteudo == null)
            {
                Conteudo = conteudo;
                Console.WriteLine(conteudo.Nome + " adicionado ao " + Nome);
            }
            else
            {
                Console.WriteLine("O pote está com " + Conteudo.Nome + ".\nEsvazie-o primeiro.");
            }
        }

        public void EsvaziarConteudo()
        {
            if (Conteudo != null)
                Conteudo = null;
            else
                Console.WriteLine("O pote está cheio.\n Esvazie-o primeiro.");
        }

        public Pote(string nome)
        {
            this.Nome = nome;
        }
    }
}