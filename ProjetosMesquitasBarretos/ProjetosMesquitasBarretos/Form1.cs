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
        string pastafotos = Path.GetDirectoryName(Application.ExecutablePath) + "\\Mídias\\";
        public Tela1()
        {
            InitializeComponent();
            button1.Enabled = false;
            

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
            listBox1.Items.Clear();
            string[] dados = File.ReadAllLines("Mídia.txt");
            PreencheObjeto(dados, -1);

        }
        private void PreencheObjeto(string[] arquivotexto, int verificamidia)
        {
            
            minhalista = new Lista();
           
            for (int i = 0; i < arquivotexto.Length; i++)
            {
                bool existe = false;
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
                if (aux == "Música" && verificamidia == 3 || aux == "Música" && verificamidia == -1 || aux == "Música" && verificamidia == 4)
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
                        minhalista.InserirNoFim(musica);
                        if (verificamidia == 4)
                        {
                            for (int p = 0; p < comboBox1.Items.Count;p++ )
                            {
                                if (musica.Album == comboBox1.Items[p].ToString())
                                    existe = true;
                            }
                            if (existe == false)
                                comboBox1.Items.Add(musica.Album);

                            if(comboBox1.SelectedIndex != -1)
                            {
                                string album = comboBox1.SelectedItem.ToString();
                                if (listaauxiliar != null)
                                {
                                    if (listaauxiliar.PesquisaAlbum(album) == true)
                                    {
                                        if(musica.Album == album)
                                        listaauxiliar.InserirNoFim(musica);
                                    }
                                    else
                                    {
                                        listaauxiliar = new Lista();
                                        listaauxiliar.InserirNoInicio(musica);
                                    }
                                }
                                else
                                {
                                    listaauxiliar = new Lista();
                                    listaauxiliar.InserirNoInicio(musica);
                                }

                                listBox1.Items.Add(musica.ToString());
                            }
                        }
                        if(verificamidia != 4)
                        listBox1.Items.Add(musica.ToString());
                        
                        
                        
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
                        listBox1.Items.Add(video.ToString());
                        minhalista.InserirNoFim(video);
                        
                        
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
                        foto.Anodelancamento = Convert.ToInt32(informacao[17]);
                        foto.Formatofoto = (Ffoto)Enum.Parse(typeof(Ffoto), informacao[15]);
                        listBox1.Items.Add(foto.ToString());
                        minhalista.InserirNoFim(foto);
                        
                        
                    }


                
            }

           
        }
        Pilha minhapilha;
        ClassMusica musica;
        ClasseVídeo video;
        ClasseFoto foto;
        Lista minhalista;
        Lista listaauxiliar;
        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
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
                listBox1.Items.Clear();
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
                listBox1.Items.Clear();
                PreencheObjeto(arquivotexto, 2);
                
                btnIniciar.Enabled = true;
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
            listBox1.Items.Clear();
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dados = File.ReadAllLines("Mídia.txt");

                string[] posicoes = ProcuraPorAno(Convert.ToInt32(textanopesq.Text));
                string[] vetano = new string[posicoes.Length];
                for (int i = 0; i < posicoes.Length; i++)
                {
                    if (Convert.ToInt32(posicoes[i]) < Convert.ToInt32(posicoes[0]))
                        break;
                    vetano[i] = dados[Convert.ToInt32(posicoes[i])];
                }
                PreencheObjeto(vetano, -1);
            }
            catch
            {
                MessageBox.Show("Digite um ano válido !!!");
            }
           
        }

        private string[] ProcuraPorAno(int anopesquisado)
        {
            string[] dados = File.ReadAllLines("Mídia.txt");
            int[] ano = new int[dados.Length];
            string[] vetaux = new string[dados.Length];
            int i = 0;
            string auxnum = "";
            for (i = 0; i < dados.Length; i++)
            {
                
                string[] informacao = dados[i].Split('|');
                for (int p = 0; p < informacao.Length; p++)
                {
                    if (informacao[p] == "Ano de Lançamento")
                    {
                        if (Convert.ToInt32(informacao[p + 1]) == anopesquisado)
                        {
                            if (auxnum == "")
                                auxnum = Convert.ToString(i);
                            else
                            auxnum += "|" + Convert.ToString(i);
                        }

                    }

                }
                vetaux = auxnum.Split('|');
                


                
            }
            return vetaux;
        }

        private string[] OrdemDescricao()
        {
            string[] arquivotexto = File.ReadAllLines("Mídia.txt");
            int contador = 0;
            string varaux;
            string[] nome = new string[arquivotexto.Length];
            for (int t = 0; t < arquivotexto.Length; t++)
            {
                string[] aux = arquivotexto[t].Split('|');
                for(int p =0;p<aux.Length;p++)
                {
                    if (aux[p] == "Descrição")
                        nome[t] = aux[p + 1];
                }
            }

            for (int i = 0; i < nome.Length - 1; i++)
            {
                contador = i;
                for (int j = i + 1; j < nome.Length; j++)
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
            listBox1.Items.Clear();
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
            listaauxiliar = new Lista();
            string[] arquivotexto = File.ReadAllLines("Mídia.txt");
            PreencheObjeto(arquivotexto, -1);
            
            for(int i = 0;i<arquivotexto.Length;i++)
            {
                minhapilha.Empilhar(minhalista.RemoverDaPosicao(0));
                
            }

            listBox1.Items.Clear();
            for (int t = 0; t < arquivotexto.Length;t++)
            {
                
                objaux = minhapilha.Desempilhar();
                listBox1.Items.Add(objaux.ToString());
                listaauxiliar.InserirNoFim(objaux);
                
            }
            
        }
        ClasseMidia objaux;

        private void filaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            minhafila = new Fila();
            listaauxiliar = new Lista();
            string[] arquivotexto = File.ReadAllLines("Mídia.txt");
            PreencheObjeto(arquivotexto, -1);
            for (int i = 0; i < arquivotexto.Length; i++)
            {
                minhafila.enfileirar(minhalista.RemoverDaPosicao(0));
            }
            listBox1.Items.Clear();
            for(int t=0;t<arquivotexto.Length;t++)
            {
                objaux = minhafila.desenfileira();
                listaauxiliar.InserirNoFim(objaux);
                listBox1.Items.Add(objaux.ToString());

            }
           
        }

        private void filaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] arquivotexto = File.ReadAllLines("Mídia.txt");
            PreencheObjeto(OrdemDescricao(), -1);
            
        }

        private void álbunsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] arquivotexto = File.ReadAllLines("Mídia.txt");
            PreencheObjeto(arquivotexto, 4);
        }
        int tempodecorrido = 0;
        int tempo = 0;
        string extencao = "";
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (listaauxiliar != null)
                    objaux = listaauxiliar.RemoverDaPosicao(0);
                else
                    objaux = minhalista.RemoverDaPosicao(0);
                if(objaux is ClasseFoto)
                {
                    extencao = (objaux as ClasseFoto).Formatofoto.ToString();
                    tempo = (objaux as ClasseFoto).TempoEmSegundosParaExibir;
                    timer1.Start();
                }
                else if(objaux is ClassMusica)
                {
                    extencao = (objaux as ClassMusica).Fmusica.ToString();
                    axWindowsMediaPlayer1.settings.volume = (objaux as ClassMusica).Volume * 10;
                }
                else if (objaux is ClasseVídeo)
                {
                    extencao = (objaux as ClasseVídeo).Fvideo.ToString();
                    axWindowsMediaPlayer1.settings.volume = 30;
                }
                
                string conteudo = pastafotos+objaux.Nome.ToLower()+"."+extencao;
                axWindowsMediaPlayer1.URL = conteudo;
                
                axWindowsMediaPlayer1.Ctlcontrols.play();
                
            }
            catch
            {
                MessageBox.Show("Crie uma playlist primeiro !!!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            tempodecorrido++;
            label2.Text = Convert.ToString(tempodecorrido);
            if (tempodecorrido == tempo)
            {
                timer1.Stop();
                tempo = 0;
                tempodecorrido = 0;
                try
                {
                    if (listaauxiliar != null)
                        objaux = listaauxiliar.RemoverDaPosicao(0);
                    else
                        objaux = minhalista.RemoverDaPosicao(0);
                    if (objaux is ClasseFoto)
                    {
                        extencao = (objaux as ClasseFoto).Formatofoto.ToString();
                        tempo = (objaux as ClasseFoto).TempoEmSegundosParaExibir;
                        timer1.Start();
                    }
                    else if (objaux is ClassMusica)
                    {
                        extencao = (objaux as ClassMusica).Fmusica.ToString();
                        axWindowsMediaPlayer1.settings.volume = (objaux as ClassMusica).Volume;
                    }
                    else if (objaux is ClasseVídeo)
                    {
                        extencao = (objaux as ClasseVídeo).Fvideo.ToString();
                    }
                    string conteudo = pastafotos + objaux.Nome.ToLower() + "." + extencao;
                    axWindowsMediaPlayer1.URL = conteudo;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch
                {
                   
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    MessageBox.Show("Fim da playlist !!!");
                }
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] arquivotexto = File.ReadAllLines("Mídia.txt");
            PreencheObjeto(arquivotexto, 4);
        }
    }
}
