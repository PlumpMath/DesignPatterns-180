using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.Exemplo1
{
    public class Arvore
    {
        public No Raiz { get; set; }
        public int Count { get; set; }

        public Arvore(int chaveRaiz)
        {
            Raiz =  new No(chaveRaiz);
        }

        public void Add(int chave)
        {
            No penultimo = Ultimo();

            No no = new No(chave);
            no.Esquerdo = penultimo;
            penultimo.Direito = no;
        }

        public No Buscar(int chave)
        {
            No aux = Raiz;
            bool achou = false;

            if (aux != null)
            {
                while (aux.Direito != null && !achou)
                {
                    if (aux.Chave == chave)
                        achou = true;
                    else
                        aux = Raiz.Direito;
                }
            }

            return aux;
        }

        public No Ultimo()
        {
            No aux = Raiz;
            if (aux != null)
            {
                while (aux.Direito != null)
                {
                    aux = aux.Direito;
                }
            }

            return aux;
        }

        public void AceitaVisitante(IArvoreVisitor visitante)
        {
            visitante.Visitar(Raiz);
        }

    }
}
