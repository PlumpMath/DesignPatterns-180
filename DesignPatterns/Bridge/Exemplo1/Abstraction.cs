namespace Bridge.Exemplo1
{
    public class Abstraction
    {
        public IBridge Bridge;

        public Abstraction(IBridge bridge)
        {
            Bridge = bridge;
        }

        public void Operacao()
        {
            Bridge.Operation();
        }
    }
}