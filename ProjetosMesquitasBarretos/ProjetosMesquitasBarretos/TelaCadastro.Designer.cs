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
            this.label5 = new System.Windows.Forms.Label();
            this.textAno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textAlbum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioMusica
            // 
            this.radioMusica.AutoSize = true;
            this.radioMusica.Location = new System.Drawing.Point(30, 64);
            this.radioMusica.Name = "radioMusica";
            this.radioMusica.Size = new System.Drawing.Size(84, 24);
            this.radioMusica.TabIndex = 0;
            this.radioMusica.TabStop = true;
            this.radioMusica.Text = "Música";
            this.radioMusica.UseVisualStyleBackColor = true;
            // 
            // radioVideo
            // 
            this.radioVideo.AutoSize = true;
            this.radioVideo.Location = new System.Drawing.Point(284, 64);
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
            this.radioFoto.Location = new System.Drawing.Point(559, 64);
            this.radioFoto.Name = "radioFoto";
            this.radioFoto.Size = new System.Drawing.Size(67, 24);
            this.radioFoto.TabIndex = 2;
            this.radioFoto.TabStop = true;
            this.radioFoto.Text = "Foto";
            this.radioFoto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha a Mídia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(71, 161);
            this.textId.Mask = "999999";
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 26);
            this.textId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição";
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(338, 161);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(288, 26);
            this.textDescricao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(121, 241);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(288, 26);
            this.textNome.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ano";
            // 
            // textAno
            // 
            this.textAno.Location = new System.Drawing.Point(121, 299);
            this.textAno.Name = "textAno";
            this.textAno.Size = new System.Drawing.Size(288, 26);
            this.textAno.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Album";
            // 
            // textAlbum
            // 
            this.textAlbum.Location = new System.Drawing.Point(121, 356);
            this.textAlbum.Name = "textAlbum";
            this.textAlbum.Size = new System.Drawing.Size(288, 26);
            this.textAlbum.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Artista";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 421);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 26);
            this.textBox1.TabIndex = 15;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 608);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textAlbum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textAno);
            this.Controls.Add(this.label5);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastro";
            this.Text = "Cadastro de Mídia";
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textAlbum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}