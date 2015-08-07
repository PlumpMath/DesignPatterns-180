using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod.Exemplo1
{
    public class AnoSorter : SorterTemplate
    {
        public override bool isPrimeiro(Musica musica1, Musica musica2)
        {
            return Convert.ToInt32(musica1.Ano) < Convert.ToInt32(musica2.Ano);
        }
    }
}
