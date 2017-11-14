using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetosMesquitasBarretos
{
    /// <summary>
    /// Classe Pilha Dinâmica
    /// </summary>
    class Pilha
    {        
        //Representa o topo da pilha
        private Nodo topo = null;
        
        // quantidade de elementos na pilha
        int quantidade = 0;
        public int Quantidade
        {
            get { return quantidade; }            
        }

        /// <summary>
        /// Método para empilhar strings
        /// </summary>
        /// <param name="valor"></param>
        public void Empilhar(ClasseMidia valor)
        {
            Nodo novoNodo = new Nodo();
            novoNodo.Valor = valor;
            novoNodo.Anterior = topo;

            topo = novoNodo;
            quantidade++;
        }

        /// <summary>
        /// Desempilhar elementos da pilha
        /// </summary>
        /// <returns></returns>
        public ClasseMidia Desempilhar()
        {
            if (quantidade == 0)
                throw new Exception("A pilha está vazia!");
            else
            {
                ClasseMidia retorno = topo.Valor;
                topo = topo.Anterior;
                quantidade--;
                return retorno;
            }
        }

        /// <summary>
        /// Método para retornr o topo da pilha
        /// </summary>
        /// <returns></returns>
        public ClasseMidia RetornaTopo()
        {
            if (quantidade == 0)
                throw new Exception("A pilha está vazia!");
            else
            {
                return topo.Valor;
            }
        }


       


    }
}
