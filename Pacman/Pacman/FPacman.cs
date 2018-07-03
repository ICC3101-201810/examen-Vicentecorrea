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
        Usuario usuarioActivo;

        public FPacman(Usuario usuarioActivo)
        {
            this.usuarioActivo = usuarioActivo;
            InitializeComponent();
        }
    }
}
