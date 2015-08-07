namespace State.Exemplo2
{
    public class MarioComCapa : IMarioState
    {
        public IMarioState PegaPena()
        {
            return this;
        }

        public IMarioState PegaFlor()
        {
            return new MarioComFlor();
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