namespace State.Exemplo2
{
    internal class MarioComFlor : IMarioState
    {
        public IMarioState PegaPena()
        {
            return new MarioComCapa();
        }

        public IMarioState PegaFlor()
        {
            return this;
        }

        public IMarioState PegaCogumelo()
        {
            return this;
        }

        public IMarioState LevaDano()
        {
            return new MarioGrande();
        }

        public IMarioState PegaEstrela()
        {
            return new MarioComEstrela();
        }
    }
}