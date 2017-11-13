using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace ProjetosMesquitasBarretos
{
    public enum IdiomaEnum
    {
        Inglês, Português, Outros
    }
    public enum FormatoEnumVideo
    {
        AVI, WMV, MKV, MP4, MPEG, OUTROS
    }
    public class ClasseVídeo: ClasseMidia
    {
        bool possuilegenda;
        private FormatoEnumVideo fvideo;
        private IdiomaEnum idiomaenum;

       

        

        public bool Possuilegenda
        {
            get
            {
                return possuilegenda;
            }

            set
            {
                possuilegenda = value;
            }
        }
       

        public FormatoEnumVideo Fvideo
        {
            get
            {
                return fvideo;
            }

            set
            {
                fvideo = value;
            }
        }

        public IdiomaEnum Idiomaenum
        {
            get
            {
                return idiomaenum;
            }

            set
            {
                idiomaenum = value;
            }
        }

        public void Inclui(ClasseVídeo c)
        {
            string dados = "Id" + "|" + c.Id.ToString() + "|" + "Descrição" + "|" + c.Descrição.ToString() + "|" + "Dados" + "|" + c.ArquivoDeDados + "|" + "Formato" + "|" + c.Fvideo + "|" + "Idioma" + "|" + c.Idiomaenum + "|" + "Legenda"+c.Possuilegenda +"Ano de Lançamento"+"|"+c.Anodelancamento+ Environment.NewLine;
            if (File.Exists("dados.txt"))
            {
                File.AppendAllText("dados", dados);
            }
            else
                File.WriteAllText("dados", dados);
        }

        
    }
}
