namespace State.Exemplo2
{
    public class MarioPequeno : IMarioState
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
            return new MarioGrande();
        }

        public IMarioState LevaDano()
        {
            return null;
        }

        public IMarioState PegaEstrela()
        {
            return new MarioComEstrela();
        }
    }
}