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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            apagarCampos();
            labelAlbum.Visible = false;
            labelArtista.Visible = false;
            textAlbum.Visible = false;
            textArtista.Visible = false;
            textLocal.Visible = false;
            labelLocal.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioMusica_CheckedChanged(object sender, EventArgs e)
        {
            apagarCampos();
            labelAlbum.Visible = true;
            labelArtista.Visible = true;
            textAlbum.Visible = true;
            textArtista.Visible = true;
            textLocal.Visible = false;
            labelLocal.Visible = false;
        }

        private void radioFoto_CheckedChanged(object sender, EventArgs e)
        {
            apagarCampos();
            labelAlbum.Visible = false;
            labelArtista.Visible = false;
            textAlbum.Visible = false;
            textArtista.Visible = false;
            textLocal.Visible = true;
            labelLocal.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                labelLink.Text = openFileDialog1.FileName;
                labelLink.Visible = true;
            }

        }

        private void apagarCampos()
        {
            textLocal.Clear();
            textDescricao.Clear();
            textArtista.Clear();
            textAlbum.Clear();
            textAno.Clear();
            textId.Clear();
            textNome.Clear();
            labelLink.Text = "";
            labelLink.Visible = false;


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (radioMusica.Checked == true)
            {
                if (textId.Text == "" | textNome.Text == "" | labelLink.Text == "" | textAlbum.Text == "")
                {
                    MessageBox.Show("Os campos ID, Nome, Album e Procurar devem ser preenchidos");
                }

            }
           

            if (radioVideo.Checked == true)
            {
                if (textId.Text == "" | textNome.Text == "" | labelLink.Text == "")
                {
                    MessageBox.Show("Os campos ID, Nome e Procurar devem ser preenchidos");
                }
            }

            if (radioFoto.Checked == true)
            {
                if (textId.Text == "" | textNome.Text == "" | labelLink.Text == "")
                {
                    MessageBox.Show("Os campos ID, Nome e Procurar devem ser preenchidos");
                }

            }
        }
    }
}
