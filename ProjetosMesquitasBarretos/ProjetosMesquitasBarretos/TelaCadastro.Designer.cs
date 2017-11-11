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
            this.label2 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelDuracao = new System.Windows.Forms.Label();
            this.labelProcurar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelLink = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cbFormato = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textDuracao = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textMegaPixels = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbIdioma = new System.Windows.Forms.ComboBox();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.labelLocal = new System.Windows.Forms.Label();
            this.textLocal = new System.Windows.Forms.TextBox();
            this.labelMegaPixels = new System.Windows.Forms.Label();
            this.labelTempo = new System.Windows.Forms.Label();
            this.textTempo = new System.Windows.Forms.MaskedTextBox();
            this.textVolume = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioMusica
            // 
            this.radioMusica.AutoSize = true;
            this.radioMusica.Location = new System.Drawing.Point(20, 41);
            this.radioMusica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioMusica.Name = "radioMusica";
            this.radioMusica.Size = new System.Drawing.Size(59, 17);
            this.radioMusica.TabIndex = 0;
            this.radioMusica.TabStop = true;
            this.radioMusica.Text = "Música";
            this.radioMusica.UseVisualStyleBackColor = true;
            this.radioMusica.CheckedChanged += new System.EventHandler(this.radioMusica_CheckedChanged);
            // 
            // radioVideo
            // 
            this.radioVideo.AutoSize = true;
            this.radioVideo.Location = new System.Drawing.Point(189, 41);
            this.radioVideo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioVideo.Name = "radioVideo";
            this.radioVideo.Size = new System.Drawing.Size(54, 17);
            this.radioVideo.TabIndex = 1;
            this.radioVideo.TabStop = true;
            this.radioVideo.Text = "Vídeo";
            this.radioVideo.UseVisualStyleBackColor = true;
            this.radioVideo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioFoto
            // 
            this.radioFoto.AutoSize = true;
            this.radioFoto.Location = new System.Drawing.Point(373, 41);
            this.radioFoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioFoto.Name = "radioFoto";
            this.radioFoto.Size = new System.Drawing.Size(46, 17);
            this.radioFoto.TabIndex = 2;
            this.radioFoto.TabStop = true;
            this.radioFoto.Text = "Foto";
            this.radioFoto.UseVisualStyleBackColor = true;
            this.radioFoto.CheckedChanged += new System.EventHandler(this.radioFoto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha a Mídia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(47, 105);
            this.textId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textId.Mask = "99";
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(68, 20);
            this.textId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição";
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(225, 105);
            this.textDescricao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(193, 20);
            this.textDescricao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(81, 157);
            this.textNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(193, 20);
            this.textNome.TabIndex = 9;
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(20, 233);
            this.labelAlbum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(36, 13);
            this.labelAlbum.TabIndex = 12;
            this.labelAlbum.Text = "Album";
            // 
            // labelDuracao
            // 
            this.labelDuracao.AutoSize = true;
            this.labelDuracao.Location = new System.Drawing.Point(20, 233);
            this.labelDuracao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDuracao.Name = "labelDuracao";
            this.labelDuracao.Size = new System.Drawing.Size(48, 13);
            this.labelDuracao.TabIndex = 16;
            this.labelDuracao.Text = "Duração";
            // 
            // labelProcurar
            // 
            this.labelProcurar.AutoSize = true;
            this.labelProcurar.Location = new System.Drawing.Point(20, 317);
            this.labelProcurar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProcurar.Name = "labelProcurar";
            this.labelProcurar.Size = new System.Drawing.Size(95, 13);
            this.labelProcurar.TabIndex = 19;
            this.labelProcurar.Text = "Procurar Arquivo...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 339);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 25);
            this.button1.TabIndex = 20;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(20, 376);
            this.labelLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(35, 13);
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
            this.btnSalvar.Location = new System.Drawing.Point(368, 324);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(74, 54);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cbFormato
            // 
            this.cbFormato.FormattingEnabled = true;
            this.cbFormato.Location = new System.Drawing.Point(81, 186);
            this.cbFormato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFormato.Name = "cbFormato";
            this.cbFormato.Size = new System.Drawing.Size(92, 21);
            this.cbFormato.TabIndex = 23;
            this.cbFormato.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Formato";
            // 
            // textDuracao
            // 
            this.textDuracao.Location = new System.Drawing.Point(81, 231);
            this.textDuracao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDuracao.Name = "textDuracao";
            this.textDuracao.Size = new System.Drawing.Size(76, 20);
            this.textDuracao.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 268);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Volume";
            // 
            // textMegaPixels
            // 
            this.textMegaPixels.Location = new System.Drawing.Point(81, 266);
            this.textMegaPixels.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textMegaPixels.Name = "textMegaPixels";
            this.textMegaPixels.Size = new System.Drawing.Size(76, 20);
            this.textMegaPixels.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Idioma";
            // 
            // cbIdioma
            // 
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.Location = new System.Drawing.Point(272, 184);
            this.cbIdioma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(92, 21);
            this.cbIdioma.TabIndex = 29;
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(16, 34);
            this.rbSim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(42, 17);
            this.rbSim.TabIndex = 31;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(16, 64);
            this.rbNao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(45, 17);
            this.rbNao.TabIndex = 32;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // labelLocal
            // 
            this.labelLocal.AutoSize = true;
            this.labelLocal.Location = new System.Drawing.Point(22, 233);
            this.labelLocal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLocal.Name = "labelLocal";
            this.labelLocal.Size = new System.Drawing.Size(33, 13);
            this.labelLocal.TabIndex = 33;
            this.labelLocal.Text = "Local";
            // 
            // textLocal
            // 
            this.textLocal.Location = new System.Drawing.Point(81, 231);
            this.textLocal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textLocal.Name = "textLocal";
            this.textLocal.Size = new System.Drawing.Size(76, 20);
            this.textLocal.TabIndex = 34;
            // 
            // labelMegaPixels
            // 
            this.labelMegaPixels.AutoSize = true;
            this.labelMegaPixels.Location = new System.Drawing.Point(17, 268);
            this.labelMegaPixels.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMegaPixels.Name = "labelMegaPixels";
            this.labelMegaPixels.Size = new System.Drawing.Size(61, 13);
            this.labelMegaPixels.TabIndex = 35;
            this.labelMegaPixels.Text = "MegaPixels";
            // 
            // labelTempo
            // 
            this.labelTempo.AutoSize = true;
            this.labelTempo.Location = new System.Drawing.Point(206, 192);
            this.labelTempo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTempo.Name = "labelTempo";
            this.labelTempo.Size = new System.Drawing.Size(40, 13);
            this.labelTempo.TabIndex = 36;
            this.labelTempo.Text = "Tempo";
            // 
            // textTempo
            // 
            this.textTempo.Location = new System.Drawing.Point(272, 186);
            this.textTempo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTempo.Mask = "99";
            this.textTempo.Name = "textTempo";
            this.textTempo.Size = new System.Drawing.Size(68, 20);
            this.textTempo.TabIndex = 37;
            // 
            // textVolume
            // 
            this.textVolume.Location = new System.Drawing.Point(81, 266);
            this.textVolume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textVolume.Name = "textVolume";
            this.textVolume.Size = new System.Drawing.Size(76, 20);
            this.textVolume.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSim);
            this.groupBox1.Controls.Add(this.rbNao);
            this.groupBox1.Location = new System.Drawing.Point(207, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 100);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Possui Legenda";
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 395);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textVolume);
            this.Controls.Add(this.textTempo);
            this.Controls.Add(this.labelTempo);
            this.Controls.Add(this.labelMegaPixels);
            this.Controls.Add(this.textLocal);
            this.Controls.Add(this.labelLocal);
            this.Controls.Add(this.cbIdioma);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textMegaPixels);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textDuracao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFormato);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelProcurar);
            this.Controls.Add(this.labelDuracao);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioFoto);
            this.Controls.Add(this.radioVideo);
            this.Controls.Add(this.radioMusica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "TelaCadastro";
            this.Text = "Cadastro de Mídia";
            this.Load += new System.EventHandler(this.TelaCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioMusica;
        private System.Windows.Forms.RadioButton radioVideo;
        private System.Windows.Forms.RadioButton radioFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox textId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelDuracao;
        private System.Windows.Forms.Label labelProcurar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cbFormato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox textDuracao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox textMegaPixels;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbIdioma;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.Label labelLocal;
        private System.Windows.Forms.TextBox textLocal;
        private System.Windows.Forms.Label labelMegaPixels;
        private System.Windows.Forms.Label labelTempo;
        private System.Windows.Forms.MaskedTextBox textTempo;
        private System.Windows.Forms.MaskedTextBox textVolume;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}