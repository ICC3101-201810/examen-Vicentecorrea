using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class OFantasma : ObjetoGrafico
    {
        public OFantasma()
        {
            this.posX = posAleatoria(17);
            this.posY = posAleatoria(11);
        }

        public void mostrarEnPantalla(Graphics tableroGrafico)
        {
            //string ruta = Path.GetFullPath(@"..\..\..\..");
            //string rutaElemento = ruta + "/pacman-up.png";
            //Image icono = Image.FromFile(rutaElemento);

            tableroGrafico.FillEllipse(new SolidBrush(Color.Red), this.posX, this.posY, this.tamano, this.tamano);
        }

    }
}
