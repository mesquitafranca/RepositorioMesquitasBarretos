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

    public class ClassMusica: ClasseMidia,ILocal
    {
        string arquivomidia;
        int volume;
        double duracao;
        private FormatoEnummusica fmusica;

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

        public string ArquivoMidia
        {
            get
            {
                return arquivomidia;
            }

            set
            {
                arquivomidia = value;
            }
        }

        public bool ValidaCaminho()
        {
            throw new NotImplementedException();
        }

        public void IncluiMusica(ClassMusica m)
        {
            string dados = "Id" + "|" + m.Id.ToString() + "|" + "Descrição" + "|" + m.Descrição.ToString() + "|" + "Dados" + "|" + m.ArquivoDeDados + "|" + "Formato" + "|" + m.Fmusica + "|" + "Duração" + "|" + m.Duracao.ToString() + "|" + "Volume" + "|" + m.Volume.ToString()+"Ano de Lançamento"+"|"+m.Anodelancamento+Environment.NewLine;
           if(File.Exists("Mídia.txt"))
           {
               
               File.AppendAllText("Mídia.txt", dados);
           }
           else
               File.WriteAllText("Mídia.txt", dados);

        }

    }
}
