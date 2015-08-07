using System;

namespace Observer.Exemplo2
{
    public class Policial : Espectador
    {
        public void Atualizar(string atualizacao)
        {
            Console.WriteLine("Policial estava atento à " + atualizacao);
        }
    }
}