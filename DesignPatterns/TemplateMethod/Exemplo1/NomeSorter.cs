using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod.Exemplo1
{
    public class NomeSorter : SorterTemplate
    {
        public override bool isPrimeiro(Musica musica1, Musica musica2)
        {
            return musica1.Nome == musica2.Nome;
        }
    }
}
