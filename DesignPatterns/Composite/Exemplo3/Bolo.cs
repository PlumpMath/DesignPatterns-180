namespace Composite.Exemplo3
{
    public class Bolo : IConteudo
    {
        public string Nome
        {
            get;
            set;
        }

        public Bolo(string nome)
        {
            this.Nome = nome;
        }
    }
}