using System;

namespace Bridge.Exemplo3
{
    public class JanelaLinux : IBridgeJanela
    {
        public void DesenharJanela(string titulo)
        {
            Console.WriteLine(titulo + " Janela LINUX");
        }

        public void DesenharBotao(string titulo)
        {
            Console.WriteLine(titulo + " Botão LINUX");
        }
    }
}