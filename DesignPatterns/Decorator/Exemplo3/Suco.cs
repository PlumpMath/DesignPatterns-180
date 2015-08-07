namespace Decorator.Exemplo3
{
    public class Suco : CoquetelDecorator
    {
        public Suco(ICoquetel coquetel)
            : base(coquetel)
        {
            Nome = "Suco";
            Preco = 1;
        }
    }
}