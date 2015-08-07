using System;

namespace Command.Exemplo1
{
    public class ComandoConcreto : Comando
    {
        private Receptor _receptor;

        public ComandoConcreto(Receptor receptor)
        {
            _receptor = receptor;
        }

        public void Executar()
        {
            Console.WriteLine("Comando 1 sendo executado");
        }
    }
}