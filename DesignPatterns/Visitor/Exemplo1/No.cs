using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.Exemplo1
{
    public class No
    {
        public int Chave { get; set; }
        public No Esquerdo, Direito;

        public No(int chave)
        {
            this.Chave = chave;
        }
    }
}
