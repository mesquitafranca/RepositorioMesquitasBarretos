using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace ProjetosMesquitasBarretos
{
    public enum FormatoEnummusica
    {
        mp3, wav, wma
    }

    public class ClassMusica: ClasseMidia
    {
        int volume;
        double duracao;
        private FormatoEnummusica fmusica;
        string album;

        public string Album
        {
            get { return album; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Digite um nome válido  para álbum !!!");
                album = value; 
            }
        }

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

        public FormatoEnummusica Fmusica
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

       

        public bool ValidaCaminho()
        {
            return true;
        }
        public void IncluiMusica(ClassMusica m)
        {
            string dados = "Id" + "|" + m.Id.ToString() +"|"+"Nome"+"|"+m.Nome+"|"+"Álbum"+"|"+m.Album+"|"+"Descrição" + "|" + m.Descrição.ToString() + "|" + "Dados" + "|" + m.ArquivoDeDados + "|" + "Formato" + "|" + m.Fmusica + "|" + "Duração" + "|" + m.Duracao.ToString() + "|" + "Volume" + "|" + m.Volume.ToString()+ "|" +"Ano de Lançamento"+"|"+ m.Anodelancamento+"|"+"Música"+Environment.NewLine;
           if(File.Exists("Mídia.txt"))
           {
               
               File.AppendAllText("Mídia.txt", dados);
           }
           else
               File.WriteAllText("Mídia.txt", dados);

        }

    }
}
