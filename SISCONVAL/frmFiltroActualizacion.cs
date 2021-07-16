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
    public partial class frmFiltroActualizacion : Form
    {
        int paniodesde;
        int paniohasta;
        int panioresolucion;
        string poperador;
        string pidciudadano;
        int pnroresolucion;
        ValoresDataContext BD = new ValoresDataContext(); 
        public frmFiltroActualizacion(int aniodesde, int aniohasta, int nroresolucion,int anioresoluicion, string operador, string idciudadano)
        {
            InitializeComponent();
            paniodesde = aniodesde;
            paniohasta = aniohasta;
            panioresolucion = anioresoluicion;
            poperador = operador;
            pnroresolucion = nroresolucion;
            pidciudadano = idciudadano;
            txtAnioDesde.Text = aniodesde.ToString();
            txtAnioHasta.Text = aniohasta.ToString();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            paniodesde = int.Parse(txtAnioDesde.Text);
            paniohasta = int.Parse(txtAnioHasta.Text);
            BD.PA_CONTROLDEUDA_ACTUALIZARVALOR_INDIVIDUAL(panioresolucion, pidciudadano, pnroresolucion, poperador, paniodesde, paniohasta);
            MessageBox.Show("SE ACTUALIZO EL REGISTRO");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtAnioDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
