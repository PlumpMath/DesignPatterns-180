using System;

namespace Facade.Exemplo2.Pessoa
{
    internal class Pessoa
    {
        Carteira carteira = new Carteira();

        internal void IrPara(string local)
        {
            Console.WriteLine("Indo para " + local + "...");
        }

        internal void AbrirCarteira()
        {
            Console.WriteLine("Abrindo carteira...");
            carteira.Abrir();
        }

        internal void PegarCartao()
        {
            Console.WriteLine("Pegando cartão...");
        }

        internal string PassarCartão()
        {
            Console.WriteLine("Passando cartão...");
            return carteira.MostrarCartao();
        }

        internal void DigitarSenha()
        {
            Console.WriteLine("Digitando senha...");
        }

        internal void RetirarCartao()
        {
            Console.WriteLine("Retirando cartão...");
        }

        internal void GuardarObjeto(string objeto)
        {
            Console.WriteLine("Guardando " + objeto + "...");
        }

        internal void PegarObjeto(string objeto)
        {
            Console.WriteLine("Pegando " + objeto + "...");
        }

        internal void FecharCarteira()
        {
            Console.WriteLine("Fechando carteira...");
            carteira.Fechar();
        }
    }
}