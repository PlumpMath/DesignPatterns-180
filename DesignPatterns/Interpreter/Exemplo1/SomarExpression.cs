using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter.Exemplo1
{
    public class SomarExpression : AbstractExpression
    {
        private AbstractExpression _operator1;
        private AbstractExpression _operator2;

        public SomarExpression(AbstractExpression op1, AbstractExpression op2)
        {
            _operator1 = op1;
            _operator2 = op2;
        }

        public override int Interpret(Contexto ctx)
        {
           return _operator1.Interpret(ctx) + _operator2.Interpret(ctx);
        }
    }
}
