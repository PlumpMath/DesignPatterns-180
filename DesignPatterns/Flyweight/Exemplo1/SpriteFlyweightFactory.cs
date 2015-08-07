using System.Collections.Generic;

namespace Flyweight.Exemplo1
{
    public class SpriteFlyweightFactory
    {
        private Dictionary<TIPO_PERSONAGEM, ISpriteFlyweight> Flyweights;

        public enum TIPO_PERSONAGEM { Heroi, Vilao, Monstro, Aliado }

        public ISpriteFlyweight this[TIPO_PERSONAGEM tipo]
        {
            get
            {
                return Flyweights[tipo];
            }
            set
            {
                Flyweights[tipo] = value;
            }
        }

        public SpriteFlyweightFactory()
        {
            Flyweights = new Dictionary<TIPO_PERSONAGEM, ISpriteFlyweight>();

            Flyweights[TIPO_PERSONAGEM.Heroi] = new Sprite("heroi");
            Flyweights[TIPO_PERSONAGEM.Aliado] = new Sprite("aliado");
            Flyweights[TIPO_PERSONAGEM.Vilao] = new Sprite("vilao");
            Flyweights[TIPO_PERSONAGEM.Monstro] = new Sprite("monstro");
        }
    }
}