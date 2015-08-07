namespace Decorator.Exemplo3
{
    public class Refrigerante : CoquetelDecorator
    {
        public Refrigerante(ICoquetel coquetel)
            : base(coquetel)
        {
            Nome = "Refrigerante";
            Preco = 1;
        }
    }
}