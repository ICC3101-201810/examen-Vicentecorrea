using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    abstract class ObjetoGrafico
    {
        protected int posX, posY, tamano;

        public ObjetoGrafico()
        {
            this.tamano = 20;
        }

        public int posAleatoria(int max)
        {
            Random random = new Random();
            int num = random.Next(0, max) * 20;
            return num;
        }


        public bool hayColision(ObjetoGrafico otroObjeto)
        {
            int difX = Math.Abs(this.posX - otroObjeto.posX);
            int difY = Math.Abs(this.posY - otroObjeto.posY);

            if ((difX >= 0 && difX <= this.tamano) && (difY >= 0 && difY <= this.tamano)) {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getX()
        {
            return this.posX;
        }
    }
}
