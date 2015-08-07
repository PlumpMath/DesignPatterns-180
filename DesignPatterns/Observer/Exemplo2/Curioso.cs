using System;

namespace Observer.Exemplo2
{
    public class Curioso : Espectador
    {
        public void Atualizar(string atualizacao)
        {
            Console.WriteLine("Curioso viu " + atualizacao);
        }
    }
}