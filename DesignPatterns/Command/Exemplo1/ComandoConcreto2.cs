using System;

namespace Command.Exemplo1
{
    public class ComandoConcreto2 : Comando
    {
        Receptor _receptor;

        public ComandoConcreto2(Receptor receptor)
        {
            _receptor = receptor;
        }

        public void Executar()
        {
            _receptor.SetEstado();
            Console.WriteLine("Comando 2 sendo executado");
        }
    }
}