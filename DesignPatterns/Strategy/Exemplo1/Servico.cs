namespace Strategy.Exemplo1
{
    public class Servico
    {
        IRepositorio repositorio;

        public Servico(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public void InserirDados(string dados)
        {
            repositorio.InserirDados(dados);
        }

        public void AlterarDados(string dados)
        {
            repositorio.AlterarDados(dados);
        }

        public string ListarDados()
        {
            return repositorio.ListarDados();
        }
    }
}