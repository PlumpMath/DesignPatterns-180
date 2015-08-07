namespace Decorator.Exemplo3
{
    public abstract class CoquetelDecorator : ICoquetel
    {
        private ICoquetel Coquetel;
        private string nome;
        private double preco;

        public string Nome
        {
            get
            {
                return Coquetel.Nome + " + " + nome;
            }
            set { nome = value; }
        }

        public double Preco
        {
            get
            {
                return Coquetel.Preco + preco;
            }
            set { preco = value; }
        }

        public CoquetelDecorator(ICoquetel coquetel)
        {
            Coquetel = coquetel;
        }
    }
}