using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace ProjetosMesquitasBarretos
{
   public class ClasseFoto: ClasseMidia
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

       public void Inclui(ClasseFoto c)
        {
            string conteudo = "Id" + "|" + c.Id.ToString() + "|"+"Nome"+"|"+c.Nome+"|" + "Descrição" + "|" + c.Descrição.ToString() + "|" + "Dados" + "|" + c.ArquivoDeDados + "Local" + "|" + c.Local + "|" + "MegaPixels" + "|" + c.MegaPixels + "|" + "Tempo" + "|" + c.TempoEmSegundosParaExibir +"Ano de Lançamento"+"|"+c.Anodelancamento+ Environment.NewLine;
            if (File.Exists("dados.txt"))
            {
                File.AppendAllText("dados.txt", conteudo);
            }
            else
                File.WriteAllText("dados.txt", conteudo);

        }
    }
}
