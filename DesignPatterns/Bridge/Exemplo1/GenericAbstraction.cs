namespace Bridge.Exemplo1
{
    public class GenericAbstraction<T> where T : IBridge, new()
    {
        public void Operacao()
        {
            new T().Operation();
        }
    }
}