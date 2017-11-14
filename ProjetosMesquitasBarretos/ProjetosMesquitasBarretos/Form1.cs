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
            string aux = "";
            
            for(int i =0;i<dados.Length;i++)
            {
                string[] informacao = dados[i].Split('|');
                aux = aux + informacao[1];
            }
            foreach (string d in dados)
            {
                listBox1.Items.Add(d);
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
                        listBox1.Items.Add(arquivotexto[i]);
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
                        listBox1.Items.Add(arquivotexto[i]);
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
                        listBox1.Items.Add(arquivotexto[i]);
                    }
                }
            }
            if (encontramusica == false)
                MessageBox.Show("Não há fotos cadastradas!!!");
        }
    }
}
