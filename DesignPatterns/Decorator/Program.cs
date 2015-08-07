using System;
using Decorator.Exemplo2;
using Decorator.Exemplo3;

namespace Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // EX1();
            //EX2();
            EX3();

            Console.ReadKey();
        }

        #region Exemplo 1

        public static void Ex1()
        {
            Decorator.Exemplo1.Component component = new Exemplo1.Component();
            component.Operation();

            Decorator.Exemplo1.Decorator decorator = new Exemplo1.Decorator(component);
            decorator.Operation();

            decorator = new Exemplo1.Decorator(decorator);
            decorator.Operation();
        }

        #endregion Exemplo 1

        #region Exemplo 2

        public static void EX2()
        {
            IPessoa pessoa = new Pessoa("Pessoa");

            pessoa = new PessoaFeliz(pessoa);
            pessoa = new PessoaTranquila(pessoa);

            Console.WriteLine(pessoa.Caracteristicas());
        }

        #endregion Exemplo 2

        #region Exemplo 3

        public static void EX3()
        {
            ICoquetel coquetel;

            coquetel = new Vodka();
            Console.WriteLine(coquetel.Nome + " - " + coquetel.Preco);

            coquetel = new Limao(coquetel);
            Console.WriteLine(coquetel.Nome + " - " + coquetel.Preco);

            coquetel = new Acucar(coquetel);
            Console.WriteLine(coquetel.Nome + " - " + coquetel.Preco);
        }

        #endregion Exemplo 3
    }
}