namespace Decorator.Exemplo2
{
    public sealed class Pessoa : IPessoa
    {
        public string Nome
        {
            get;
            set;
        }

        public string Caracteristicas()
        {
            return " ";
        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
    }
}