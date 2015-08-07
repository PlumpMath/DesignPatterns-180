using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryMethod.Exemplo1;
using FactoryMethod.Exemplo2;

namespace FactoryMethod
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
            AbstractFactory factory = new ConcreteFactory1();

            AbstractObject createdObject = factory.CreateObjet();

            factory = new ConcreteFactory2();

            AbstractObject createdObject2 = factory.CreateObjet();

            createdObject.ViewDetails();
            createdObject2.ViewDetails();
        }

        #endregion


        #region EX2

        public static void EX2()
        {
            AbstractFabricaDeCarro fabrica = new FabricaChevrolet();

            AbstractCarro carro = fabrica.CriarCarro();
            carro.Detalhes();

            fabrica = new FabricaFiat();
            fabrica.CriarCarro().Detalhes();

            fabrica = new FabricaFord();
            fabrica.CriarCarro().Detalhes();
        }

        #endregion
    }
}
