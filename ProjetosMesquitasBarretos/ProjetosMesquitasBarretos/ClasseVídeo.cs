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
        private FormatoEnumVideo fvideo;

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

        public void Inclui(string Id, string Nome)
        {
            string conteudo = Id + "|" + Nome+Environment.NewLine;
            if (File.Exists("dados.txt"))
            {
                File.AppendAllText("dados", conteudo);
            }
            else
                File.WriteAllText("dados", conteudo);
        }
    }
}
