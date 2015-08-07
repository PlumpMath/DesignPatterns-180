using System.Collections.Generic;

namespace Observer.Exemplo1
{
    public interface Subject
    {
        List<Observer> observadores { get; set; }

        void AddObservador(Observer observador);

        void RemoveObservador(Observer observador);

        void NotificarObservadores();
    }
}