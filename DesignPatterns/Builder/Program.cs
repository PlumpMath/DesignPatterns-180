using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Builder.Exemplo1;
using Builder.Exemplo2;

namespace Builder
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
            Director director = new Director(new ConcreteBuilder());

            director.BuildObject();
            Product concrete = director.GetObject();
            Console.WriteLine(concrete.Nome + " - " + concrete.Description);
        }

        #endregion

        #region EX2

        public static void EX2()
        {
            Concessionaria concessionaria = new Concessionaria(new FiatBuilder());

            concessionaria.BuildCarro();

            Carro carro = concessionaria.GetCarro();
            Console.WriteLine(carro.Nome + " - " + carro.Modelo + " - " + carro.Motor);

            concessionaria = new Concessionaria(new FordBuilder());
            concessionaria.BuildCarro();
            carro = concessionaria.GetCarro();
            Console.WriteLine(carro.Nome + " - " + carro.Modelo + " - " + carro.Motor);
        }

        #endregion
    }
}
