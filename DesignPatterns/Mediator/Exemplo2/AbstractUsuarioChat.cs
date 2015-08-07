using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator.Exemplo2
{
    public abstract class AbstractUsuarioChat
    {
        public ChatMediator _mediator;
        public string Nome;

        public AbstractUsuarioChat(ChatMediator mediator)
        {
            _mediator = mediator;
        }

        public abstract void EnviarMensagem(string mensagem);

        public void RecebeMensagem(string mensagem)
        {
            Console.WriteLine(Nome + " recebeu: " + mensagem);
        }
    }
}
