using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Pacman
{
    class OPacman : ObjetoGrafico
    {

        public OPacman(int posX,int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }

        public void mostrarEnPantalla(Graphics tableroGrafico)
        {
            string ruta = Path.GetFullPath(@"..\..\..\..");
            string rutaElemento = ruta + "/pacman-up.png";
            Image icono = Image.FromFile(rutaElemento);
            tableroGrafico.FillRectangle(new SolidBrush(Color.Blue), this.posX, this.posY, this.tamano, this.tamano);
        }

        public void mover(int x, int y)
        {
            this.posX = x;
            this.posY = y;
        }

        public int getX()
        {
            return this.posX;
        }
        public int getY()
        {
            return this.posY;
        }
    }
}
