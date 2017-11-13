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
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNomeNaTela = new System.Windows.Forms.Label();
            this.novaPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdMusicaPrincipal = new System.Windows.Forms.RadioButton();
            this.rdVideosPrincipal = new System.Windows.Forms.RadioButton();
            this.rdFotosPrincipal = new System.Windows.Forms.RadioButton();
            this.rdTodasMidias = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1261, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroDeMídiaToolStripMenuItem
            // 
            this.cadastroDeMídiaToolStripMenuItem.Name = "cadastroDeMídiaToolStripMenuItem";
            this.cadastroDeMídiaToolStripMenuItem.Size = new System.Drawing.Size(169, 29);
            this.cadastroDeMídiaToolStripMenuItem.Text = "Cadastro de Mídia";
            this.cadastroDeMídiaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeMídiaToolStripMenuItem_Click);
            // 
            // informaçãoSobreAMídiaToolStripMenuItem
            // 
            this.informaçãoSobreAMídiaToolStripMenuItem.Name = "informaçãoSobreAMídiaToolStripMenuItem";
            this.informaçãoSobreAMídiaToolStripMenuItem.Size = new System.Drawing.Size(236, 29);
            this.informaçãoSobreAMídiaToolStripMenuItem.Text = "Informações sobre a Mídia";
            this.informaçãoSobreAMídiaToolStripMenuItem.Click += new System.EventHandler(this.informaçãoSobreAMídiaToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1033, 592);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 592);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelNomeNaTela
            // 
            this.labelNomeNaTela.AutoSize = true;
            this.labelNomeNaTela.Location = new System.Drawing.Point(13, 637);
            this.labelNomeNaTela.Name = "labelNomeNaTela";
            this.labelNomeNaTela.Size = new System.Drawing.Size(145, 20);
            this.labelNomeNaTela.TabIndex = 7;
            this.labelNomeNaTela.Text = "Selecione a Mídia...";
            // 
            // novaPlaylistToolStripMenuItem
            // 
            this.novaPlaylistToolStripMenuItem.Name = "novaPlaylistToolStripMenuItem";
            this.novaPlaylistToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.novaPlaylistToolStripMenuItem.Text = "Nova Playlist";
            this.novaPlaylistToolStripMenuItem.Click += new System.EventHandler(this.novaPlaylistToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdTodasMidias);
            this.panel2.Controls.Add(this.rdFotosPrincipal);
            this.panel2.Controls.Add(this.rdVideosPrincipal);
            this.panel2.Controls.Add(this.rdMusicaPrincipal);
            this.panel2.Location = new System.Drawing.Point(1052, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 196);
            this.panel2.TabIndex = 8;
            // 
            // rdMusicaPrincipal
            // 
            this.rdMusicaPrincipal.AutoSize = true;
            this.rdMusicaPrincipal.Location = new System.Drawing.Point(106, 56);
            this.rdMusicaPrincipal.Name = "rdMusicaPrincipal";
            this.rdMusicaPrincipal.Size = new System.Drawing.Size(84, 24);
            this.rdMusicaPrincipal.TabIndex = 0;
            this.rdMusicaPrincipal.TabStop = true;
            this.rdMusicaPrincipal.Text = "Música";
            this.rdMusicaPrincipal.UseVisualStyleBackColor = true;
            // 
            // rdVideosPrincipal
            // 
            this.rdVideosPrincipal.AutoSize = true;
            this.rdVideosPrincipal.Location = new System.Drawing.Point(106, 15);
            this.rdVideosPrincipal.Name = "rdVideosPrincipal";
            this.rdVideosPrincipal.Size = new System.Drawing.Size(83, 24);
            this.rdVideosPrincipal.TabIndex = 1;
            this.rdVideosPrincipal.TabStop = true;
            this.rdVideosPrincipal.Text = "Vídeos";
            this.rdVideosPrincipal.UseVisualStyleBackColor = true;
            // 
            // rdFotosPrincipal
            // 
            this.rdFotosPrincipal.AutoSize = true;
            this.rdFotosPrincipal.Location = new System.Drawing.Point(3, 56);
            this.rdFotosPrincipal.Name = "rdFotosPrincipal";
            this.rdFotosPrincipal.Size = new System.Drawing.Size(75, 24);
            this.rdFotosPrincipal.TabIndex = 2;
            this.rdFotosPrincipal.TabStop = true;
            this.rdFotosPrincipal.Text = "Fotos";
            this.rdFotosPrincipal.UseVisualStyleBackColor = true;
            // 
            // rdTodasMidias
            // 
            this.rdTodasMidias.AutoSize = true;
            this.rdTodasMidias.Checked = true;
            this.rdTodasMidias.Location = new System.Drawing.Point(3, 15);
            this.rdTodasMidias.Name = "rdTodasMidias";
            this.rdTodasMidias.Size = new System.Drawing.Size(78, 24);
            this.rdTodasMidias.TabIndex = 3;
            this.rdTodasMidias.TabStop = true;
            this.rdTodasMidias.Text = "Todos";
            this.rdTodasMidias.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(1055, 408);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 144);
            this.listBox1.TabIndex = 9;
            // 
            // Tela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 664);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelNomeNaTela);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}

