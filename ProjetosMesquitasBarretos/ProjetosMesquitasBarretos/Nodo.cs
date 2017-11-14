using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetosMesquitasBarretos
{
    /// <summary>
    /// Classe que irá representar 1 elemento na pilha
    /// </summary>
    class Nodo
    {
        private ClasseMidia valor;
        private Nodo anterior;
        private Nodo próximo;
        private ClasseMidia dado;

        /// <summary>
        /// Valor que será armazenado 
        /// </summary>
        public ClasseMidia Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public ClasseMidia Dado
        {
            get { return dado; }
            set { dado = value; }
        }

        /// <summary>
        /// Endereço do nodo anterior na pilha
        /// </summary>
        public Nodo Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }

        public Nodo Proximo
        {
            get { return próximo; }
            set { próximo = value; }
        }

    }
}
