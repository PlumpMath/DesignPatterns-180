using System;

namespace Bridge.Exemplo3
{
    public class JanelaWindows : IBridgeJanela
    {
        public void DesenharJanela(string titulo)
        {
            Console.WriteLine(titulo + " Janela WINDOWS");
        }

        public void DesenharBotao(string titulo)
        {
            Console.WriteLine(titulo + " Botão WINDOWS");
        }
    }
}