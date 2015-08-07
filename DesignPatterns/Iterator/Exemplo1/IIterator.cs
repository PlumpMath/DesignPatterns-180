using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Exemplo1
{
    public interface IIterator<T>
    {
        T Next();

        bool HasNext();

        T First();

        T Last();

        void Add(T objeto);

        T Get(int index);
    }
}
