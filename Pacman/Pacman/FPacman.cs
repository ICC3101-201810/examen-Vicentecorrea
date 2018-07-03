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
        OFantasma oFantasma;
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
            oFantasma = new OFantasma();
            texto_titulo_puntaje_actual.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tableroGrafico.Clear(Color.White);
            oPacman.mostrarEnPantalla(tableroGrafico);
            oFruta.mostrarEnPantalla(tableroGrafico);
            oFantasma.mostrarEnPantalla(tableroGrafico);
            mover();

            if (oFruta.hayColision(oPacman))
            {
                oFruta.rePosicionar();
                usuarioActivo.puntaje += 15;
                texto_titulo_puntaje_actual.Text = usuarioActivo.puntaje.ToString();
            }

            if (oFantasma.hayColision(oPacman))
            { 
                MessageBox.Show($"Nombre de usuario: {usuarioActivo.nombre}\n" +
                    $"Puntaje obtenido: {usuarioActivo.puntaje}", "¡Perdiste!");
                this.Hide();
                Aplicacion.SerializarTodo();
                timer1.Enabled = false;
                
            }

        }

        private void FPacman_FormClosed(object sender, FormClosedEventArgs e)
        {
            Aplicacion.SerializarTodo();
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
