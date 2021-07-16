using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCONVAL
{
    public partial class frmReporteResolucion : Form
    {
        int pANIORESO, pNRORESO;
        public frmReporteResolucion(int ANIORESO, int NRORESO )
        {
            InitializeComponent();
            // this.Controls.Add(this.reportViewer1);
            //reportViewer1.Dock = DockStyle.Fill;
            //reportViewer1.
            rpvResolucion.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            rpvResolucion.ShowZoomControl = true;
            pANIORESO = ANIORESO;
            pNRORESO = NRORESO;
            
        }

        private void frmResolucion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DS_VALORES.PA_CONTROLDEUDA_DATOSVALOR' Puede moverla o quitarla según sea necesario.
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PA_CONTROLDEUDA_DATOSVALORTableAdapter.Fill(this.DS_VALORES.PA_CONTROLDEUDA_DATOSVALOR,pANIORESO,pNRORESO);

            this.rpvResolucion.RefreshReport();

            
        }
    }
}
