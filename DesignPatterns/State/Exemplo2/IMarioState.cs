namespace State.Exemplo2
{
    public interface IMarioState
    {
        IMarioState PegaPena();

        IMarioState PegaFlor();

        IMarioState PegaCogumelo();

        IMarioState PegaEstrela();

        IMarioState LevaDano();
    }
}