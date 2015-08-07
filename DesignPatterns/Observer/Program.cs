using System;
using System.Threading;
using Observer.Exemplo1;
using Observer.Exemplo2;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            //EX1();

            EX2();

            Console.ReadKey();
        }

        #region Exemplo1

        public static void EX1()
        {
            ObservadoConcreto observado = new ObservadoConcreto();

            ObservadorConcreto observador1 = new ObservadorConcreto("fotógrafo");
            ObservadorConcreto observador2 = new ObservadorConcreto("curioso");
            ObservadorConcreto observador3 = new ObservadorConcreto("cachorro");

            observado.AddObservador(observador1);
            observado.AddObservador(observador2);
            observado.AddObservador(observador3);

            observado.NotificarObservadores();

            observado.RemoveObservador(observador3);
            Thread.Sleep(2000);

            observado.NotificarObservadores();
        }

        #endregion Exemplo1

        #region Exemplo2

        public static void EX2()
        {
            CenaDoCrime cenaDoCrime = new CenaDoCrime();

            Policial policial = new Policial();
            cenaDoCrime.AddEspectador(policial);

            cenaDoCrime.NotificarEspectadores("Homem levando tiro");

            Cachorro cachorro = new Cachorro();
            Curioso curioso = new Curioso();

            cenaDoCrime.AddEspectador(cachorro);
            cenaDoCrime.AddEspectador(curioso);

            cenaDoCrime.NotificarEspectadores("Homem gritando");

            Fotografo fotografo = new Fotografo();

            cenaDoCrime.AddEspectador(fotografo);

            cenaDoCrime.NotificarEspectadores("Homem sangrando no chão");

            cenaDoCrime.RemoveEspectador(curioso);
            cenaDoCrime.RemoveEspectador(cachorro);

            cenaDoCrime.NotificarEspectadores("Ambulância chegando");
        }

        #endregion Exemplo2
    }
}