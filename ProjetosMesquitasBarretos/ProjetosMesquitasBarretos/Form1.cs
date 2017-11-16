using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetosMesquitasBarretos
{
    public partial class Tela1 : Form
    {
        public Tela1()
        {
            InitializeComponent();
           


        }

       public void lerTxt ()
        {
            string[] dados = File.ReadAllLines("Mídia.txt");
            for(int i =0;i<dados.Length;i++)
            {
                string aux =  "";
                string[] informacao = dados[i].Split('|');
                for (int p = 0; p < informacao.Length;p++ )
                {
                    if (informacao[p] == "Música" || informacao[p] == "Vídeo" || informacao[p] == "Foto")
                        aux = informacao[p];
                }
                    listBox1.Items.Add("ID-" + informacao[1]+"-"+aux);
                
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaSobre sobre = new TelaSobre();
            sobre.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cadastroDeMídiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastro cadastro = new TelaCadastro();
            cadastro.ShowDialog();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void informaçãoSobreAMídiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novaPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void btnEscolherMidia_Click(object sender, EventArgs e)
        {
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lerTxt();
            
        }
        private void PreencheObjeto(string[] arquivotexto)
        {
          string[] dados = File.ReadAllLines("Mídia.txt");
          for (int i = 0; i < dados.Length; i++)
          {
              string aux = "";
              string[] informacao = dados[i].Split('|');
              for (int p = 0; p < informacao.Length; p++)
              {
                  if (informacao[p] == "Música" || informacao[p] == "Vídeo" || informacao[p] == "Foto")
                      aux = informacao[p];
                  if (aux == "Música")
                  {
                      musica.Id = Convert.ToInt16(informacao[1]);
                      musica.Nome = informacao[3];
                      musica.Descrição = informacao[5];
                      musica.ArquivoDeDados = informacao[7];
                      musica.Fmusica = (FormatoEnummusica)Enum.Parse(typeof(FormatoEnummusica), informacao[9]);
                      musica.Duracao = Convert.ToDouble(informacao[11]);
                      musica.Volume = Convert.ToInt16(informacao[13]);
                      musica.Anodelancamento = Convert.ToInt32(informacao[15]);
                  }

                  else if (aux == "Vídeo")
                  {
                      video.Id = Convert.ToInt16(informacao[1]);
                      video.Nome = informacao[3];
                      video.Descrição = informacao[5];
                      video.ArquivoDeDados = informacao[7];
                      video.Fvideo = (FormatoEnumVideo)Enum.Parse(typeof(FormatoEnumVideo), informacao[9]);
                      video.Idiomaenum = (IdiomaEnum)Enum.Parse(typeof(IdiomaEnum),(informacao[11]));
                      video.Possuilegenda = Convert.ToBoolean(informacao[13]);
                      video.Anodelancamento = Convert.ToInt32(informacao[15]);
                  }
                  else if (aux == "Foto")
                  {
                      foto.Id = Convert.ToInt16(informacao[1]);
                      foto.Nome = informacao[3];
                      foto.Descrição = informacao[5];
                      foto.ArquivoDeDados = informacao[7];
                      foto.Local= informacao[9];
                      foto.MegaPixels = Convert.ToDouble(informacao[11]);
                      foto.TempoEmSegundosParaExibir = Convert.ToInt16(informacao[13]);
                      foto.Anodelancamento = Convert.ToInt32(informacao[15]);
                  }
                  
              }
          }
        }
        Pilha minhapilha;
        ClassMusica musica;
        ClasseVídeo video;
        ClasseFoto foto;
        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] arquivotexto = File.ReadAllLines("Mídia.txt");
            bool encontramusica = false;
            for(int i = 0;i<arquivotexto.Length;i++)
            {
                string[] conteudo = arquivotexto[i].Split('|');
                for (int p = 0; p < conteudo.Length; p++)
                {
                    if (conteudo[p] == "Música")
                    {
                        
                        encontramusica = true;
                        listBox1.Items.Add("ID-"+conteudo[1]+"-"+conteudo[p]);
                        musica.Id = Convert.ToInt16(conteudo[1]);
                        musica.Nome = conteudo[3];
                        musica.Descrição = conteudo[5];
                        musica.ArquivoDeDados = conteudo[7];
                        musica.Fmusica = (FormatoEnummusica)Enum.Parse(typeof(FormatoEnummusica), conteudo[9]);
                        musica.Duracao = Convert.ToDouble(conteudo[11]);
                        musica.Volume = Convert.ToInt16(conteudo[13]);
                        musica.Anodelancamento = Convert.ToInt32(conteudo[15]);
                        minhapilha.Empilhar(musica);
                        
                    }
                }
            }
            if (encontramusica == false)
                MessageBox.Show("Não há músicas cadastradas!!!");
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] arquivotexto = File.ReadAllLines("Mídia.txt");
            bool encontramusica = false;
            for (int i = 0; i < arquivotexto.Length; i++)
            {
                string[] conteudo = arquivotexto[i].Split('|');
                for (int p = 0; p < conteudo.Length; p++)
                {
                    if (conteudo[p] == "Vídeo")
                    {
                        encontramusica = true;
                        listBox1.Items.Add("ID-"+conteudo[1]+"-"+conteudo[p]);
                        video.Id = Convert.ToInt16(conteudo[1]);
                        video.Nome = conteudo[3];
                        video.Descrição = conteudo[5];
                        video.ArquivoDeDados = conteudo[7];
                        video.Fvideo = (FormatoEnumVideo)Enum.Parse(typeof(FormatoEnumVideo), conteudo[9]);
                        video.Idiomaenum = (IdiomaEnum)Enum.Parse(typeof(IdiomaEnum), (conteudo[11]));
                        video.Possuilegenda = Convert.ToBoolean(conteudo[13]);
                        video.Anodelancamento = Convert.ToInt32(conteudo[15]);
                        minhapilha.Empilhar(video);
                    }
                }
            }
            if (encontramusica == false)
                MessageBox.Show("Não há vídeos cadastrados!!!");
        }

        private void fotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] arquivotexto = File.ReadAllLines("Mídia.txt");
            bool encontramusica = false;
            for (int i = 0; i < arquivotexto.Length; i++)
            {
                string[] conteudo = arquivotexto[i].Split('|');
                for (int p = 0; p < conteudo.Length; p++)
                {
                    if (conteudo[p] == "Foto")
                    {
                        encontramusica = true;
                        listBox1.Items.Add("ID-"+conteudo[1]+"-"+conteudo[p]);
                        foto.Id = Convert.ToInt16(conteudo[1]);
                        foto.Nome = conteudo[3];
                        foto.Descrição = conteudo[5];
                        foto.ArquivoDeDados = conteudo[7];
                        foto.Local = conteudo[9];
                        foto.MegaPixels = Convert.ToDouble(conteudo[11]);
                        foto.TempoEmSegundosParaExibir = Convert.ToInt16(conteudo[13]);
                        foto.Anodelancamento = Convert.ToInt32(conteudo[15]);
                        minhapilha.Empilhar(foto);
                    }
                }
            }
            if (encontramusica == false)
                MessageBox.Show("Não há fotos cadastradas!!!");
        }
    }
}
