namespace State.Exemplo2
{
    public class MarioComEstrela : IMarioState
    {
        public IMarioState PegaPena()
        {
            return this;
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
            return this;
        }

        public IMarioState PegaEstrela()
        {
            return this;
        }
    }
}