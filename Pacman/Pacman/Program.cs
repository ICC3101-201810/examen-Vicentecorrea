﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Aplicacion.DeSerializarTodo();
            FBienvenida fBienvenida = new FBienvenida();
            CIngreso cIngreso = new CIngreso(fBienvenida);
            Application.Run(fBienvenida);
        }
    }
}
