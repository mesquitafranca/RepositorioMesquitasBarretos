using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace ProjetosMesquitasBarretos
{
   public class ClasseVídeo: ClasseMidia
    {
        bool possuilegenda;
        private FormatoEnumvideo fvideo;
        private IdiomaEnum idiomaenum;

        public IdiomaEnum Idiomaenum
        {
            get { return idiomaenum; }
            set { idiomaenum = value; }
        }

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

        public FormatoEnumvideo Fvideo
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

        public void Inclui(ClasseVídeo c)
        {
            string dados = "Id" + "|" + c.Id.ToString() + "|" + "Descrição" + "|" + c.Descrição.ToString() + "|" + "Dados" + "|" + c.ArquivoDeDados + "|" + "Formato" + "|" + c.Fvideo + "|" + "Idioma" + "|" + c.Idiomaenum + "|" + "Legenda"+c.Possuilegenda + Environment.NewLine;
            if (File.Exists("dados.txt"))
            {
                File.AppendAllText("dados", dados);
            }
            else
                File.WriteAllText("dados", dados);
        }
    }
}
