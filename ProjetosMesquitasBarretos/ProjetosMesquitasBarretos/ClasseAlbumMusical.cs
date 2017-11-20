using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjetosMesquitasBarretos
{
    
   public class ClasseAlbumMusical: ClasseMidia, ICatalogo
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
        Lista minhalista;
       
      
        
    }
}
