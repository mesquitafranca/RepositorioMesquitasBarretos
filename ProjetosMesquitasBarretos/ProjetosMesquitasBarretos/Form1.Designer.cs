namespace ProjetosMesquitasBarretos
{
    partial class Form1
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
            this.Botão = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Botão
            // 
            this.Botão.Location = new System.Drawing.Point(103, 76);
            this.Botão.Name = "Botão";
            this.Botão.Size = new System.Drawing.Size(196, 127);
            this.Botão.TabIndex = 0;
            this.Botão.Text = "Botão";
            this.Botão.UseVisualStyleBackColor = true;
            this.Botão.Click += new System.EventHandler(this.Botão_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 306);
            this.Controls.Add(this.Botão);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Botão;
    }
}

