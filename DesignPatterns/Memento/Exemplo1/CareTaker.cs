using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento.Exemplo1
{
    public class CareTaker
    {
        private Stack<Memento> _history;

        public CareTaker()
        {
            _history = new Stack<Memento>();
        }

        public void AddStep(Memento memento)
        {
            _history.Push(memento);
        }

        public Memento GetLastStep()
        {
            return _history.Pop();
        }
    }
}
