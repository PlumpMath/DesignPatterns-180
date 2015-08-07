using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod.Exemplo1
{
    public abstract class SorterTemplate
    {
        public abstract bool isPrimeiro(Musica musica1, Musica musica2);

        public List<Musica> Ordenar(List<Musica> musicas)
        {
            List<Musica> playlist = null;

            if (musicas != null)
                playlist = new List<Musica>(musicas);

            for (int i = 0; i < playlist.Count; i++)
            {
                for (int j = 1; j < playlist.Count - 1; j++)
                {
                    if (isPrimeiro(playlist[i], playlist[j]))
                    {
                        Musica aux = playlist[j];
                        playlist[j] = playlist[i];
                        playlist[i] = aux;
                    }
                }
            }

            return playlist;
        }
    }
}
