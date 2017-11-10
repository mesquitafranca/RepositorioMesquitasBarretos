using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace ProjetosMesquitasBarretos
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
           
            cbFormato.DataSource = Enum.GetValues(typeof(FormatoEnumMusica)); 

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            apagarCampos();
            cbFormato.DataSource = Enum.GetValues(typeof(FormatoEnumvideo));
            cbIdioma.DataSource = Enum.GetValues(typeof(IdiomaEnum));
            labelAlbum.Visible = false;
            labelDuracao.Visible = false;
            textDuracao.Visible = false;
            textVolume.Visible = false;
            textMegaPixels.Visible = false;
            label6.Visible = false;
            label7.Visible = true;
            label8.Visible = true;
            rbNao.Visible = true;
            rbSim.Visible = true;
            cbIdioma.Visible = true;
            labelMegaPixels.Visible = false;
            textMegaPixels.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioMusica_CheckedChanged(object sender, EventArgs e)
        {
            apagarCampos();

            labelTempo.Visible = false;
            textTempo.Visible = false;
            cbIdioma.Visible = false;
            label8.Visible = false;
            label7.Visible = false;
            rbNao.Visible = false;
            rbSim.Visible = false;
            textMegaPixels.Visible = false;
            labelMegaPixels.Visible = false;
            labelLocal.Visible = false;
            textLocal.Visible = false;
        }

        private void radioFoto_CheckedChanged(object sender, EventArgs e)
        {
            apagarCampos();
            label7.Visible = false;
            cbIdioma.Visible = false;
            label8.Visible = false;
            label6.Visible = false;
            rbNao.Visible = false;
            rbSim.Visible = false;
            labelDuracao.Visible = false;
            textDuracao.Visible = false;
            textVolume.Visible = false;
            labelLocal.Visible = true;
            textLocal.Visible = true;
            textMegaPixels.Visible = true;
            labelMegaPixels.Visible = true;
            labelTempo.Visible = true;
            textTempo.Visible = true;
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
            
            textDescricao.Clear();
            textId.Clear();
            textNome.Clear();
            labelLink.Text = "";
            labelLink.Visible = false;


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (radioMusica.Checked == true)
            {
                try
                {
                    ClassMusica musica = new ClassMusica();
                    musica.Id = Convert.ToInt32(textId.Text);
                    musica.Descrição = textDescricao.Text;
                    musica.ArquivoDeDados = "dados.txt";
                    musica.Fmusica = (FormatoEnumMusica)cbFormato.SelectedItem;
                    musica.Duracao = Convert.ToDouble(textDuracao.Text);
                    musica.Volume = Convert.ToInt32(textVolume.Text);
                    musica.IncluiMusica(musica);
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
           

            if (radioVideo.Checked == true)
            {
                try
                {
                    ClasseVídeo video = new ClasseVídeo();
                    video.Id = Convert.ToInt32(textId.Text);
                    video.Descrição = textDescricao.Text;
                    video.ArquivoDeDados = "dados.txt";
                    video.Fvideo = (FormatoEnumvideo)cbFormato.SelectedItem;
                    if (rbSim.Checked)
                        video.Possuilegenda = true;
                    else
                        video.Possuilegenda = false;
                    video.Inclui(video);
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

            if (radioFoto.Checked == true)
            {
                try
                {
                    ClasseFoto foto = new ClasseFoto();
                    foto.Id = Convert.ToInt32(textId.Text);
                    foto.Descrição = textDescricao.Text;
                    foto.ArquivoDeDados = "dados.txt";
                    foto.Local = textLocal.Text;
                    foto.MegaPixels = Convert.ToDouble(textMegaPixels.Text);
                    foto.TempoEmSegundosParaExibir = Convert.ToInt32(textTempo.Text);
                    foto.Inclui(foto);
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
