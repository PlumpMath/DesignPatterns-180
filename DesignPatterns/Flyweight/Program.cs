using System;
using Flyweight.Exemplo1;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            EX1();

            Console.ReadKey();
        }

        #region Exemplo1

        public static void EX1()
        {
            SpriteFlyweightFactory factory = new SpriteFlyweightFactory();

            factory[SpriteFlyweightFactory.TIPO_PERSONAGEM.Heroi].DesenharImagem(new Ponto(5, 5));
            factory[SpriteFlyweightFactory.TIPO_PERSONAGEM.Aliado].DesenharImagem(new Ponto(8, 5));

            factory[SpriteFlyweightFactory.TIPO_PERSONAGEM.Monstro].DesenharImagem(new Ponto(15, 5));
            factory[SpriteFlyweightFactory.TIPO_PERSONAGEM.Monstro].DesenharImagem(new Ponto(20, 5));
            factory[SpriteFlyweightFactory.TIPO_PERSONAGEM.Monstro].DesenharImagem(new Ponto(25, 5));
        }

        #endregion Exemplo1
    }
}