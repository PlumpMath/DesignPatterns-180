namespace State.Exemplo2
{
    public class MarioGrande : IMarioState
    {
        public IMarioState PegaPena()
        {
            return new MarioComCapa();
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
            return new MarioPequeno();
        }

        public IMarioState PegaEstrela()
        {
            return new MarioComEstrela();
        }
    }
}