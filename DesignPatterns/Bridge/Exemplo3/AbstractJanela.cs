namespace Bridge.Exemplo3
{
    public abstract class AbstractJanela
    {
        private IBridgeJanela Janela;

        public AbstractJanela(IBridgeJanela janela)
        {
            Janela = janela;
        }

        public void DesenharJanela(string titulo)
        {
            Janela.DesenharJanela(titulo);
        }

        public void DesenharBotao(string titulo)
        {
            Janela.DesenharBotao(titulo);
        }

        public abstract void Show();
    }
}