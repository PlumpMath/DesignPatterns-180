using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento.Exemplo2
{
    public class IDE
    {
        private Stack<Memento> _estados;
        private Stack<Memento> _desfeitos;
        private Memento _estadoAtual;

        public IDE()
        {
            _estados = new Stack<Memento>();
            _desfeitos = new Stack<Memento>();

            _estadoAtual = new Memento("");
        }

        public void Salvar(Memento estado)
        {
            _estadoAtual = estado;
            _estados.Push(_estadoAtual);
        }

        public Memento Desfazer()
        {
            _desfeitos.Push(_estados.Pop());
            _estadoAtual = _estados.Peek();

            return _estadoAtual;
        }

        public Memento Refazer()
        {
            _estados.Push(_estadoAtual = _desfeitos.Pop());

            return _estadoAtual;
        }

    }
}
