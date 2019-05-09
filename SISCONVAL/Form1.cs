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
    public partial class Form1 : Form
    {
        ValoresDataContext BD = new ValoresDataContext();

        public Form1()
        {
            InitializeComponent();
            this.ActiveControl = txtNroResolucion; 
            //this.txtNroResolucion.Focus();
            //llenango el grid con la informacion de los valores
            dgvValores.DataSource = from V in BD.VALORESGEN
                                    orderby V.FNNRORESOLUCION descending
                                    select new { NroResolucion = V.FNNRORESOLUCION, IdCiudadano= V.FAIDCIUDADANO, Ciudadano=V.FAAPELLIDOSYNOMBRES, Estado=V.FAESTADOVALOR,Desde= V.FADESDE, Hasta= V.FAHASTA, Total= V.FNTOTALVALOR, Notificacion=V.FDFECHANOTIF, Vencimiento=V.FDFECHAVENCI};

           // txtNroResolucion.Text = dgvValores.Rows[0].Cells[0].Value.ToString();
            //Cargamos el combo de estado de RD
            cmbEstadoRD.DataSource = from E in BD.ESTADORD select new { FACODESTADORD = E.facodestadord, FADESCRIPCION = E.fadesestado };
            cmbEstadoRD.DisplayMember = "FADESCRIPCION";
            cmbEstadoRD.ValueMember = "FACODESTADORD";
            //Cargamos a los notificadores en su respectivo combobox
            cmbNotificador.DataSource = from N in BD.NOTIFICADOR select new { CODIGO = N.FACODNOTI, NOMBRE = N.FANOMNOTR };
            cmbNotificador.DisplayMember = "NOMBRE";
            cmbNotificador.ValueMember = "CODIGO";

            txtAnioResolucion.Text = (from V in BD.VALORESGEN orderby V.FAANIORESOLUCION descending select V.FAANIORESOLUCION).Max().ToString();

            
        }

        private void dgvValores_SelectionChanged(object sender, EventArgs e)
        {//hacer una evaluacion de la funcionalidad del modulo, definir es es necesaria esta opcion, o si solo se filtrar por ciudadano, notificador, rago de rds, etc
            try
            {/*
                txtNroResolucion.Text = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["NroResolucion"].Value.ToString();
                txtCodigoContrib.Text = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["IdCiudadano"].Value.ToString();
                cmbEstadoRD.Text = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString();
                var Resolucion = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == txtCodigoContrib.Text select R).First();
                dtpFechaNotificacion.Value = Resolucion.FDFECHANOTIF.Value;
              */
            }
            catch (Exception error)
            {
                //
            }
        }

        private void dgvValores_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaNotificacion_ValueChanged(object sender, EventArgs e)
        {
            
            dtpFechaVencimiento.Value = dtpFechaNotificacion.Value.Add(TimeSpan.FromDays(28));
            //MessageBox.Show(dtpFechaNotificacion.Value.DayOfWeek.ToString());

            //VALIDAR SI ES DIA HABIL(NO SABADO Y DOMINGO)
            if (dtpFechaNotificacion.Value.DayOfWeek.ToString() == "Saturday" || dtpFechaNotificacion.Value.DayOfWeek.ToString() == "Sunday")
            {
                MessageBox.Show("Seleccionar un dia habil de lunes a viernes");
               // MessageBox.Show(dtpFechaNotificacion.Value.DayOfWeek.ToString());
            }
            //validando los 20 dias habiles de notificacion 
            if ( dtpFechaNotificacion.Value.Add(TimeSpan.FromDays(28)).DayOfWeek.ToString() == "Saturday")
            {
                dtpFechaVencimiento.Value = dtpFechaNotificacion.Value.Add(TimeSpan.FromDays(30));
            }
            if (dtpFechaNotificacion.Value.Add(TimeSpan.FromDays(28)).DayOfWeek.ToString() == "Sunday")
            {
                dtpFechaVencimiento.Value = dtpFechaNotificacion.Value.Add(TimeSpan.FromDays(29));
            }
        }

        private void btnActualizarNotificador_Click(object sender, EventArgs e)
        {
            frmNotificador Noti = new frmNotificador();
            Noti.ShowDialog();
            cmbNotificador.DataSource = from N in BD.NOTIFICADOR select new { CODIGO = N.FACODNOTI, NOMBRE = N.FANOMNOTR };
        }

        private void txtNroResolucion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvValores.DataSource = from V in BD.VALORESGEN where V.FNNRORESOLUCION == int.Parse(txtNroResolucion.Text) && V.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text)  select new { NroResolucion = V.FNNRORESOLUCION, IdCiudadano = V.FAIDCIUDADANO, Ciudadano = V.FAAPELLIDOSYNOMBRES, Estado = V.FAESTADOVALOR, Desde = V.FADESDE, Hasta = V.FAHASTA, Total = V.FNTOTALVALOR, Notificacion = V.FDFECHANOTIF, Vencimiento = V.FDFECHAVENCI, Observacion = V.FMOBSERVACION };

                txtCodigoContrib.Text = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["IdCiudadano"].Value.ToString();
                cmbEstadoRD.Text = (from V in BD.ESTADORD where V.facodestadord == dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString() select V.fadesestado).First().ToString();
                //cmbEstadoRD.Text = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString();
                //cmbEstadoRD.ValueMember = dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString();
                var Resolucion = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == txtCodigoContrib.Text && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R).First();
                dtpFechaNotificacion.Value = Resolucion.FDFECHANOTIF.Value;
            }
            catch (Exception error)
            {
                if (txtNroResolucion.Text.Length>0)
                {
                    MessageBox.Show("El Nro no existe");
                }
               
            }
            
        }

        private void txtCodigoContrib_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var Resolucion = from V in BD.VALORESGEN where V.FAIDCIUDADANO == txtCodigoContrib.Text && V.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select new { NroResolucion = V.FNNRORESOLUCION, IdCiudadano = V.FAIDCIUDADANO, Ciudadano = V.FAAPELLIDOSYNOMBRES, Estado = V.FAESTADOVALOR, Desde = V.FADESDE, Hasta = V.FAHASTA, Total = V.FNTOTALVALOR, Notificacion = V.FDFECHANOTIF, Vencimiento = V.FDFECHAVENCI, Observacion = V.FMOBSERVACION };
                dgvValores.DataSource = Resolucion;
                txtNroResolucion.Text = Resolucion.First().NroResolucion.ToString();
                cmbEstadoRD.Text = (from E in BD.ESTADORD where E.facodestadord == dgvValores.Rows[dgvValores.CurrentCell.RowIndex].Cells["Estado"].Value.ToString() select E.fadesestado).First().ToString();
                dtpFechaNotificacion.Value = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == txtCodigoContrib.Text && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FDFECHANOTIF).First().Value;
                txtObservacionRD.Text = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == txtCodigoContrib.Text && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FMOBSERVACION).First().ToString();
                cmbNotificador.SelectedValue = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == txtCodigoContrib.Text && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FNIDNOTIFICADOR).First();

            }
            catch (Exception error)
            {
                if (txtCodigoContrib.Text.Length>0)
                {
                    MessageBox.Show("El codigo no existe");
                }
                
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                BD.PA_CONTROLDEUDA_MODIFICARVALORCAB(int.Parse(txtAnioResolucion.Text),int.Parse(txtNroResolucion.Text), cmbEstadoRD.SelectedValue.ToString(), txtObservacionRD.Text, dtpFechaNotificacion.Value, dtpFechaVencimiento.Value, int.Parse(cmbNotificador.SelectedValue.ToString()));
                var Resolucion = from V in BD.VALORESGEN where V.FNNRORESOLUCION == int.Parse(txtNroResolucion.Text) select new { NroResolucion = V.FNNRORESOLUCION, IdCiudadano = V.FAIDCIUDADANO, Ciudadano = V.FAAPELLIDOSYNOMBRES, Estado = V.FAESTADOVALOR, Desde = V.FADESDE, Hasta = V.FAHASTA, Total = V.FNTOTALVALOR, Notificacion = V.FDFECHANOTIF, Vencimiento = V.FDFECHAVENCI, Observacion = V.FMOBSERVACION };
                dgvValores.DataSource = Resolucion;
                txtNroResolucion.Text = Resolucion.First().NroResolucion.ToString();
                cmbEstadoRD.Text = (from E in BD.ESTADORD where E.facodestadord == Resolucion.First().Estado select E.fadesestado).First().ToString();
                dtpFechaNotificacion.Value = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == txtCodigoContrib.Text && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FDFECHANOTIF).First().Value;
                txtObservacionRD.Text = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == txtCodigoContrib.Text && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FMOBSERVACION).First().ToString();
                cmbNotificador.SelectedValue = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == txtCodigoContrib.Text && R.FAANIORESOLUCION == int.Parse(txtAnioResolucion.Text) select R.FNIDNOTIFICADOR).First();

            }
            catch (Exception Error)
            {
                MessageBox.Show("Error durante la ejecucion, evento : btnActualizar_Click ");
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoContrib.Text = "";
            txtNroResolucion.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
