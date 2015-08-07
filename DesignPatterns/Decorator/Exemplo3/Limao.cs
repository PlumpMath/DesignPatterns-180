namespace Decorator.Exemplo3
{
    public class Limao : CoquetelDecorator
    {
        public Limao(ICoquetel coquetel)
            : base(coquetel)
        {
            Nome = "Limão";
            Preco = 1;
        }
    }
}