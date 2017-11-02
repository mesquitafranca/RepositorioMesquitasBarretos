using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosMesquitasBarretos
{
    class ClasseAlbumMusical: ClasseMidia
    {
        string artista;
        

        public string Artista
        {
            get
            {
                
                return artista;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Digite um nome de artista válido !!!");
                    artista = value;
            }
        }
    }
}
