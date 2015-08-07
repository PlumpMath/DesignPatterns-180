using System;

namespace Observer.Exemplo1
{
    public class ObservadorConcreto : Observer
    {
        private string nome;

        public void Update(string estado)
        {
            Console.WriteLine(nome + " recebeu atualização " + estado);
        }

        public ObservadorConcreto(string nome)
        {
            this.nome = nome;
        }
    }
}