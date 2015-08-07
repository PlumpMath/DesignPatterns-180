namespace Command.Exemplo1
{
    public class Invocador
    {
        private Comando _comando;

        public Invocador(Comando comando)
        {
            _comando = comando;
        }

        public void Action()
        {
            _comando.Executar();
        }
    }
}