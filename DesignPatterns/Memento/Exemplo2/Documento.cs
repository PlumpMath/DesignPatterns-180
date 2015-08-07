using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento.Exemplo2
{
    public class Documento
    {
        public string Estado { get; set; }

        public Memento SalvarMemento()
        {
            return new Memento(Estado);
        }

        public void RecuperarMemento(Memento estado)
        {
            Estado = estado.GetEstado();
        }
    }
}
