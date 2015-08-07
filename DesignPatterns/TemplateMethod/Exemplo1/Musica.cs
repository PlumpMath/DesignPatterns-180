using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod.Exemplo1
{
    public class Musica
    {
        public string Nome { get; set; }
        public string Artista { get; set; }
        public string Ano { get; set; }
        
        public Musica() { }

        public Musica(string nome, string artista, string ano) 
        {
            Nome = nome;
            Artista = artista;
            Ano = ano;
        }
    }
}
