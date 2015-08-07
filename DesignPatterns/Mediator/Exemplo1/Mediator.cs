using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator.Exemplo1
{
    public class Mediator
    {
        private List<AbstractColleague> _participants;

        public Mediator()
        {
            _participants = new List<AbstractColleague>();
        }

        public void SendMessage(string message, AbstractColleague sender)
        {
            for (int i = 0; i < _participants.Count; i++)
            {
                if(sender != _participants[i])
                    _participants[i].Receive(message);
            }
        }

        public void AddParticipant(AbstractColleague participant)
        {
            _participants.Add(participant);
        }
    }
}
