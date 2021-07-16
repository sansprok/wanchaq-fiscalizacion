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
    public partial class frmListaRDs : Form
    {
        ValoresDataContext bdvalores = new ValoresDataContext();
        string pIdCiudadano;
        string pOperador;
        private int _ticks;
        public frmListaRDs(string IDCIUDADANO, string OPERADOR)
        {
            InitializeComponent();
            //dgvListaRds.MultiSelect = true;
           // dgvListaRds.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvListaRds.ReadOnly = false;
            dgvListaRds.AllowUserToAddRows = false;
            dgvListaRds.BackgroundColor = Color.White;
            dgvListaRds.RowHeadersVisible = false;
            dgvListaRds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            pIdCiudadano = IDCIUDADANO;
            pOperador = OPERADOR;
            var lista = from R in bdvalores.VALORESGEN where R.FAIDCIUDADANO == pIdCiudadano select new {Anio=R.FAANIORESOLUCION, Numero=R.FNNRORESOLUCION, Desde=R.FADESDE, Hasta=R.FAHASTA, Estado=R.FAESTADOVALOR };
            dgvListaRds.DataSource = lista;

            dgvListaOrdenesPago.ReadOnly = false;
            dgvListaOrdenesPago.AllowUserToAddRows = false;
            dgvListaOrdenesPago.BackgroundColor = Color.White;
            dgvListaOrdenesPago.RowHeadersVisible = false;
            dgvListaOrdenesPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var ordenes = from O in bdvalores.ORDENESPAGOGEN where O.FAIDCIUDADANO == pIdCiudadano select new { Anio = O.FAANIOOP, Numero = O.FNNROOP, IdCiudadano = O.FAIDCIUDADANO, Periodos = O.FAPERIODOS, Estado = O.FAESTADOOP };
            dgvListaOrdenesPago.DataSource = ordenes;
            Alertas();

        }
        public void Alertas()
        {
            timer1.Start();
            
        }
        private void dgvListaRds_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string anioejercicio = dgvListaRds.Rows[dgvListaRds.CurrentCell.RowIndex].Cells["Anio"].Value.ToString();
            string nroresolucion = dgvListaRds.Rows[dgvListaRds.CurrentCell.RowIndex].Cells["Numero"].Value.ToString();
            frmReporteResolucion Reso = new frmReporteResolucion(int.Parse(anioejercicio), int.Parse(nroresolucion));
            Reso.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            DialogResult dr = MessageBox.Show("SE MODIFICARAN LOS DATOS DE LA RESOLUCION, DESEA ACTUALIZAR ?",
                   "Advertecia", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    var Resolucion = from R in bdvalores.VALORESGEN where R.FNNRORESOLUCION == int.Parse(dgvListaRds.Rows[dgvListaRds.CurrentRow.Index].Cells["Numero"].Value.ToString()) && R.FAANIORESOLUCION == int.Parse(dgvListaRds.Rows[dgvListaRds.CurrentRow.Index].Cells["Anio"].Value.ToString()) select R;

                    int NroResolucion = int.Parse(dgvListaRds.Rows[dgvListaRds.CurrentRow.Index].Cells["Numero"].Value.ToString());
                    string Idciudadano = Resolucion.First().FAIDCIUDADANO;
                    int AnioResolucion = int.Parse(dgvListaRds.Rows[dgvListaRds.CurrentRow.Index].Cells["Anio"].Value.ToString());
                    string Operador = pOperador;
                    int Desde = Resolucion.First().FADESDE;
                    int Hasta = int.Parse(Resolucion.First().FAHASTA.ToString());


                    bdvalores.PA_CONTROLDEUDA_ACTUALIZARVALOR_INDIVIDUAL(AnioResolucion, Idciudadano, NroResolucion, Operador, Desde, Hasta);
                    break;
                case DialogResult.No:

                    break;
            }
            */
            var Resolucion = from R in bdvalores.VALORESGEN where R.FNNRORESOLUCION == int.Parse(dgvListaRds.Rows[dgvListaRds.CurrentRow.Index].Cells["Numero"].Value.ToString()) && R.FAANIORESOLUCION == int.Parse(dgvListaRds.Rows[dgvListaRds.CurrentRow.Index].Cells["Anio"].Value.ToString()) select R;

            int NroResolucion = int.Parse(dgvListaRds.Rows[dgvListaRds.CurrentRow.Index].Cells["Numero"].Value.ToString());
            string Idciudadano = Resolucion.First().FAIDCIUDADANO;
            int AnioResolucion = int.Parse(dgvListaRds.Rows[dgvListaRds.CurrentRow.Index].Cells["Anio"].Value.ToString());
            string Operador = pOperador;
            int Desde = Resolucion.First().FADESDE;
            int Hasta = int.Parse(Resolucion.First().FAHASTA.ToString());
            frmFiltroActualizacion filtro = new frmFiltroActualizacion(Desde, Hasta,NroResolucion, AnioResolucion, Operador, Idciudadano);
            filtro.ShowDialog();

           
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            if ((_ticks % 5) == 0)
            {
                if (dgvListaRds.Rows.Count > 0)
                {
                    btnAlerta.Visible = false;
                    lblAlerta1.Visible = false;

                }
                if (dgvListaOrdenesPago.Rows.Count > 0)
                {
                    btnAlerta.Visible = false;
                    lblAlerta2.Visible = false;

                }
            }
            else
            {                
                    if (dgvListaRds.Rows.Count > 0)
                    {
                        btnAlerta.Visible = true;
                        lblAlerta1.Visible = true;
                        lblAlerta1.Text = "EXISTE RESOLUCION DE DETERMINACION";
                    }
                    if (dgvListaOrdenesPago.Rows.Count > 0)
                    {
                        btnAlerta.Visible = true;
                        lblAlerta2.Visible = true;
                        lblAlerta2.Text = "EXISTE ORDEN DE PAGO";
                    }
            }
        }
    }
}
