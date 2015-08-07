using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.Exemplo1
{
    public interface IArvoreVisitor
    {
        void Visitar(No no);
    }
}
