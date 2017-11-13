using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace ProjetosMesquitasBarretos
{
   public abstract class ClasseMidia: ICatalogo
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

        public int Anodelancamento
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public virtual void VerificaId(ClasseMidia m)
        {
            if (File.Exists("Mídia.txt"))
            {
                string[] arquivo = File.ReadAllLines("Mídia.txt");
                for (int i = 0; i < arquivo.Length; i++)
                {
                    string[] dados = arquivo[i].Split('|');
                    if (m.Id == Convert.ToInt32(dados[1]))
                        throw new Exception("Este Id já foi cadastrado !!!");
                }
            }
            else
                return;


        }
        static public void Excluir(int m)
        {
            if (File.Exists("Mídia.txt"))
            {
                string[] arquivo = File.ReadAllLines("Mídia.txt");
                for (int i = 0; i < arquivo.Length; i++)
                {
                    string[] dados = arquivo[i].Split('|');
                    if (m == Convert.ToInt32(dados[1]))
                    {
                        for (int t = i; t < arquivo.Length; t++)
                        {
                            if (t == arquivo.Length - 1)
                            {
                                string[] aux = new string[arquivo.Length - 1];
                                for (int p = 0; p < arquivo.Length - 1; p++)
                                {
                                    aux[p] = arquivo[p];
                                }
                                File.WriteAllLines("Mídia.txt", aux);
                                return;
                            }
                            else
                                arquivo[t] = arquivo[t + 1];
                        }
                    }
                }
            }
            else
                return;
        }

    }
}
