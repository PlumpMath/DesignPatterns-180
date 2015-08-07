using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter.Exemplo1
{
    public class Contexto
    {
        private Dictionary<string, int> _expressoes;

        public Contexto()
        {
            _expressoes = new Dictionary<string, int>();
        }

        public void Assign(Variavel v, int value)
        {
            _expressoes[v.Nome] = value;
        }

        public int Lookup(string nome)
        {
            return _expressoes[nome];
        }

    }
}
