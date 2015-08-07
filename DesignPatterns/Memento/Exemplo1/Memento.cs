using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento.Exemplo1
{
    public class Memento
    {
        private object _state;

        public Memento(object state)
        {
            this._state = state;
        }

        public object GetState()
        {
            return _state;
        }
    }
}
