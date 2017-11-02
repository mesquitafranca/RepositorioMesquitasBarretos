using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjetosMesquitasBarretos
{
    class ClasseFoto: ClasseMidia
    {
        string local; //local onde a foto foi tirada
        double megaPixels;
        int tempoEmSegundosParaExibir; //tempo em segundos que a foto será exibida no player

        public string Local
        {
            get
            {
                return local;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Digite um local válido !!!");
                local = value;
            }
        }

        public double MegaPixels
        {
            get
            {
                return megaPixels;
            }

            set
            {
                megaPixels = value;
            }
        }

        public int TempoEmSegundosParaExibir
        {
            get
            {
                return tempoEmSegundosParaExibir;
            }

            set
            {
                tempoEmSegundosParaExibir = value;
            }
        }
    }
}
