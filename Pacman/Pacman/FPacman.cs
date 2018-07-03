using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class FPacman : Form
    {
        OPacman oPacman;
        Usuario usuarioActivo;
        Graphics tableroGrafico;
        int dirX = 0, dirY = 0;
        bool ejeX = true, ejeY = true;

        public FPacman(Usuario usuarioActivo)
        {
            this.usuarioActivo = usuarioActivo;
            InitializeComponent();
            this.tableroGrafico = pictureBox1.CreateGraphics();
            oPacman = new OPacman(320, 220);
        }

        private void FPacman_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tableroGrafico.Clear(Color.White);
            oPacman.mostrarEnPantalla(tableroGrafico);
        }
    }
}
