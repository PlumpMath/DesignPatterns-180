using System;

namespace Facade.Exemplo2.Banco
{
    internal class CaixaEletronico
    {
        internal void IniciarSessao(string cartao)
        {
            Console.WriteLine("Sessão iniciada com cartão: " + cartao);
        }

        internal void SacarDinheiro(double valor)
        {
            Console.WriteLine("Sacado " + valor);
        }

        internal void TerminarSessao()
        {
            Console.WriteLine("Sessão finalizada.");
        }
    }
}