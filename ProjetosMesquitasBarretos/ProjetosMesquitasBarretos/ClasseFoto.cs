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
        string nome;

       

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
            string conteudo = "Id" + "|" + c.Id.ToString()+ "|" + "Nome" + "|" + c.Nome.ToString()+ "|" + "Descrição" + "|" + c.Descrição+ "|" + "Dados" + "|" + c.ArquivoDeDados + "Local" + "|" + c.Local + "|" + "MegaPixels" + "|" + c.MegaPixels.ToString() + "|" + "Tempo" + "|" + c.TempoEmSegundosParaExibir.ToString() + "Ano de Lançamento" + "|" + c.Anodelancamento.ToString() + "|"+"Foto" + Environment.NewLine;
            if (File.Exists("Mídia.txt"))
            {
                File.AppendAllText("Mídia.txt", conteudo);
            }
            else
                File.WriteAllText("Mídia.txt", conteudo);

        }
    }
}
