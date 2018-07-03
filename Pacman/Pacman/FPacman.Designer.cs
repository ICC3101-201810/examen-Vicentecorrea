namespace Pacman
{
    partial class FPacman
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.texto_titulo_puntaje = new System.Windows.Forms.Label();
            this.texto_titulo_puntaje_actual = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(41, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 460);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // texto_titulo_puntaje
            // 
            this.texto_titulo_puntaje.AutoSize = true;
            this.texto_titulo_puntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.texto_titulo_puntaje.Location = new System.Drawing.Point(37, 24);
            this.texto_titulo_puntaje.Name = "texto_titulo_puntaje";
            this.texto_titulo_puntaje.Size = new System.Drawing.Size(85, 20);
            this.texto_titulo_puntaje.TabIndex = 1;
            this.texto_titulo_puntaje.Text = "PUNTAJE:";
            // 
            // texto_titulo_puntaje_actual
            // 
            this.texto_titulo_puntaje_actual.AutoSize = true;
            this.texto_titulo_puntaje_actual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.texto_titulo_puntaje_actual.Location = new System.Drawing.Point(118, 24);
            this.texto_titulo_puntaje_actual.Name = "texto_titulo_puntaje_actual";
            this.texto_titulo_puntaje_actual.Size = new System.Drawing.Size(158, 20);
            this.texto_titulo_puntaje_actual.TabIndex = 2;
            this.texto_titulo_puntaje_actual.Text = "texto_puntaje_actual";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FPacman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.texto_titulo_puntaje_actual);
            this.Controls.Add(this.texto_titulo_puntaje);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FPacman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacman";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FPacman_FormClosed);
            this.Load += new System.EventHandler(this.FPacman_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FPacman_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label texto_titulo_puntaje;
        private System.Windows.Forms.Label texto_titulo_puntaje_actual;
        private System.Windows.Forms.Timer timer1;
    }
}