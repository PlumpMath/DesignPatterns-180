namespace Decorator.Exemplo3
{
    public class Cachaca : ICoquetel
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

        public Cachaca()
        {
            nome = "Cachaça";
            preco = 2;
        }
    }
}