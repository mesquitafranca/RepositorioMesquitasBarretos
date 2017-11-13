using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetosMesquitasBarretos
{
    public partial class Tela1 : Form
    {
        public Tela1()
        {
            InitializeComponent();
            
            
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
    }
}
