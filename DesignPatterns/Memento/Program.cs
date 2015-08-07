using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Memento.Exemplo1;
using Memento.Exemplo2;

namespace Memento
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
            CareTaker careTaker = new CareTaker();
            
            Originator objeto = new Originator();
            objeto.SetState("estado original");

            objeto.ShowState();
            careTaker.AddStep(new Memento.Exemplo1.Memento(objeto.SaveState()));

            objeto.SetState("mutação de estado 1");
            objeto.SetState("mutação de estado 2");

            objeto.RestoreState(careTaker.GetLastStep());
            objeto.ShowState();
        }

        #endregion

        #region EX2

        public static void EX2()
        {
            IDE visualStudio = new IDE();

            Documento documento = new Documento();
            documento.Estado = "public static void Main(string[] args){ }";
            visualStudio.Salvar(documento.SalvarMemento());
            Console.WriteLine(documento.Estado);

            documento.Estado += "public void Teste(){}";
            visualStudio.Salvar(documento.SalvarMemento());
            Console.WriteLine(documento.Estado);

            documento.RecuperarMemento(visualStudio.Desfazer());
            Console.WriteLine(documento.Estado);

            documento.RecuperarMemento(visualStudio.Refazer());
            Console.WriteLine(documento.Estado);
        }

        #endregion
    }
}
