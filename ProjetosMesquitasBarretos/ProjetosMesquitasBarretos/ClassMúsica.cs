﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace ProjetosMesquitasBarretos
{
   public class ClassMusica: ClasseMidia,ILocal
    {
        string arquivomidia;
        int volume;
        double duracao;
        private FormatoEnumMusica fmusica;

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

        public FormatoEnumMusica Fmusica
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

        public void Inclui(string Id,string Nome,string artista,string local)
        {
            string conteudo = Id+"|"+Nome+"|"+artista+"|"+local+Environment.NewLine;
            if(File.Exists("dados.txt"))
            {
                File.AppendAllText("dados", conteudo);
            }
            else
                File.WriteAllText("dados", conteudo);
        }
    }
}
