using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosMesquitasBarretos
{
    class ClassMusica: ClasseMidia
    {
        int volume;
        double duracao;
        private FormatoEnumMusica fmusica;

        public int Volume
        {
            get
            {
                return volume;
            }

            set
            {
                volume = value;
            }
        }

        public FormatoEnumMusica Fmusica
        {
            get
            {
                return fmusica;
            }

            set
            {
                fmusica = value;
            }
        }

        public double Duracao
        {
            get
            {
                return duracao;
            }

            set
            {
                duracao = value;
            }
        }
    }
}
