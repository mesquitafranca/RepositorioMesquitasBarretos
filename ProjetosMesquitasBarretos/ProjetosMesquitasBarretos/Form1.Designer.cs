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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroDeMídiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçãoSobreAMídiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNomeNaTela = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEscolherMidia = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ordemAlfabéticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.álbunsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEscolherMusica = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(703, 265);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(126, 134);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.cToolStripMenuItem,
            this.fotoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aToolStripMenuItem.Text = "Todas as Mídias ";
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.bToolStripMenuItem.Text = "Música";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cToolStripMenuItem.Text = "Vídeo";
            // 
            // fotoToolStripMenuItem
            // 
            this.fotoToolStripMenuItem.Name = "fotoToolStripMenuItem";
            this.fotoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.fotoToolStripMenuItem.Text = "Foto";
            // 
            // btnEscolherMidia
            // 
            this.btnEscolherMidia.ContextMenuStrip = this.contextMenuStrip1;
            this.btnEscolherMidia.Location = new System.Drawing.Point(703, 36);
            this.btnEscolherMidia.Name = "btnEscolherMidia";
            this.btnEscolherMidia.Size = new System.Drawing.Size(126, 23);
            this.btnEscolherMidia.TabIndex = 13;
            this.btnEscolherMidia.Text = "Todas as Mídias";
            this.btnEscolherMidia.UseVisualStyleBackColor = true;
            this.btnEscolherMidia.Click += new System.EventHandler(this.btnEscolherMidia_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordemAlfabéticaToolStripMenuItem,
            this.álbunsToolStripMenuItem,
            this.artistasToolStripMenuItem,
            this.playlistsToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(168, 92);
            // 
            // ordemAlfabéticaToolStripMenuItem
            // 
            this.ordemAlfabéticaToolStripMenuItem.Name = "ordemAlfabéticaToolStripMenuItem";
            this.ordemAlfabéticaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ordemAlfabéticaToolStripMenuItem.Text = "Ordem Alfabética";
            // 
            // álbunsToolStripMenuItem
            // 
            this.álbunsToolStripMenuItem.Name = "álbunsToolStripMenuItem";
            this.álbunsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.álbunsToolStripMenuItem.Text = "Álbuns";
            // 
            // artistasToolStripMenuItem
            // 
            this.artistasToolStripMenuItem.Name = "artistasToolStripMenuItem";
            this.artistasToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.artistasToolStripMenuItem.Text = "Artistas";
            // 
            // playlistsToolStripMenuItem
            // 
            this.playlistsToolStripMenuItem.Name = "playlistsToolStripMenuItem";
            this.playlistsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.playlistsToolStripMenuItem.Text = "Playlists";
            // 
            // btnEscolherMusica
            // 
            this.btnEscolherMusica.ContextMenuStrip = this.contextMenuStrip2;
            this.btnEscolherMusica.Location = new System.Drawing.Point(702, 65);
            this.btnEscolherMusica.Name = "btnEscolherMusica";
            this.btnEscolherMusica.Size = new System.Drawing.Size(127, 23);
            this.btnEscolherMusica.TabIndex = 15;
            this.btnEscolherMusica.Text = "Ordem Alfabética";
            this.btnEscolherMusica.UseVisualStyleBackColor = true;
            // 
            // Tela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 432);
            this.Controls.Add(this.btnEscolherMusica);
            this.Controls.Add(this.btnEscolherMidia);
            this.Controls.Add(this.listBox1);
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
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.Button btnEscolherMidia;
        private System.Windows.Forms.ToolStripMenuItem fotoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ordemAlfabéticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem álbunsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistsToolStripMenuItem;
        private System.Windows.Forms.Button btnEscolherMusica;
    }
}

