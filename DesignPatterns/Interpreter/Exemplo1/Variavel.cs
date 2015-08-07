using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter.Exemplo1
{
    public class Variavel : AbstractExpression
    {
        public string Nome { get; set; }

        public Variavel(string nome)
        {
            Nome = nome;
        }

        public override int Interpret(Contexto ctx)
        {
            return ctx.Lookup(Nome);
        }
    }
}
