using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator.Exemplo1
{
    public abstract class AbstractColleague
    {
        protected Mediator _mediator;

        public AbstractColleague(Mediator mediator)
        {
            _mediator = mediator;
        }

        public void Send(string message)
        {
            _mediator.SendMessage("\nSend by " + this + "\n" + message, this);
        }

        public abstract void Receive(string message);
    }
}
