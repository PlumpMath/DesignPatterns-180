﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator.Exemplo2
{
    public class Africano : AbstractUsuarioChat
    {

        public Africano(ChatMediator mediator): base(mediator)
        {
            Nome = "Africano";
        }

        public override void EnviarMensagem(string mensagem)
        {
            Console.WriteLine(Nome + ": " + mensagem);
            _mediator.Enviar(mensagem, this);
        }
    }
}
