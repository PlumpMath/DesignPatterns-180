namespace Decorator.Exemplo3
{
    public class Acucar : CoquetelDecorator
    {
        public Acucar(ICoquetel coquetel)
            : base(coquetel)
        {
            Nome = "Açucar";
            Preco = 0.50;
        }
    }
}