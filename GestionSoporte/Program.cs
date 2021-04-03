using System;
using System.Collections.Generic;
using System.Linq;
using GestionSoporte.UI;
using System.Windows.Forms;

namespace GestionSoporte
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
            Application.Run(new Frm_Principal());
        }
    }
}
