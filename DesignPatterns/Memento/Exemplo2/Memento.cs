using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento.Exemplo2
{
    public class Memento
    {
        private string _texto;

        public Memento(string texto)
        {
            _texto = texto;
        }

        public string GetEstado()
        {
            return _texto;
        }

    }
}
