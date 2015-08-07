using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter.Exemplo1
{
    public abstract class AbstractExpression
    {
        public abstract int Interpret(Contexto ctx);
    }
}
