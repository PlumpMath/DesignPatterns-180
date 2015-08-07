using System;

namespace Observer.Exemplo2
{
    public class Fotografo : Espectador
    {
        public void Atualizar(string atualizacao)
        {
            Console.WriteLine("Fotógrafo fotografou " + atualizacao);
        }
    }
}