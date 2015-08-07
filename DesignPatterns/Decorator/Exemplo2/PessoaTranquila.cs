namespace Decorator.Exemplo2
{
    internal class PessoaTranquila : IPessoa
    {
        private IPessoa P { get; set; }

        public string Caracteristicas()
        {
            return " É Tranquila " + P.Caracteristicas();
        }

        public PessoaTranquila(IPessoa pessoa)
        {
            P = pessoa;
        }
    }
}