using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

        public override void Inclui()
        {
            Console.Write("Vídeo");
        }
    }
}
