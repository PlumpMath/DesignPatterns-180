namespace Decorator.Exemplo2
{
    class PessoaTriste : IPessoa
    {
        IPessoa P { get; set; }

        public string Caracteristicas()
        {
            return " É Triste " + P.Caracteristicas();
        }

        public PessoaTriste(IPessoa pessoa)
        {
            P = pessoa;
        }
    }
}