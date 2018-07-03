using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pacman
{
    public partial class FBienvenida : Form
    {
        public event EventHandler<IngresarEventArgs> OnIngresar;

        public FBienvenida()
        {
            InitializeComponent();
            

        }

        private void Boton_ingresar_Click(object sender, EventArgs e)
        {
            if (textBox_nombre_usuario.Text == "")
            {
                MessageBox.Show("Falta rellenar un campo", "Error de ingreso");
                return;
            }
            IngresarEventArgs ingresarEventArgs = new IngresarEventArgs();
            ingresarEventArgs.nombreUsuarioIngreso = textBox_nombre_usuario.Text;
            OnIngresar(this, ingresarEventArgs);
        }

        private void FBienvenida_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
