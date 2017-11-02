using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosMesquitasBarretos
{
    interface ILocal
    {
        string arquivoMidia
        {
            get;
            set;
        }
        bool ValidaCaminho();
    }
}
