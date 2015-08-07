using System;
using System.Collections.Generic;

namespace Observer.Exemplo2
{
    public class CenaDoCrime
    {
        public List<Espectador> espectadores { get; set; }

        public void AddEspectador(Espectador espectador)
        {
            espectadores.Add(espectador);
        }

        public void RemoveEspectador(Espectador espectador)
        {
            espectadores.Remove(espectador);
        }

        public void NotificarEspectadores(string ocorrencia)
        {
            foreach (Espectador espectador in espectadores)
            {
                espectador.Atualizar(ocorrencia + " ás " + DateTime.Now.ToString());
            }
        }

        public CenaDoCrime()
        {
            espectadores = new List<Espectador>();
        }
    }
}