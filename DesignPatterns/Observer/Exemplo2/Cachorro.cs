using System;

namespace Observer.Exemplo2
{
    public class Cachorro : Espectador
    {
        public void Atualizar(string atualizacao)
        {
            Console.WriteLine("Cachorro latiu para " + atualizacao);
        }
    }
}