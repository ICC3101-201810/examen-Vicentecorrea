using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    abstract class ObjetoGrafico
    {
        int posX, posY, tamano;

        public ObjetoGrafico()
        {
            this.tamano = 10;
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
    }
}
