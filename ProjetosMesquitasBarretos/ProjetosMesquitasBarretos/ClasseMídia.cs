using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjetosMesquitasBarretos
{
   public abstract class ClasseMidia
    {
        int id; //Identificação da música
        string descrição; //Comentários Gerais sobre a música
        string arquivoDeDados;  //local e nome do arquivo de dados(onde as mídias serão armazenadas)

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Descrição
        {
            get
            {
                return descrição;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Digite uma descrição válido !!!");
                descrição = value;
            }
        }

        public string ArquivoDeDados
        {
            get
            {
                return arquivoDeDados;
            }

            set
            {

                if (String.IsNullOrEmpty(value))
                    throw new Exception("Digite um caminho correto !!!");
                    arquivoDeDados = value;
            }
        }

        
    }
}
