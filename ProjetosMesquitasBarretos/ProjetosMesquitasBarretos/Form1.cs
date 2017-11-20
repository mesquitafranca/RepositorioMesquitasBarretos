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

        public void lerTxt()
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
                }
                listBox1.Items.Add("ID-" + informacao[1] + "-" + aux);

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
        private Lista PreencheObjeto(string[] arquivotexto, int verificamidia)
        {
            minhalista = new Lista();
            for (int i = 0; i < arquivotexto.Length; i++)
            {
                string aux = "";
                string[] informacao = arquivotexto[i].Split('|');
                for (int p = 0; p < informacao.Length; p++)
                {
                    if (informacao[p] == "Música" || informacao[p] == "Vídeo" || informacao[p] == "Foto")
                    {
                        aux = informacao[p];
                        break;
                    }

                }
                    if (aux == "Música" && verificamidia == 3 || aux == "Música"&& verificamidia == -1)
                    {
                        musica = new ClassMusica();
                        musica.Id = Convert.ToInt16(informacao[1]);
                        musica.Nome = informacao[3];
                        musica.Album = informacao[5];
                        musica.Descrição = informacao[7];
                        musica.ArquivoDeDados = informacao[9];
                        musica.Fmusica = (FormatoEnummusica)Enum.Parse(typeof(FormatoEnummusica), informacao[11]);
                        musica.Duracao = Convert.ToDouble(informacao[13]);
                        musica.Volume = Convert.ToInt16(informacao[15]);
                        musica.Anodelancamento = Convert.ToInt32(informacao[17]);
                        musica.ValidaCaminho();
                        listBox1.Items.Add("ID:" + informacao[1] + "-Nome:" + informacao[3] + "-Mídia: Música" + "\n");
                        minhalista.InserirNoFim(musica);
                        return minhalista;
                        
                        
                    }

                    else if (aux == "Vídeo" && verificamidia == 1 || aux == "Vídeo" && verificamidia == -1)
                    {
                        video = new ClasseVídeo();
                        video.Id = Convert.ToInt16(informacao[1]);
                        video.Nome = informacao[3];
                        video.Descrição = informacao[5];
                        video.ArquivoDeDados = informacao[7];
                        video.Fvideo = (FormatoEnumVideo)Enum.Parse(typeof(FormatoEnumVideo), informacao[9]);
                        video.Idiomaenum = (IdiomaEnum)Enum.Parse(typeof(IdiomaEnum), (informacao[11]));
                        video.Possuilegenda = Convert.ToBoolean(informacao[13]);
                        video.Anodelancamento = Convert.ToInt32(informacao[15]);
                        listBox1.Items.Add("ID:" + informacao[1] + "-Nome:" + informacao[3] + "-Mídia:Vídeo" + "\n");
                        minhalista.InserirNoFim(video);
                        return minhalista;
                        
                    }
                    else if (aux == "Foto" && verificamidia == 2 || aux == "Foto" && verificamidia == -1)
                    {
                        foto = new ClasseFoto();
                        foto.Id = Convert.ToInt16(informacao[1]);
                        foto.Nome = informacao[3];
                        foto.Descrição = informacao[5];
                        foto.ArquivoDeDados = informacao[7];
                        foto.Local = informacao[9];
                        foto.MegaPixels = Convert.ToDouble(informacao[11]);
                        foto.TempoEmSegundosParaExibir = Convert.ToInt16(informacao[13]);
                        foto.Anodelancamento = Convert.ToInt32(informacao[15]);
                        listBox1.Items.Add("ID:" + informacao[1] + "-Nome" + informacao[3] + "-Mídia:Foto" + "\n");
                        minhalista.InserirNoFim(foto);
                        return minhalista;
                        
                    }


                
            }

            throw new Exception("Erro de leitura !!!");
        }
        Pilha minhapilha;
        ClassMusica musica;
        ClasseVídeo video;
        ClasseFoto foto;
        Lista minhalista;
        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] arquivotexto = File.ReadAllLines("Mídia.txt");
            try
            {
                PreencheObjeto(arquivotexto, 3);
            }
            catch
            {
                MessageBox.Show("Músicas não cadastradas");
            }
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] arquivotexto = File.ReadAllLines("Mídia.txt");
            try
            {
                PreencheObjeto(arquivotexto, 1);
            }
            catch
            {
                MessageBox.Show("Vídeos não cadastrados");
            }

        }

        private void fotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] arquivotexto = File.ReadAllLines("Mídia.txt");
            try
            {
                PreencheObjeto(arquivotexto, 2);
            }
            catch
            {
                MessageBox.Show("Fotos não cadastradas");
            }
        }
        Fila minhafila;
        private void btnEscolherMusica_Click(object sender, EventArgs e)
        {
        }

        private void anoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dados = File.ReadAllLines("Mídia.txt");
            int[] posicoes = ProcuraPorAno(Convert.ToInt32(textanopesq.Text));
            for (int i = 0; i < posicoes.Length; i++)
            {
                if (posicoes[i] < posicoes[0])
                    break;
                listBox1.Items.Add(dados[posicoes[i]]);
            }

        }

        private int[] ProcuraPorAno(int anopesquisado)
        {
            string[] dados = File.ReadAllLines("Mídia.txt");
            int[] ano = new int [dados.Length];
            int[] linhasdesejadas = new int[dados.Length];
            for (int p = 0; p < dados.Length;p++ )
            {
                string[] aux = dados[p].Split('|');
                ano[p] = Convert.ToInt32(aux[15]);
            }
            for (int i = 0; i < ano.Length;i++ )
            {
                if(ano[i] == anopesquisado)
                    linhasdesejadas[i] = i;
            }




                return linhasdesejadas;
        }

        private string[] OrdemAlfabética()
        {
            string[] arquivotexto = File.ReadAllLines("Mídia.txt");
            int contador = 0;
            string varaux;
            string[] nome = new string[arquivotexto.Length];
            for (int t = 0; t < arquivotexto.Length; t++)
            {
                string[] aux = arquivotexto[t].Split('|');
                nome[t] = aux[3];
            }

            for (int i = 0; i < nome.Length - 1; i++)
            {
                contador = i;
                for(int j=i+1;j<nome.Length;j++)
                {
                    if (nome[j].CompareTo(nome[contador]) == -1)
                        contador = j;
                }
                varaux = arquivotexto[contador];
                arquivotexto[contador] = arquivotexto[i];
                arquivotexto[i] = varaux;
            }

                return arquivotexto;
        }


        private void ordemAlfabéticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] vetoremordem = OrdemAlfabética();
            PreencheObjeto(vetoremordem, -1);
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnEscolherMidia_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.contextMenuStrip1.Show(sender as Control, e.X, e.Y);
        }

        private void btnEscolherMusica_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.contextMenuStrip2.Show(sender as Control, e.X, e.Y);
        }

        private void btnreproducao_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.contextMenuStrip3.Show(sender as Control, e.X, e.Y);
        }

        private void pilhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            minhapilha = new Pilha();
            string[] arquivotexto = File.ReadAllLines("Mídia.txt");
            PreencheObjeto(arquivotexto, -1);
            for(int i = 0;i<arquivotexto.Length;i++)
            {
                minhapilha.Empilhar(minhalista.RemoverDaPosicao(i));
            }
        }

        private void filaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            minhafila = new Fila();
            
            string[] arquivotexto = File.ReadAllLines("Mídia.txt");
            PreencheObjeto(arquivotexto, -1);
            for (int i = 0; i < arquivotexto.Length; i++)
            {
                minhafila.enfileirar(minhalista.RemoverDaPosicao(i));
            }

        }

        private void filaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string[] arquivotexto = File.ReadAllLines("Mídia.txt");
            PreencheObjeto(arquivotexto, -1);
        }
    }
}
