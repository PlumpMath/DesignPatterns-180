using System;

namespace State.Exemplo1
{
    public class Objeto
    {
        public IComportamento _estado;

        public Objeto()
        {
            _estado = new Estado1();
        }

        public Objeto(IComportamento estadoInicial)
        {
            _estado = estadoInicial;
        }

        public void MudaComportamento()
        {
            _estado = _estado.MudaComportamento();
            Console.WriteLine(_estado.GetType() + " mudou de comportamento");
        }
    }
}