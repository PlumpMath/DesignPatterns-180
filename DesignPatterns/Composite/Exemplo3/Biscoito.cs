namespace Composite.Exemplo3
{
    public class Biscoito : IConteudo
    {
        public string Nome
        {
            get;
            set;
        }

        public Biscoito(string nome)
        {
            this.Nome = nome;
        }
    }
}