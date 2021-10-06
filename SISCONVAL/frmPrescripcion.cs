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
    public partial class Prescripcion : Form
    {
        string pidciudadano, pidusuario;
        ValoresDataContext bd = new ValoresDataContext();
        SIRECUPERADataContext bd_w = new SIRECUPERADataContext();
        public Prescripcion(string idusuario, string idciudadano)
        {
            pidciudadano = idciudadano;
            pidusuario = idusuario;
            InitializeComponent();

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvPrescripciones.Rows.Count>1 && int.Parse(txtaniohasta.Text)<=2015)
            {
                bd.PA_CONTROLDEUDA_PRESCRIPCION(pidciudadano, cmbconcepto.Text.Substring(0, 2), int.Parse(txtaniodesde.Text), int.Parse(txtaniohasta.Text), pidusuario);
                MessageBox.Show("Se procedio con la prescripcion");
                this.Close();
            }
            else
            {
                if (int.Parse(txtaniohasta.Text) > 2015)
                {
                    MessageBox.Show("predios no se pueden prescribir");
                }
            }
            
            
        }

        private void txtaniodesde_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtaniodesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtaniodesde.Text.Length == 4 && txtaniohasta.Text.Length == 4 && cmbconcepto.Text.Length>0 && int.Parse(txtaniohasta.Text) <= 2015)
            {
                //MessageBox.Show(pidciudadano + ";" + cmbconcepto.Text.Substring(0, 2) + " ;" + txtaniodesde.Text + " ;" + txtaniohasta.Text + " ;" + pidusuario);
                dgvPrescripciones.DataSource = bd.PA_CONTROLDEUDA_PRESCRIPCION_VER(pidciudadano, cmbconcepto.Text.Substring(0, 2), int.Parse(txtaniodesde.Text), int.Parse(txtaniohasta.Text), pidusuario);
            }
            else
            {
                MessageBox.Show("Tiene que especificar el concepto a prescribir y los años, tener en cuenta solo periodos prescribribles");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
