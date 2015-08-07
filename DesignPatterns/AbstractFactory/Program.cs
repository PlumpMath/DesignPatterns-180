using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactory.Exemplo1;
using AbstractFactory.Exemplo2;

namespace AbstractFactory
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
            AbstractFactory.Exemplo1.AbstractFactory factory = new ConcreteFactory1();

            AbstractFamily1 obj1 = factory.CreateObjetFamily1();
            obj1.Details();

            factory.CreateObjetFamily2().Details();

            factory = new ConcreteFactory2();
            factory.CreateObjetFamily1().Details();
            factory.CreateObjetFamily2().Details();

        }

        #endregion

        #region EX2

        public static void EX2()
        {
            AbstractFabricaDeCarro fabrica = new FiatFactory();

            AbstractCarroPopular carroPopular = fabrica.CriarCarroPopular();
            carroPopular.Detalhes();

            fabrica = new FordFactory();

            carroPopular = fabrica.CriarCarroPopular();
            carroPopular.Detalhes();

            fabrica.CriarCarroSedan().Detalhes();
        }

        #endregion
    }
}
