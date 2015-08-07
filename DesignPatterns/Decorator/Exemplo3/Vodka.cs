namespace Decorator.Exemplo3
{
    public class Vodka : ICoquetel
    {
        private string nome;
        private double preco;

        public string Nome
        {
            get { return nome; }
        }

        public double Preco
        {
            get { return preco; }
        }

        public Vodka()
        {
            this.nome = "Vodka";
            this.preco = 8;
        }
    }
}