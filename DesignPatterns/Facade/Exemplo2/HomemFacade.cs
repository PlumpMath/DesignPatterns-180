namespace Facade.Exemplo2
{
    public static class HomemFacade
    {
        private static Facade.Exemplo2.Pessoa.Pessoa pessoa = new Facade.Exemplo2.Pessoa.Pessoa();
        private static Facade.Exemplo2.Banco.CaixaEletronico caixa = new Facade.Exemplo2.Banco.CaixaEletronico();

        public static void SacarDinheiro(double valor)
        {
            pessoa.IrPara("Banco");

            pessoa.AbrirCarteira();
            pessoa.PegarCartao();

            caixa.IniciarSessao(pessoa.PassarCartão());

            pessoa.DigitarSenha();
            pessoa.RetirarCartao();

            caixa.SacarDinheiro(valor);

            pessoa.PassarCartão();
            pessoa.RetirarCartao();
            pessoa.GuardarObjeto("cartão");

            pessoa.PegarObjeto("dinheiro");

            pessoa.GuardarObjeto("dinheiro");

            pessoa.FecharCarteira();

            caixa.TerminarSessao();

            pessoa.IrPara("casa");
        }
    }
}