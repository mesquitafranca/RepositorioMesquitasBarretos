namespace ProjetosMesquitasBarretos
{
    partial class TelaCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            this.radioMusica = new System.Windows.Forms.RadioButton();
            this.radioVideo = new System.Windows.Forms.RadioButton();
            this.radioFoto = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.MaskedTextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelDuracao = new System.Windows.Forms.Label();
            this.labelProcurar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelLink = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbFormato = new System.Windows.Forms.ComboBox();
            this.labelFormato = new System.Windows.Forms.Label();
            this.textDuracao = new System.Windows.Forms.MaskedTextBox();
            this.labelVolume = new System.Windows.Forms.Label();
            this.textMegaPixels = new System.Windows.Forms.MaskedTextBox();
            this.labelIdioma = new System.Windows.Forms.Label();
            this.cbIdioma = new System.Windows.Forms.ComboBox();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.labelLocal = new System.Windows.Forms.Label();
            this.textLocal = new System.Windows.Forms.TextBox();
            this.labelMegaPixels = new System.Windows.Forms.Label();
            this.labelTempo = new System.Windows.Forms.Label();
            this.textTempo = new System.Windows.Forms.MaskedTextBox();
            this.textVolume = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxLegenda = new System.Windows.Forms.GroupBox();
            this.textAlbum = new System.Windows.Forms.TextBox();
            this.labelArtista = new System.Windows.Forms.Label();
            this.textArtista = new System.Windows.Forms.TextBox();
            this.groupBoxLegenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioMusica
            // 
            this.radioMusica.AutoSize = true;
            this.radioMusica.Location = new System.Drawing.Point(30, 63);
            this.radioMusica.Name = "radioMusica";
            this.radioMusica.Size = new System.Drawing.Size(84, 24);
            this.radioMusica.TabIndex = 0;
            this.radioMusica.TabStop = true;
            this.radioMusica.Text = "Música";
            this.radioMusica.UseVisualStyleBackColor = true;
            this.radioMusica.CheckedChanged += new System.EventHandler(this.radioMusica_CheckedChanged);
            // 
            // radioVideo
            // 
            this.radioVideo.AutoSize = true;
            this.radioVideo.Location = new System.Drawing.Point(284, 63);
            this.radioVideo.Name = "radioVideo";
            this.radioVideo.Size = new System.Drawing.Size(75, 24);
            this.radioVideo.TabIndex = 1;
            this.radioVideo.TabStop = true;
            this.radioVideo.Text = "Vídeo";
            this.radioVideo.UseVisualStyleBackColor = true;
            this.radioVideo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioFoto
            // 
            this.radioFoto.AutoSize = true;
            this.radioFoto.Location = new System.Drawing.Point(560, 63);
            this.radioFoto.Name = "radioFoto";
            this.radioFoto.Size = new System.Drawing.Size(67, 24);
            this.radioFoto.TabIndex = 2;
            this.radioFoto.TabStop = true;
            this.radioFoto.Text = "Foto";
            this.radioFoto.UseVisualStyleBackColor = true;
            this.radioFoto.CheckedChanged += new System.EventHandler(this.radioFoto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha a Mídia";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(26, 165);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(26, 20);
            this.labelId.TabIndex = 4;
            this.labelId.Text = "ID";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(70, 162);
            this.textId.Mask = "99";
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 26);
            this.textId.TabIndex = 5;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(238, 162);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(80, 20);
            this.labelDescricao.TabIndex = 6;
            this.labelDescricao.Text = "Descrição";
            this.labelDescricao.Click += new System.EventHandler(this.label3_Click);
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(338, 162);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(288, 26);
            this.textDescricao.TabIndex = 7;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(26, 245);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(51, 20);
            this.labelNome.TabIndex = 8;
            this.labelNome.Text = "Nome";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(122, 242);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(288, 26);
            this.textNome.TabIndex = 9;
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(26, 382);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(54, 20);
            this.labelAlbum.TabIndex = 12;
            this.labelAlbum.Text = "Album";
            // 
            // labelDuracao
            // 
            this.labelDuracao.AutoSize = true;
            this.labelDuracao.Location = new System.Drawing.Point(26, 338);
            this.labelDuracao.Name = "labelDuracao";
            this.labelDuracao.Size = new System.Drawing.Size(70, 20);
            this.labelDuracao.TabIndex = 16;
            this.labelDuracao.Text = "Duração";
            // 
            // labelProcurar
            // 
            this.labelProcurar.AutoSize = true;
            this.labelProcurar.Location = new System.Drawing.Point(30, 488);
            this.labelProcurar.Name = "labelProcurar";
            this.labelProcurar.Size = new System.Drawing.Size(138, 20);
            this.labelProcurar.TabIndex = 19;
            this.labelProcurar.Text = "Procurar Arquivo...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(30, 578);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(51, 20);
            this.labelLink.TabIndex = 21;
            this.labelLink.Text = "label6";
            this.labelLink.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(552, 498);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 83);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbFormato
            // 
            this.cbFormato.FormattingEnabled = true;
            this.cbFormato.Location = new System.Drawing.Point(122, 286);
            this.cbFormato.Name = "cbFormato";
            this.cbFormato.Size = new System.Drawing.Size(136, 28);
            this.cbFormato.TabIndex = 23;
            this.cbFormato.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelFormato
            // 
            this.labelFormato.AutoSize = true;
            this.labelFormato.Location = new System.Drawing.Point(26, 294);
            this.labelFormato.Name = "labelFormato";
            this.labelFormato.Size = new System.Drawing.Size(69, 20);
            this.labelFormato.TabIndex = 24;
            this.labelFormato.Text = "Formato";
            // 
            // textDuracao
            // 
            this.textDuracao.Location = new System.Drawing.Point(122, 332);
            this.textDuracao.Name = "textDuracao";
            this.textDuracao.Size = new System.Drawing.Size(136, 26);
            this.textDuracao.TabIndex = 25;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(334, 294);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(63, 20);
            this.labelVolume.TabIndex = 26;
            this.labelVolume.Text = "Volume";
            // 
            // textMegaPixels
            // 
            this.textMegaPixels.Location = new System.Drawing.Point(122, 332);
            this.textMegaPixels.Name = "textMegaPixels";
            this.textMegaPixels.Size = new System.Drawing.Size(112, 26);
            this.textMegaPixels.TabIndex = 27;
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.Location = new System.Drawing.Point(26, 335);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(57, 20);
            this.labelIdioma.TabIndex = 28;
            this.labelIdioma.Text = "Idioma";
            // 
            // cbIdioma
            // 
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.Location = new System.Drawing.Point(122, 332);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(136, 28);
            this.cbIdioma.TabIndex = 29;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(24, 52);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(61, 24);
            this.rbSim.TabIndex = 31;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(24, 98);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(63, 24);
            this.rbNao.TabIndex = 32;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(26, 291);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(47, 20);
            this.labelLocal.TabIndex = 33;
            this.labelLocal.Text = "Local";
            // 
            // textLocal
            // 
            this.textLocal.Location = new System.Drawing.Point(122, 286);
            this.textLocal.Name = "textLocal";
            this.textLocal.Size = new System.Drawing.Size(112, 26);
            this.textLocal.TabIndex = 34;
            // 
            // labelMegaPixels
            // 
            this.labelMegaPixels.AutoSize = true;
            this.labelMegaPixels.Location = new System.Drawing.Point(26, 335);
            this.labelMegaPixels.Name = "labelMegaPixels";
            this.labelMegaPixels.Size = new System.Drawing.Size(89, 20);
            this.labelMegaPixels.TabIndex = 35;
            this.labelMegaPixels.Text = "MegaPixels";
            // 
            // labelTempo
            // 
            this.labelTempo.AutoSize = true;
            this.labelTempo.Location = new System.Drawing.Point(26, 379);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.Size = new System.Drawing.Size(58, 20);
            this.labelTempo.TabIndex = 36;
            this.labelTempo.Text = "Tempo";
            // 
            // textTempo
            // 
            this.textTempo.Location = new System.Drawing.Point(122, 376);
            this.textTempo.Mask = "99";
            this.textTempo.Name = "textTempo";
            this.textTempo.Size = new System.Drawing.Size(100, 26);
            this.textTempo.TabIndex = 37;
            // 
            // textVolume
            // 
            this.textVolume.Location = new System.Drawing.Point(433, 291);
            this.textVolume.Mask = "9";
            this.textVolume.Name = "textVolume";
            this.textVolume.Size = new System.Drawing.Size(128, 26);
            this.textVolume.TabIndex = 38;
            // 
            // groupBoxLegenda
            // 
            this.groupBoxLegenda.Controls.Add(this.rbSim);
            this.groupBoxLegenda.Controls.Add(this.rbNao);
            this.groupBoxLegenda.Location = new System.Drawing.Point(433, 286);
            this.groupBoxLegenda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLegenda.Name = "groupBoxLegenda";
            this.groupBoxLegenda.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLegenda.Size = new System.Drawing.Size(170, 154);
            this.groupBoxLegenda.TabIndex = 39;
            this.groupBoxLegenda.TabStop = false;
            this.groupBoxLegenda.Text = "Possui Legenda";
            this.groupBoxLegenda.Enter += new System.EventHandler(this.groupBoxLegenda_Enter);
            // 
            // textAlbum
            // 
            this.textAlbum.Location = new System.Drawing.Point(122, 376);
            this.textAlbum.Name = "textAlbum";
            this.textAlbum.Size = new System.Drawing.Size(136, 26);
            this.textAlbum.TabIndex = 40;
            this.textAlbum.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // labelArtista
            // 
            this.labelArtista.AutoSize = true;
            this.labelArtista.Location = new System.Drawing.Point(26, 424);
            this.labelArtista.Name = "labelArtista";
            this.labelArtista.Size = new System.Drawing.Size(55, 20);
            this.labelArtista.TabIndex = 41;
            this.labelArtista.Text = "Artista";
            // 
            // textArtista
            // 
            this.textArtista.Location = new System.Drawing.Point(122, 421);
            this.textArtista.Name = "textArtista";
            this.textArtista.Size = new System.Drawing.Size(136, 26);
            this.textArtista.TabIndex = 42;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 608);
            this.Controls.Add(this.textArtista);
            this.Controls.Add(this.labelArtista);
            this.Controls.Add(this.textAlbum);
            this.Controls.Add(this.groupBoxLegenda);
            this.Controls.Add(this.textVolume);
            this.Controls.Add(this.textTempo);
            this.Controls.Add(this.labelTempo);
            this.Controls.Add(this.labelMegaPixels);
            this.Controls.Add(this.textLocal);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.cbIdioma);
            this.Controls.Add(this.labelIdioma);
            this.Controls.Add(this.textMegaPixels);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.textDuracao);
            this.Controls.Add(this.labelFormato);
            this.Controls.Add(this.cbFormato);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelProcurar);
            this.Controls.Add(this.labelDuracao);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioFoto);
            this.Controls.Add(this.radioVideo);
            this.Controls.Add(this.radioMusica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaCadastro";
            this.Text = "Cadastro de Mídia";
            this.Load += new System.EventHandler(this.TelaCadastro_Load);
            this.groupBoxLegenda.ResumeLayout(false);
            this.groupBoxLegenda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioMusica;
        private System.Windows.Forms.RadioButton radioVideo;
        private System.Windows.Forms.RadioButton radioFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.MaskedTextBox textId;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelDuracao;
        private System.Windows.Forms.Label labelProcurar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbFormato;
        private System.Windows.Forms.Label labelFormato;
        private System.Windows.Forms.MaskedTextBox textDuracao;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.MaskedTextBox textMegaPixels;
        private System.Windows.Forms.Label labelIdioma;
        private System.Windows.Forms.ComboBox cbIdioma;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.TextBox textLocal;
        private System.Windows.Forms.Label labelMegaPixels;
        private System.Windows.Forms.Label labelTempo;
        private System.Windows.Forms.MaskedTextBox textTempo;
        private System.Windows.Forms.MaskedTextBox textVolume;
        private System.Windows.Forms.GroupBox groupBoxLegenda;
        private System.Windows.Forms.TextBox textAlbum;
        private System.Windows.Forms.Label labelArtista;
        private System.Windows.Forms.TextBox textArtista;
    }
}