﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace ProjetosMesquitasBarretos
{
    public enum Ffoto
    {
        jpg, bitmap, png
    }
   public class ClasseFoto: ClasseMidia,ILocal,ICatalogo
    {
        string local; //local onde a foto foi tirada
        double megaPixels;
        int tempoEmSegundosParaExibir; //tempo em segundos que a foto será exibida no player
        private Ffoto formatofoto;

        public Ffoto Formatofoto
        {
            get { return formatofoto; }
            set { formatofoto = value; }
        }

       

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
       public bool ValidaCaminho()
        {
            return true;
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
            string conteudo = "Id" + "|" + c.Id.ToString()+ "|" + "Nome" + "|" + c.Nome.ToString()+ "|" + "Descrição" + "|" + c.Descrição+ "|" + "Dados" + "|" + c.ArquivoDeDados+"|" + "Local" + "|" + c.Local + "|" + "MegaPixels" + "|" + c.MegaPixels.ToString() + "|" + "Tempo" + "|" + c.TempoEmSegundosParaExibir.ToString()+"|"+"Formato"+"|"+c.Formatofoto+"|" + "Ano de Lançamento" + "|" + c.Anodelancamento.ToString() + "|"+"Foto" + Environment.NewLine;
            if (File.Exists("Mídia.txt"))
            {
                File.AppendAllText("Mídia.txt", conteudo);
            }
            else
                File.WriteAllText("Mídia.txt", conteudo);

        }
    }
}
