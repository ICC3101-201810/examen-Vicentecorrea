using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    [Serializable()]
    public class Usuario
    {
        public string nombre;
        public int puntaje;

        public Usuario(string nombre)
        {
            this.nombre = nombre;
        }

    }
}
