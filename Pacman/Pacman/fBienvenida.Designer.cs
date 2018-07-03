namespace Pacman
{
    partial class FBienvenida
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
            this.texto_bienvenida = new System.Windows.Forms.Label();
            this.texto_ingresa_nombre = new System.Windows.Forms.Label();
            this.textBox_nombre_usuario = new System.Windows.Forms.TextBox();
            this.Boton_ingresar = new System.Windows.Forms.Button();
            this.linkLabel_tabla_de_posiciones = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // texto_bienvenida
            // 
            this.texto_bienvenida.AutoSize = true;
            this.texto_bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.texto_bienvenida.Location = new System.Drawing.Point(46, 25);
            this.texto_bienvenida.Name = "texto_bienvenida";
            this.texto_bienvenida.Size = new System.Drawing.Size(390, 46);
            this.texto_bienvenida.TabIndex = 0;
            this.texto_bienvenida.Text = "¡Bienvenido Usuario!";
            // 
            // texto_ingresa_nombre
            // 
            this.texto_ingresa_nombre.AutoSize = true;
            this.texto_ingresa_nombre.Location = new System.Drawing.Point(51, 106);
            this.texto_ingresa_nombre.Name = "texto_ingresa_nombre";
            this.texto_ingresa_nombre.Size = new System.Drawing.Size(95, 13);
            this.texto_ingresa_nombre.TabIndex = 1;
            this.texto_ingresa_nombre.Text = "Ingresa tu nombre:";
            // 
            // textBox_nombre_usuario
            // 
            this.textBox_nombre_usuario.Location = new System.Drawing.Point(152, 103);
            this.textBox_nombre_usuario.Name = "textBox_nombre_usuario";
            this.textBox_nombre_usuario.Size = new System.Drawing.Size(174, 20);
            this.textBox_nombre_usuario.TabIndex = 2;
            // 
            // Boton_ingresar
            // 
            this.Boton_ingresar.Location = new System.Drawing.Point(343, 101);
            this.Boton_ingresar.Name = "Boton_ingresar";
            this.Boton_ingresar.Size = new System.Drawing.Size(75, 23);
            this.Boton_ingresar.TabIndex = 3;
            this.Boton_ingresar.Text = "Ingresar";
            this.Boton_ingresar.UseVisualStyleBackColor = true;
            this.Boton_ingresar.Click += new System.EventHandler(this.Boton_ingresar_Click);
            // 
            // linkLabel_tabla_de_posiciones
            // 
            this.linkLabel_tabla_de_posiciones.AutoSize = true;
            this.linkLabel_tabla_de_posiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLabel_tabla_de_posiciones.Location = new System.Drawing.Point(148, 152);
            this.linkLabel_tabla_de_posiciones.Name = "linkLabel_tabla_de_posiciones";
            this.linkLabel_tabla_de_posiciones.Size = new System.Drawing.Size(174, 20);
            this.linkLabel_tabla_de_posiciones.TabIndex = 4;
            this.linkLabel_tabla_de_posiciones.TabStop = true;
            this.linkLabel_tabla_de_posiciones.Text = "Ver tabla de posiciones";
            // 
            // FBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 227);
            this.Controls.Add(this.linkLabel_tabla_de_posiciones);
            this.Controls.Add(this.Boton_ingresar);
            this.Controls.Add(this.textBox_nombre_usuario);
            this.Controls.Add(this.texto_ingresa_nombre);
            this.Controls.Add(this.texto_bienvenida);
            this.Name = "FBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FBienvenida_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto_bienvenida;
        private System.Windows.Forms.Label texto_ingresa_nombre;
        private System.Windows.Forms.TextBox textBox_nombre_usuario;
        private System.Windows.Forms.Button Boton_ingresar;
        private System.Windows.Forms.LinkLabel linkLabel_tabla_de_posiciones;
    }
}