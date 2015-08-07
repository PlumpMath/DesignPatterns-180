using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator.Exemplo1
{
    public class ConcreteColleague2 : AbstractColleague
    {
        private string _actuallyMessage;

        public ConcreteColleague2(Mediator mediator):base(mediator){}

        public override void Receive(string message)
        {
            _actuallyMessage = message;
            PrintActuallyMessage();
            Console.WriteLine("<< Message received by Participant 2 >>"); 
        }

        public void PrintActuallyMessage()
        {
            Console.WriteLine(_actuallyMessage);
        }
    }
}
