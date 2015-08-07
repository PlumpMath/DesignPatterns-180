using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod.Exemplo1
{
    public class Playlist
    {
        private List<Musica> _musicas;
        private SorterTemplate _sorter;

        public List<Musica> Musicas
        {
            get
            {
                return _sorter.Ordenar(_musicas);
            }
        }

        public Playlist(SorterTemplate sorter)
        {
            _sorter = sorter;
            _musicas = new List<Musica>();
        }

        public void AddMusica(Musica musica)
        {
            _musicas.Add(musica);
        }
    }
}
