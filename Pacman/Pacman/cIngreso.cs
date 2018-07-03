using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class CIngreso
    {
        FBienvenida fBienvenida;

        public CIngreso(FBienvenida fBienvenida)
        {
            this.fBienvenida = fBienvenida;
            this.fBienvenida.OnIngresar += FBienvenida_OnIngresar;
        }

        private void FBienvenida_OnIngresar(object sender, IngresarEventArgs iea)
        {
            Usuario usuarioActivo = Aplicacion.IniciarSesion(iea.nombreUsuarioIngreso);
            FPacman fPacman = new FPacman(usuarioActivo);
            fPacman.Show();
            //this.fBienvenida.Hide();
        }
    }
}
