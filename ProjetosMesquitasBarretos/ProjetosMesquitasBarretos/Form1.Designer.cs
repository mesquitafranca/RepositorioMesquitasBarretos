﻿namespace ProjetosMesquitasBarretos
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
            this.anoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEscolherMidia = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ordemAlfabéticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.álbunsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEscolherMusica = new System.Windows.Forms.Button();
            this.textanopesq = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnreproducao = new System.Windows.Forms.Button();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pilhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeMídiaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1430, 33);
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
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1034, 592);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 592);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelNomeNaTela
            // 
            this.labelNomeNaTela.AutoSize = true;
            this.labelNomeNaTela.Location = new System.Drawing.Point(14, 638);
            this.labelNomeNaTela.Name = "labelNomeNaTela";
            this.labelNomeNaTela.Size = new System.Drawing.Size(145, 20);
            this.labelNomeNaTela.TabIndex = 7;
            this.labelNomeNaTela.Text = "Selecione a Mídia...";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(1054, 408);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(364, 204);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.bToolStripMenuItem,
            this.cToolStripMenuItem,
            this.fotoToolStripMenuItem,
            this.anoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 154);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.aToolStripMenuItem.Text = "Todas as Mídias ";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.bToolStripMenuItem.Text = "Música";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.cToolStripMenuItem.Text = "Vídeo";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // fotoToolStripMenuItem
            // 
            this.fotoToolStripMenuItem.Name = "fotoToolStripMenuItem";
            this.fotoToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.fotoToolStripMenuItem.Text = "Foto";
            this.fotoToolStripMenuItem.Click += new System.EventHandler(this.fotoToolStripMenuItem_Click);
            // 
            // anoToolStripMenuItem
            // 
            this.anoToolStripMenuItem.Name = "anoToolStripMenuItem";
            this.anoToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.anoToolStripMenuItem.Text = "Ano";
            this.anoToolStripMenuItem.Click += new System.EventHandler(this.anoToolStripMenuItem_Click);
            // 
            // btnEscolherMidia
            // 
            this.btnEscolherMidia.ContextMenuStrip = this.contextMenuStrip1;
            this.btnEscolherMidia.Location = new System.Drawing.Point(1054, 55);
            this.btnEscolherMidia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEscolherMidia.Name = "btnEscolherMidia";
            this.btnEscolherMidia.Size = new System.Drawing.Size(189, 35);
            this.btnEscolherMidia.TabIndex = 13;
            this.btnEscolherMidia.Text = "Todas as Mídias";
            this.btnEscolherMidia.UseVisualStyleBackColor = true;
            this.btnEscolherMidia.Click += new System.EventHandler(this.btnEscolherMidia_Click);
            this.btnEscolherMidia.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnEscolherMidia_MouseUp);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordemAlfabéticaToolStripMenuItem,
            this.álbunsToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(224, 64);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // ordemAlfabéticaToolStripMenuItem
            // 
            this.ordemAlfabéticaToolStripMenuItem.Name = "ordemAlfabéticaToolStripMenuItem";
            this.ordemAlfabéticaToolStripMenuItem.Size = new System.Drawing.Size(223, 30);
            this.ordemAlfabéticaToolStripMenuItem.Text = "Ordem Alfabética";
            this.ordemAlfabéticaToolStripMenuItem.Click += new System.EventHandler(this.ordemAlfabéticaToolStripMenuItem_Click);
            // 
            // álbunsToolStripMenuItem
            // 
            this.álbunsToolStripMenuItem.Name = "álbunsToolStripMenuItem";
            this.álbunsToolStripMenuItem.Size = new System.Drawing.Size(223, 30);
            this.álbunsToolStripMenuItem.Text = "Álbuns";
            this.álbunsToolStripMenuItem.Click += new System.EventHandler(this.álbunsToolStripMenuItem_Click);
            // 
            // btnEscolherMusica
            // 
            this.btnEscolherMusica.ContextMenuStrip = this.contextMenuStrip2;
            this.btnEscolherMusica.Location = new System.Drawing.Point(1053, 100);
            this.btnEscolherMusica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEscolherMusica.Name = "btnEscolherMusica";
            this.btnEscolherMusica.Size = new System.Drawing.Size(190, 35);
            this.btnEscolherMusica.TabIndex = 15;
            this.btnEscolherMusica.Text = "Métodos de seleção";
            this.btnEscolherMusica.UseVisualStyleBackColor = true;
            this.btnEscolherMusica.Click += new System.EventHandler(this.btnEscolherMusica_Click);
            this.btnEscolherMusica.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnEscolherMusica_MouseUp);
            // 
            // textanopesq
            // 
            this.textanopesq.Location = new System.Drawing.Point(1066, 176);
            this.textanopesq.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textanopesq.Mask = "9999";
            this.textanopesq.Name = "textanopesq";
            this.textanopesq.Size = new System.Drawing.Size(112, 26);
            this.textanopesq.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1066, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ano de pesquisa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1066, 229);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnreproducao
            // 
            this.btnreproducao.ContextMenuStrip = this.contextMenuStrip3;
            this.btnreproducao.Location = new System.Drawing.Point(1070, 289);
            this.btnreproducao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnreproducao.Name = "btnreproducao";
            this.btnreproducao.Size = new System.Drawing.Size(172, 35);
            this.btnreproducao.TabIndex = 19;
            this.btnreproducao.Text = "Tipos de reprodução";
            this.btnreproducao.UseVisualStyleBackColor = true;
            this.btnreproducao.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnreproducao_MouseUp);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilhaToolStripMenuItem,
            this.filaToolStripMenuItem,
            this.filaToolStripMenuItem1});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(122, 94);
            // 
            // pilhaToolStripMenuItem
            // 
            this.pilhaToolStripMenuItem.Name = "pilhaToolStripMenuItem";
            this.pilhaToolStripMenuItem.Size = new System.Drawing.Size(121, 30);
            this.pilhaToolStripMenuItem.Text = "Pilha";
            this.pilhaToolStripMenuItem.Click += new System.EventHandler(this.pilhaToolStripMenuItem_Click);
            // 
            // filaToolStripMenuItem
            // 
            this.filaToolStripMenuItem.Name = "filaToolStripMenuItem";
            this.filaToolStripMenuItem.Size = new System.Drawing.Size(121, 30);
            this.filaToolStripMenuItem.Text = "Fila";
            this.filaToolStripMenuItem.Click += new System.EventHandler(this.filaToolStripMenuItem_Click);
            // 
            // filaToolStripMenuItem1
            // 
            this.filaToolStripMenuItem1.Name = "filaToolStripMenuItem1";
            this.filaToolStripMenuItem1.Size = new System.Drawing.Size(121, 30);
            this.filaToolStripMenuItem1.Text = "Lista";
            this.filaToolStripMenuItem1.Click += new System.EventHandler(this.filaToolStripMenuItem1_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(1066, 346);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(112, 29);
            this.btnIniciar.TabIndex = 20;
            this.btnIniciar.Text = "Reproduzir";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1222, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1252, 176);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 28);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1249, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Selecione o álbum";
            // 
            // Tela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 665);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnreproducao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textanopesq);
            this.Controls.Add(this.btnEscolherMusica);
            this.Controls.Add(this.btnEscolherMidia);
            this.Controls.Add(this.listBox1);
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
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnEscolherMusica;
        private System.Windows.Forms.ToolStripMenuItem anoToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox textanopesq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnreproducao;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem pilhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filaToolStripMenuItem1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}

