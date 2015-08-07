using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Exemplo1
{
    public class Item
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Item(string nome)
        {
            this.Nome = nome;
        }
    }
}
