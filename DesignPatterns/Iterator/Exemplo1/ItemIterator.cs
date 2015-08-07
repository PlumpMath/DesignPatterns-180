using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Exemplo1
{
    public class ItemIterator : IIterator<Item>
    {
        private List<Item> itens { get; set; }
        private int position;
        public int Count { get { return itens.Count; } }

        public Item Next()
        {
            if (position + 1 < itens.Count)
                return itens[position + 1];
            else
                return null;
        }

        public bool HasNext()
        {
            return (position + 1 < itens.Count);
        }

        public Item First()
        {
            if (itens.Count > 0)
                return itens[0];
            else
                return null;
        }

        public Item Last()
        {
            if (itens.Count > 0)
                return itens[itens.Count - 1];
            else
                return null;
        }

        public ItemIterator()
        {
            itens = new List<Item>();
            position = 0;
        }


        public void Add(Item objeto)
        {
            this.itens.Add(objeto);
            position++;
        }


        public Item Get(int index)
        {
            return this.itens[index];
        }
    }
}
