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
        private void PreencheObjeto(string[] arquivotexto, int verificamidia)
        {
            minhapilha = new Pilha();
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
                    if (aux == "Música" && verificamidia == 3 || verificamidia == -1)
                    {
                        musica = new ClassMusica();
                        musica.Id = Convert.ToInt16(informacao[1]);
                        musica.Nome = informacao[3];
                        musica.Descrição = informacao[5];
                        musica.ArquivoDeDados = informacao[7];
                        musica.Fmusica = (FormatoEnummusica)Enum.Parse(typeof(FormatoEnummusica), informacao[9]);
                        musica.Duracao = Convert.ToDouble(informacao[11]);
                        musica.Volume = Convert.ToInt16(informacao[13]);
                        musica.Anodelancamento = Convert.ToInt32(informacao[15]);
                        listBox1.Items.Add("ID:" + informacao[1] + "-Nome:" + informacao[3] + "-Mídia: Música" + "\n");
                        
                    }

                    else if (aux == "Vídeo" && verificamidia == 1 || verificamidia == -1)
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
                        
                    }
                    else if (aux == "Foto" && verificamidia == 2 || verificamidia == -1)
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
            int[] linhasdesejadas = new int[dados.Length];
            int contador = 0;
            for (int i = 0; i < dados.Length; i++)
            {
                int ano = 0;
                string[] informacao = dados[i].Split('|');
                for (int p = 0; p < informacao.Length; p++)
                {
                    if (informacao[p] == "Ano de Lançamento" && Convert.ToInt32(informacao[p + 1]) == anopesquisado)
                    {
                        ano = Convert.ToInt32(informacao[p + 1]);
                        linhasdesejadas[contador] = i;
                        contador++;
                    }
                }


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
    }
}
