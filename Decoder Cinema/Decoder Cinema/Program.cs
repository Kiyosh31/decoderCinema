﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decoder_Cinema
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// Creando nueva Rama para la interfaz Gráfica
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
        }
    }
}
