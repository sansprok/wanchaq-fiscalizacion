using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCONVAL
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
            //Application.Run(new frmPrincipal());
            // Application.Run(new frmControlDeuda());
            //Application.Run(new frmCoactivaControl());
            // Application.Run(new frmResolucion());
            //Application.Run(new frmGenerarRDByCodigo());
            Application.Run(new frmListaRDs());
           // Application.Run(new frmGenerarRDByCodigo("00005511z", "2019","MPRADO"));
            //Application.Run(new FrmReportCrisResolucionIniciocs(1700, "00002295H","1"));
        }
    }
}
