namespace Bridge.Exemplo2
{
    class Calculadora
    {
        private ICalculadora instancia;

        public Calculadora(ICalculadora calculadora)
        {
            instancia = calculadora;
        }

        public double PI
        {
            get { return instancia.PI; }
        }
    }
}