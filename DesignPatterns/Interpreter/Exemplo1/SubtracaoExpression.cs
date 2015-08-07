using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter.Exemplo1
{
    public class SubtracaoExpression : AbstractExpression
    {
        private AbstractExpression _operator1;
        private AbstractExpression _operator2;

        public SubtracaoExpression(AbstractExpression operator1, AbstractExpression operator2)
        {
            _operator1 = operator1;
            _operator2 = operator2;
        }

        public override int Interpret(Contexto ctx)
        {
            return _operator1.Interpret(ctx) - _operator2.Interpret(ctx);
        }
    }
}
