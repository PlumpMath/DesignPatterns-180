using System;

namespace Flyweight.Exemplo1
{
    public class Sprite : ISpriteFlyweight
    {
        private Imagem imagem;

        public Sprite(string nomeImagem)
        {
            this.imagem = new Imagem(nomeImagem);
        }

        public void DesenharImagem(Ponto ponto)
        {
            imagem.DesenharImagem();
            Console.WriteLine("No ponto {0},{1}\n", ponto.x, ponto.y);
        }
    }
}