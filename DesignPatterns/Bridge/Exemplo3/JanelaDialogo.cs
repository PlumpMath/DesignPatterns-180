namespace Bridge.Exemplo3
{
    public class JanelaDialogo : AbstractJanela
    {
        public JanelaDialogo(IBridgeJanela janela)
            : base(janela)
        {
        }

        public override void Show()
        {
            this.DesenharJanela("Diálogo");
            this.DesenharBotao("OK");
            this.DesenharBotao("NO");
        }
    }
}