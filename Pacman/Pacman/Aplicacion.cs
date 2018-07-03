using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class Aplicacion
    {
        public static List<Usuario> usuarios = new List<Usuario>();

        public static Usuario IniciarSesion(string nombre)
        {
            foreach (Usuario usuarioExistente in usuarios)
            {
                if (usuarioExistente.nombre == nombre)
                {
                    return usuarioExistente;
                }
            }
            Usuario nuevoUsuario = new Usuario(nombre);
            return nuevoUsuario;
        }
    }
}
