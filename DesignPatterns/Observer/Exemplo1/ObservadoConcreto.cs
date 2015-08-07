using System;
using System.Collections.Generic;

namespace Observer.Exemplo1
{
    public class ObservadoConcreto : Subject
    {
        public List<Observer> observadores { get; set; }

        public void AddObservador(Observer observador)
        {
            observadores.Add(observador);
        }

        public void RemoveObservador(Observer observador)
        {
            observadores.Remove(observador);
        }

        public void NotificarObservadores()
        {
            foreach (Observer observador in observadores)
            {
                observador.Update(DateTime.Now.ToString());
            }
        }

        public ObservadoConcreto()
        {
            observadores = new List<Observer>();
        }
    }
}