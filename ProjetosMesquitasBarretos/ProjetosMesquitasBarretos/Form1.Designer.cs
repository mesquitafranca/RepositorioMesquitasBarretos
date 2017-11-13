namespace ProjetosMesquitasBarretos
{
    partial class Tela1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroDeMídiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçãoSobreAMídiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNomeNaTela = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdTodasMidias = new System.Windows.Forms.RadioButton();
            this.rdFotosPrincipal = new System.Windows.Forms.RadioButton();
            this.rdVideosPrincipal = new System.Windows.Forms.RadioButton();
            this.rdMusicaPrincipal = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeMídiaToolStripMenuItem,
            this.informaçãoSobreAMídiaToolStripMenuItem,
            this.novaPlaylistToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDeMídiaToolStripMenuItem
            // 
            this.cadastroDeMídiaToolStripMenuItem.Name = "cadastroDeMídiaToolStripMenuItem";
            this.cadastroDeMídiaToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.cadastroDeMídiaToolStripMenuItem.Text = "Cadastro de Mídia";
            this.cadastroDeMídiaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeMídiaToolStripMenuItem_Click);
            // 
            // informaçãoSobreAMídiaToolStripMenuItem
            // 
            this.informaçãoSobreAMídiaToolStripMenuItem.Name = "informaçãoSobreAMídiaToolStripMenuItem";
            this.informaçãoSobreAMídiaToolStripMenuItem.Size = new System.Drawing.Size(159, 20);
            this.informaçãoSobreAMídiaToolStripMenuItem.Text = "Informações sobre a Mídia";
            this.informaçãoSobreAMídiaToolStripMenuItem.Click += new System.EventHandler(this.informaçãoSobreAMídiaToolStripMenuItem_Click);
            // 
            // novaPlaylistToolStripMenuItem
            // 
            this.novaPlaylistToolStripMenuItem.Name = "novaPlaylistToolStripMenuItem";
            this.novaPlaylistToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.novaPlaylistToolStripMenuItem.Text = "Nova Playlist";
            this.novaPlaylistToolStripMenuItem.Click += new System.EventHandler(this.novaPlaylistToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(689, 385);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Location = new System.Drawing.Point(8, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 385);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelNomeNaTela
            // 
            this.labelNomeNaTela.AutoSize = true;
            this.labelNomeNaTela.Location = new System.Drawing.Point(9, 414);
            this.labelNomeNaTela.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomeNaTela.Name = "labelNomeNaTela";
            this.labelNomeNaTela.Size = new System.Drawing.Size(102, 13);
            this.labelNomeNaTela.TabIndex = 7;
            this.labelNomeNaTela.Text = "Selecione a Mídia...";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdTodasMidias);
            this.panel2.Controls.Add(this.rdFotosPrincipal);
            this.panel2.Controls.Add(this.rdVideosPrincipal);
            this.panel2.Controls.Add(this.rdMusicaPrincipal);
            this.panel2.Location = new System.Drawing.Point(701, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 70);
            this.panel2.TabIndex = 8;
            // 
            // rdTodasMidias
            // 
            this.rdTodasMidias.AutoSize = true;
            this.rdTodasMidias.Checked = true;
            this.rdTodasMidias.Location = new System.Drawing.Point(2, 10);
            this.rdTodasMidias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdTodasMidias.Name = "rdTodasMidias";
            this.rdTodasMidias.Size = new System.Drawing.Size(55, 17);
            this.rdTodasMidias.TabIndex = 3;
            this.rdTodasMidias.TabStop = true;
            this.rdTodasMidias.Text = "Todos";
            this.rdTodasMidias.UseVisualStyleBackColor = true;
            // 
            // rdFotosPrincipal
            // 
            this.rdFotosPrincipal.AutoSize = true;
            this.rdFotosPrincipal.Location = new System.Drawing.Point(2, 36);
            this.rdFotosPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdFotosPrincipal.Name = "rdFotosPrincipal";
            this.rdFotosPrincipal.Size = new System.Drawing.Size(51, 17);
            this.rdFotosPrincipal.TabIndex = 2;
            this.rdFotosPrincipal.TabStop = true;
            this.rdFotosPrincipal.Text = "Fotos";
            this.rdFotosPrincipal.UseVisualStyleBackColor = true;
            // 
            // rdVideosPrincipal
            // 
            this.rdVideosPrincipal.AutoSize = true;
            this.rdVideosPrincipal.Location = new System.Drawing.Point(71, 10);
            this.rdVideosPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdVideosPrincipal.Name = "rdVideosPrincipal";
            this.rdVideosPrincipal.Size = new System.Drawing.Size(59, 17);
            this.rdVideosPrincipal.TabIndex = 1;
            this.rdVideosPrincipal.TabStop = true;
            this.rdVideosPrincipal.Text = "Vídeos";
            this.rdVideosPrincipal.UseVisualStyleBackColor = true;
            // 
            // rdMusicaPrincipal
            // 
            this.rdMusicaPrincipal.AutoSize = true;
            this.rdMusicaPrincipal.Location = new System.Drawing.Point(71, 36);
            this.rdMusicaPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdMusicaPrincipal.Name = "rdMusicaPrincipal";
            this.rdMusicaPrincipal.Size = new System.Drawing.Size(59, 17);
            this.rdMusicaPrincipal.TabIndex = 0;
            this.rdMusicaPrincipal.TabStop = true;
            this.rdMusicaPrincipal.Text = "Música";
            this.rdMusicaPrincipal.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(703, 265);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(130, 134);
            this.listBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Álbuns";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(701, 136);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(126, 56);
            this.listBox2.TabIndex = 11;
            // 
            // Tela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 432);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelNomeNaTela);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Tela1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MesquitasBarretos Media Player";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeMídiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNomeNaTela;
        private System.Windows.Forms.ToolStripMenuItem informaçãoSobreAMídiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaPlaylistToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdVideosPrincipal;
        private System.Windows.Forms.RadioButton rdMusicaPrincipal;
        private System.Windows.Forms.RadioButton rdTodasMidias;
        private System.Windows.Forms.RadioButton rdFotosPrincipal;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

