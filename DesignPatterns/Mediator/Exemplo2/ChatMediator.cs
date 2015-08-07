using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator.Exemplo2
{
    public class ChatMediator
    {
        private List<AbstractUsuarioChat> _usuarios;

        public ChatMediator()
        {
            _usuarios = new List<AbstractUsuarioChat>();
        }

        public void Enviar(string mensagem, AbstractUsuarioChat sender)
        {
            for (int i = 0; i < _usuarios.Count; i++)
            {
                if (_usuarios[i].Nome != sender.Nome)
                    _usuarios[i].RecebeMensagem(TraduzirMensagem(mensagem, sender.Nome, _usuarios[i].Nome));
            }
        }

        public void AdicionarASala(AbstractUsuarioChat usuario)
        {
            _usuarios.Add(usuario);
        }

        private string TraduzirMensagem(string mensagemOriginal, string linguagemOrigem, string linguagemDestino)
        {
            if (linguagemOrigem == "Africano" && linguagemDestino == "Europeu")
            {
                if (mensagemOriginal == "boodskap")
                    return "message";
                if (mensagemOriginal == "hallo")
                    return "hello";
            }
            if (linguagemOrigem == "Europeu" && linguagemDestino == "Africano")
            {
                if (mensagemOriginal == "message")
                    return "boodskap";

                if (mensagemOriginal == "hello")
                    return "hallo";
            }

            return "";
        }
    }
}
