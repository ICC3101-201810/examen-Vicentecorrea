using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public enum TipoDeFruta { guinda, uva }

    class OFruta : ObjetoGrafico
    {
        public OFruta()
        {
            this.posX = posAleatoria(30);
            this.posY = posAleatoria(23);
        }

        public void mostrarEnPantalla(Graphics tableroGrafico)
        {
            string ruta = Path.GetFullPath(@"..\..\..\..");
            string rutaElemento = ruta + "/pacman-up.png";
            Image icono = Image.FromFile(rutaElemento);
            
            tableroGrafico.FillEllipse(new SolidBrush(Color.Red), this.posX, this.posY, this.tamano, this.tamano);
        }

        public void rePosicionar()
        {
            this.posX = posAleatoria(30);
            this.posY = posAleatoria(23);
        }

        public int posAleatoria(int max)
        {
            Random random = new Random();
            int num = random.Next(0, max) * 20;
            return num;
        }
    }
}
