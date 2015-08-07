namespace Strategy.Exemplo1
{
    public interface IRepositorio
    {
        void InserirDados(string dados);

        void AlterarDados(string dados);

        string ListarDados();
    }
}