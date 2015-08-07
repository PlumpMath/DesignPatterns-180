using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mediator.Exemplo1;
using Mediator.Exemplo2;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            //EX1();
            EX2();

            Console.ReadKey();
        }

        #region EX1

        public static void EX1()
        {
            Mediator.Exemplo1.Mediator mediator = new Exemplo1.Mediator();
            ConcreteColleague participant = new ConcreteColleague(mediator);
            ConcreteColleague2 participant2 = new ConcreteColleague2(mediator);

            mediator.AddParticipant(participant);
            mediator.AddParticipant(participant2);

            participant.Send("Message");
            participant2.Send("Response of message");
            participant.Send("OK");
            participant2.Send("Bye");
        }

        #endregion

        #region EX2

        public static void EX2()
        {
            ChatMediator sala = new ChatMediator();

            Europeu usuarioNaEuropa = new Europeu(sala);
            Africano usuarioNaAfrica = new Africano(sala);

            sala.AdicionarASala(usuarioNaEuropa);
            sala.AdicionarASala(usuarioNaAfrica);

            usuarioNaEuropa.EnviarMensagem("hello");
            usuarioNaAfrica.EnviarMensagem("hallo");

            usuarioNaEuropa.EnviarMensagem("message");
        }

        #endregion
    }
}
