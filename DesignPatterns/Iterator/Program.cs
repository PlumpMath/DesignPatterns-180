using Iterator.Exemplo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            EX1();


            Console.ReadKey();
        }

        #region Exemplo1

        public static void EX1()
        {
            ItemIterator iterator = new ItemIterator();
            iterator.Add(new Item("item1"));
            iterator.Add(new Item("item2"));
            iterator.Add(new Item("item3"));
            iterator.Add(new Item("item4"));

            int i = 0;
            while (i < iterator.Count)
            {
                Console.WriteLine(iterator.Get(i).Nome);
                i++;
            }

        }

        #endregion
    }
}
