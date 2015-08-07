using System;

namespace State.Exemplo2
{
    public class Mario
    {
        private IMarioState _estado;

        public Mario()
        {
            _estado = new MarioGrande();
        }

        public void PegaPena()
        {
            Console.WriteLine(_estado.GetType() + " pegou pena");
            _estado = _estado.PegaPena();
        }

        public void PegaFlor()
        {
            Console.WriteLine(_estado.GetType() + " pegou flor");
            _estado = _estado.PegaFlor();
        }

        public void PegaCogumelo()
        {
            Console.WriteLine(_estado.GetType() + " pegou cogumelo");
            _estado = _estado.PegaCogumelo();
        }

        public void LevaDano()
        {
            Console.WriteLine(_estado.GetType() + " levou dano");
            _estado = _estado.LevaDano();
        }

        public void PegaEstrela()
        {
            Console.WriteLine(_estado.GetType() + " pegou estrela");
            _estado = _estado.PegaEstrela();
        }
    }
}