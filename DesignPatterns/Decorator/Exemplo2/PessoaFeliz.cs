namespace Decorator.Exemplo2
{
    class PessoaFeliz : IPessoa
    {
        IPessoa P { get; set; }

        public string Caracteristicas()
        {
            return " É Feliz " + P.Caracteristicas();
        }

        public PessoaFeliz(IPessoa pessoa)
        {
            P = pessoa;
        }
    }
}