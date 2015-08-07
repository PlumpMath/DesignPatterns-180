using System;
using Bridge.Exemplo1;
using Bridge.Exemplo2;
using Bridge.Exemplo3;
namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //EX1();
            //EX2();
            EX3();

            Console.ReadKey();
        }

        #region EXEMPLO 1

        public static void EX1()
        {
            // sem generics
            Abstraction abstracao = new Abstraction(new ImplementationA());
            abstracao.Operacao();
            abstracao = new Abstraction(new ImplementationB());
            abstracao.Operacao();

            // com generics
            new GenericAbstraction<ImplementationA>().Operacao();
            new GenericAbstraction<ImplementationB>().Operacao();
        }

        #endregion EXEMPLO 1

        #region EXEMPLO 2

        public static void EX2()
        {
            Calculadora calculadora = new Calculadora(new CalculadoraMath());
            Console.WriteLine(calculadora.PI);

            calculadora = new Calculadora(new CalculadoraReduzida());
            Console.WriteLine(calculadora.PI);
        }

        #endregion EXEMPLO 2

        #region EXEMPLO 3

        public static void EX3()
        {
            AbstractJanela janelaAbstrata = new JanelaDialogo(new JanelaWindows());
            janelaAbstrata.Show();
        }

        #endregion EXEMPLO 3
    }
}