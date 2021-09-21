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
    public partial class frmObservaciones : Form
    {
        ValoresDataContext bd = new ValoresDataContext();
        string pObservaciones;
        int paniovalor;
        int pnrovalor;
        string pidciudadano;
        string ptipovalor;
        string poperador;        
        public frmObservaciones(int aniovalor,int nrovalor, string idciudadano, string tipovalor, string  operador)
        {
            paniovalor = aniovalor;
            pnrovalor = nrovalor;
            pidciudadano = idciudadano;
            ptipovalor = tipovalor;
            poperador = operador;

            InitializeComponent();

        }

        private void btnObservacion_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado = bd.PA_CONTROLDEUDA_ANULAR_VALOR(paniovalor, pnrovalor, pidciudadano, ptipovalor, txtObservaciones.Text.ToUpper(),poperador);
                if (resultado == 1)
                {
                    MessageBox.Show("ANULACION EXISTOSA");
                }
                else
                {
                    MessageBox.Show("NO SE PUEDE ELIMINAR EL VALOR POR ESTAR EN EJECUCION COACTIVA");
                }
                this.Close();
            }
            catch (Exception)
            {

                //throw;
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
