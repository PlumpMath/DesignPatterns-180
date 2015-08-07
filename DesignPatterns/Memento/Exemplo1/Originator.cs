using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento.Exemplo1
{
    public class Originator
    {
        private object _state;

        public void SetState(object state)
        {
            _state = state;
        }

        public object SaveState()
        {
            return this._state;
        }

        public void RestoreState(Memento memento)
        {
            this._state = memento.GetState();
        }

        public void ShowState()
        {
            Console.WriteLine("STATE: {0}", _state.ToString());
        }
    }
}
