using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TemplateMethod.Exemplo1;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            EX1();

            Console.ReadKey();
        }

        #region EX1

        public static void EX1()
        {
            Playlist playlist = new Playlist(new NomeSorter());

            playlist.AddMusica(new Musica("Want you bad", "The Offspring", "2000"));
            playlist.AddMusica(new Musica("Linoleum", "NOFX", "1994"));
            playlist.AddMusica(new Musica("New Dark Ages", "Bad Religion", "2004"));
            playlist.AddMusica(new Musica("Feeling this", "Blink 182", "2003"));
            playlist.AddMusica(new Musica("No Cigar", "Millencolin", "2001"));

            playlist.Musicas.ForEach(m => Console.WriteLine("{0} - {1} {2}", m.Nome, m.Artista, m.Ano));

        }

        #endregion

    }
}

