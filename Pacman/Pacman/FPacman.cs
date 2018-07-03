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
        OFruta oFruta;
        Usuario usuarioActivo;
        Graphics tableroGrafico;
        int dirX = 0, dirY = 0;
        //bool ejeX = true, ejeY = true;

        public FPacman(Usuario usuarioActivo)
        {
            this.usuarioActivo = usuarioActivo;
            InitializeComponent();
            this.tableroGrafico = pictureBox1.CreateGraphics();
            oPacman = new OPacman(320, 220);
            oFruta = new OFruta();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tableroGrafico.Clear(Color.White);
            oPacman.mostrarEnPantalla(tableroGrafico);
            oFruta.mostrarEnPantalla(tableroGrafico);
            mover();

            if (oFruta.hayColision(oPacman))
            {
                oFruta.rePosicionar();
            }

        }
        private void timer_fruta_Tick(object sender, EventArgs e)
        {
            
        }

        private void FPacman_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FPacman_Load(object sender, EventArgs e)
        {

        }

        private void FPacman_KeyDown(object sender, KeyEventArgs e)
        {

                if (e.KeyCode == Keys.Up)
                {
                    dirY = -oPacman.getTamano();
                    dirX = 0;
                }
                if (e.KeyCode == Keys.Down)
                {
                    dirY = oPacman.getTamano();
                    dirX = 0;
                }

                if (e.KeyCode == Keys.Right)
                {
                    dirY = 0;
                    dirX = oPacman.getTamano();
                }
                if (e.KeyCode == Keys.Left)
                {
                    dirY = 0;
                    dirX = -oPacman.getTamano();
                }

        }

        

        public void mover()
        {
            oPacman.nuevoLugar(oPacman.getX() + dirX, oPacman.getY() + dirY);
        }
    }
}
