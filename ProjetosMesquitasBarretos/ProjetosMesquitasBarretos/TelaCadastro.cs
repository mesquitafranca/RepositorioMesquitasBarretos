﻿using System;
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
           
            cbFormato.DataSource = Enum.GetValues(typeof(FormatoEnummusica)); 

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            //Campos de Vídeos - ID, Descrição, Nome,  Diretório, Idioma, Formato , Possui Legenda?
            apagarCampos();

            //Campos Incluídos
            labelIdioma.Visible = true;
            labelFormato.Visible = true;

            groupBoxLegenda.Visible = true;
            rbNao.Visible = true;
            rbSim.Visible = true;
            cbIdioma.Visible = true;
            cbFormato.Visible = true;
            cbFormato.DataSource = Enum.GetValues(typeof(FormatoEnumVideo));
            cbIdioma.DataSource = Enum.GetValues(typeof(IdiomaEnum));

            //Campos Excluídos
            labelArtista.Visible = false;
            labelAlbum.Visible = false;
            labelVolume.Visible = false;
            labelMegaPixels.Visible = false;
            labelDuracao.Visible = false;
            labelLocal.Visible = false;
            labelTempo.Visible = false;

            textAlbum.Visible = false;
            textArtista.Visible = false;
            textTempo.Visible = false;
            textDuracao.Visible = false;
            textVolume.Visible = false;
            textMegaPixels.Visible = false;
            textLocal.Visible = false;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioMusica_CheckedChanged(object sender, EventArgs e)
        {
            //Campos de Música - ID, Descrição, Nome, Artista, Album, Volume, Duração, Diretório, Formato

            apagarCampos();

            //Campos Incluídos
            labelVolume.Visible = true;
            labelAlbum.Visible = true;
            labelArtista.Visible = true;
            labelDuracao.Visible = true;
            labelFormato.Visible = true;

            textVolume.Visible = true;
            textAlbum.Visible = true;
            textArtista.Visible = true;
            textDuracao.Visible = true;
            textAlbum.Visible = true;
            cbFormato.Visible = true;
            cbFormato.DataSource = Enum.GetValues(typeof(FormatoEnummusica));

            //Campos Excluídos

            labelTempo.Visible = false;
            textTempo.Visible = false;
            cbIdioma.Visible = false;
            labelIdioma.Visible = false;
            rbNao.Visible = false;
            rbSim.Visible = false;
            textMegaPixels.Visible = false;
            labelMegaPixels.Visible = false;
            labelLocal.Visible = false;
            textLocal.Visible = false;
            groupBoxLegenda.Visible = false;
        }

        private void radioFoto_CheckedChanged(object sender, EventArgs e)
        {
            //Campos de Fotos - ID, Descrição, Nome,  Diretório, Local, MegaPixel, Tempo de exibição de cada foto

            apagarCampos();

            //Campos Incluídos
            labelLocal.Visible = true;
            labelMegaPixels.Visible = true;
            labelTempo.Visible = true;

            textLocal.Visible = true;
            textMegaPixels.Visible = true;
            textTempo.Visible = true;
            cbFormato.DataSource = Enum.GetValues(typeof(Ffoto));
            //Campos Excluídos
            labelIdioma.Visible = false;
            labelDuracao.Visible = false;
            labelVolume.Visible = false;
            labelArtista.Visible = false;
            labelAlbum.Visible = false;
            labelFormato.Visible = true;

            cbIdioma.Visible = false;
            rbNao.Visible = false;
            rbSim.Visible = false;
            textDuracao.Visible = false;
            textAlbum.Visible = false;
            textArtista.Visible = false;
            textVolume.Visible = false;
            groupBoxLegenda.Visible = false;
            cbFormato.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //copiar imagem
                string pastaEXE = Path.GetDirectoryName(Application.ExecutablePath);
                string pastaMídias = pastaEXE + "\\Mídias\\";
                if (Directory.Exists(pastaMídias) == false)
                    Directory.CreateDirectory(pastaMídias);

                string nomeDestino = Path.GetFileName(openFileDialog1.FileName)  ;
                string nomeDestinoCompleto = pastaMídias + nomeDestino;
                File.Copy(openFileDialog1.FileName, nomeDestinoCompleto, true);
                labelLink.Text = nomeDestino;
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
                    ClassMusica.VerificaId(Convert.ToInt16(textId.Text));
                    musica.Descrição = textDescricao.Text;
                    musica.ArquivoDeDados = labelLink.Text;
                    musica.Nome = textNome.Text;
                    musica.Album = textAlbum.Text;
                    musica.Fmusica = (FormatoEnummusica)cbFormato.SelectedItem;
                    musica.Duracao = Convert.ToDouble(textDuracao.Text);
                    musica.Volume = Convert.ToInt32(textVolume.Text);
                    musica.Anodelancamento = Convert.ToInt32(TextBoxAno.Text);
                    musica.IncluiMusica(musica);
                    MessageBox.Show("Mídia salva com sucesso!");
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
                    ClasseVídeo.VerificaId(Convert.ToInt16(textId.Text));
                    video.Descrição = textDescricao.Text;
                    video.ArquivoDeDados = labelLink.Text;
                    video.Fvideo = (FormatoEnumVideo)cbFormato.SelectedItem;
                    video.Anodelancamento = Convert.ToInt32(TextBoxAno.Text);
                    video.Nome = textNome.Text;
                    if (rbSim.Checked)
                        video.Possuilegenda = true;
                    else
                        video.Possuilegenda = false;
                    video.Inclui(video);
                    MessageBox.Show("Mídia salva com sucesso!");
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
                    ClasseFoto.VerificaId(Convert.ToInt16(textId.Text));
                    foto.Descrição = textDescricao.Text;
                    foto.ArquivoDeDados = labelLink.Text;
                    foto.Local = textLocal.Text;
                    foto.MegaPixels = Convert.ToDouble(textMegaPixels.Text);
                    foto.TempoEmSegundosParaExibir = Convert.ToInt32(textTempo.Text);
                    foto.Anodelancamento = Convert.ToInt32(TextBoxAno.Text);
                    foto.Formatofoto = (Ffoto)cbFormato.SelectedItem;
                    foto.Nome = textNome.Text;
                    foto.Inclui(foto);
                    MessageBox.Show("Mídia salva com sucesso!");
                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

            
            apagarCampos();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBoxLegenda_Enter(object sender, EventArgs e)
        {

        }

        private void btnExcluirMidia_Click(object sender, EventArgs e)
        {
            try
            {
                ClasseMidia.Excluir(Convert.ToInt16(maskedTextExcluido.Text));
                MessageBox.Show("Mídia excluída com sucesso !!!");
            }
            catch
            {
                MessageBox.Show("Mídia não encontrada !!!");
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if(radioMusica.Checked == true)
            {
                string dados = "Id" + "|" + textId.Text + "|" + "Nome" + "|" + textNome.Text + "|" + "Álbum" + "|" + textAlbum.Text + "|" + "Descrição" + "|" + textDescricao.Text + "|" + "Dados" + "|" + labelLink.Text + "|" + "Formato" + "|" + cbFormato.SelectedItem + "|" + "Duração" + "|" + textDuracao.Text + "|" + "Volume" + "|" + textVolume.Text + "|" + "Ano de Lançamento" + "|" + TextBoxAno.Text + "|" + "Música" ;
                ClasseMidia.Alterar(dados);
            }
            if(radioVideo.Checked == true)
            {
                 string legenda = "";
                 if (rbSim.Checked == true)
                 {
                     legenda = "Sim";
                     legenda = "Não";
                 }
                 string dados = "Id" + "|" + textId.Text + "|" + "Nome" + "|" + textNome.Text + "|" + "Descrição" + "|" + textDescricao.Text + "|" + "Dados" + "|" + labelLink.Text + "|" + "Formato" + "|" + cbFormato.SelectedItem + "|" + "Idioma" + "|" + cbIdioma.SelectedItem + "|" + "Legenda" + "|" + legenda + "|" + "Ano de Lançamento" + "|" + TextBoxAno.Text + "|" + "Vídeo" ;
                 ClasseMidia.Alterar(dados);
            }
            if(radioFoto.Checked == true)
            {
                string dados = "Id" + "|" + textId.Text + "|" + "Nome" + "|" + textNome.Text + "|" + "Descrição" + "|" + textDescricao.Text + "|" + "Dados" + "|" + labelLink.Text + "|" + "Local" + "|" + textLocal.Text + "|" + "MegaPixels" + "|" + textMegaPixels.Text + "|" + "Tempo" + "|" + textTempo.Text + "|" + "Formato" + "|" + cbFormato.SelectedItem + "|" + "Ano de Lançamento" + "|" + TextBoxAno.Text + "|" + "Foto";
                ClasseMidia.Alterar(dados);
            }
        }

       
    }
}
