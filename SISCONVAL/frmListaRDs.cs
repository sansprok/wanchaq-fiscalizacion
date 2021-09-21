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
        public frmListaRDs()
        {
            string[] passeid = Environment.GetCommandLineArgs();
             pIdCiudadano = passeid.GetValue(1).ToString();
             pOperador = passeid.GetValue(2).ToString();
          /* pIdCiudadano = "00146204Q";
             pOperador = "mccarhuas";**/
            
            InitializeComponent();
            if (pOperador == "mccarhuas")
            {
                anularToolStripMenuItem.Visible = true;
                anularToolStripMenuItem.Enabled = true;
                anularRDToolStripMenuItem.Visible = true;
                anularRDToolStripMenuItem.Enabled = true;

            }
            else
            {
                anularToolStripMenuItem.Visible = false;
                anularToolStripMenuItem.Enabled = false;
                anularRDToolStripMenuItem.Enabled = false;
                anularRDToolStripMenuItem.Enabled = false;
            }

            //dgvListaRds.MultiSelect = true;
            // dgvListaRds.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvListaRds.ReadOnly = false;
            dgvListaRds.AllowUserToAddRows = false;
            dgvListaRds.BackgroundColor = Color.White;
            dgvListaRds.RowHeadersVisible = false;
            dgvListaRds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
            var lista = from R in bdvalores.VALORESGEN where R.FAIDCIUDADANO == pIdCiudadano select new {Anio=R.FAANIORESOLUCION, Numero=R.FNNRORESOLUCION, Desde=R.FADESDE, Hasta=R.FAHASTA, Estado=(from E in bdvalores.ESTADORD where E.facodestadord== R.FAESTADOVALOR select E.fadesestado).First().ToString(), Usuario=R.FAOPERADOR };
            dgvListaRds.DataSource = lista;

            dgvListaOrdenesPago.ReadOnly = false;
            dgvListaOrdenesPago.AllowUserToAddRows = false;
            dgvListaOrdenesPago.BackgroundColor = Color.White;
            dgvListaOrdenesPago.RowHeadersVisible = false;
            dgvListaOrdenesPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // dgvListaOrdenesPago.Columns[0].HeaderCell.Style.Font= new Font(DataGridView.DefaultFont, FontStyle.Bold);
            // dgvListaRds.Cells["Estado"].Style.Font =System.Drawing.FontStyle. ;

            var ordenes = from O in bdvalores.ORDENESPAGOGEN where O.FAIDCIUDADANO == pIdCiudadano select new { Anio = O.FAANIOOP, Numero = O.FNNROOP, IdCiudadano = O.FAIDCIUDADANO, Periodos = O.FAPERIODOS, Estado = (from E in bdvalores.ESTADORD where E.facodestadord == O.FAESTADOOP select E.fadesestado).First().ToString() };
            dgvListaOrdenesPago.DataSource = ordenes;

            /*resoluciones enviadas a coactiva*/
         
            dgvResIniCoac.ReadOnly = false;
            dgvResIniCoac.AllowUserToAddRows = false;
            dgvResIniCoac.BackgroundColor = Color.White;
            dgvResIniCoac.RowHeadersVisible = false;
            dgvResIniCoac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            var resolucionescoac = from C in bdvalores.REQCOACGEN where C.FAIDCIUDADANO == pIdCiudadano select new {  C.FANROEXPED, C.FAANIOEXPED, C.FANRORESOLUCION, C.FAANIORESOLUCION, ESTADO=(from R in bdvalores.CALIFICACION where R.FACODCALIFI== C.FAREQCALIFICA select R.FADESCALIFI).First().ToString(), C.FATIPOVALOR };
            dgvResIniCoac.DataSource = resolucionescoac;

            /*resoluciones de fraccionamiento*/

            dgvResFra.ReadOnly = false;
            dgvResFra.AllowUserToAddRows = false;
            dgvResFra.BackgroundColor = Color.White;
            dgvResFra.RowHeadersVisible = false;
            dgvResFra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            var resolucionefraccionamiento = from F in bdvalores.FRACCIONAMIENTO_RESOLUCION where F.FAIDCIUDADANO == pIdCiudadano select new { F.FNNROFRACC, F.FNANIOFRACC };
            dgvResFra.DataSource = resolucionefraccionamiento;

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
           /* var Resolucion = from R in bdvalores.VALORESGEN where R.FNNRORESOLUCION == int.Parse(dgvListaRds.Rows[dgvListaRds.CurrentRow.Index].Cells["Numero"].Value.ToString()) && R.FAANIORESOLUCION == int.Parse(dgvListaRds.Rows[dgvListaRds.CurrentRow.Index].Cells["Anio"].Value.ToString()) select R;

            int NroResolucion = int.Parse(dgvListaRds.Rows[dgvListaRds.CurrentRow.Index].Cells["Numero"].Value.ToString());
            string Idciudadano = Resolucion.First().FAIDCIUDADANO;
            int AnioResolucion = int.Parse(dgvListaRds.Rows[dgvListaRds.CurrentRow.Index].Cells["Anio"].Value.ToString());
            string Operador = pOperador;
            int Desde = Resolucion.First().FADESDE;
            int Hasta = int.Parse(Resolucion.First().FAHASTA.ToString());
            frmFiltroActualizacion filtro = new frmFiltroActualizacion(Desde, Hasta,NroResolucion, AnioResolucion, Operador, Idciudadano);
            filtro.ShowDialog();
           */
           
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
                if (dgvResIniCoac.Rows.Count>0)
                {
                    btnAlerta.Visible = false;
                    lblAlerta3.Visible = false;
                }
                if (dgvResFra.Rows.Count>0)
                {
                    btnAlerta.Visible = false;
                    lblAlerta4.Visible = false;
                }
            }
            else
            {                
                    if (dgvListaRds.Rows.Count > 0)
                    {
                        btnAlerta.Visible = true;
                        lblAlerta1.Visible = true;
                        lblAlerta1.ForeColor =  Color.Blue;
                        lblAlerta1.Text = "EXISTE RESOLUCION DE DETERMINACION";
                    }
                    if (dgvListaOrdenesPago.Rows.Count > 0)
                    {
                        btnAlerta.Visible = true;
                        lblAlerta2.Visible = true;
                        lblAlerta2.ForeColor = Color.Blue;
                        lblAlerta2.Text = "EXISTE ORDEN DE PAGO";
                    }
                    if (dgvResIniCoac.Rows.Count>0)
                    {
                        btnAlerta.Visible = true;
                        lblAlerta3.Visible = true;
                        lblAlerta3.Text = "EXISTE RESOLUCION EN COBRANZA COACTIVA";
                    }
                    if (dgvResFra.Rows.Count > 0)
                    {
                        btnAlerta.Visible = true;
                        lblAlerta4.Visible = true;
                        lblAlerta4.Text = "EXISTE RESOLUCION DE FRACCIONAMIENTO";
                    }
            }
        }

        private void aHoyDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            var Resolucion = from R in bdvalores.VALORESGEN where R.FNNRORESOLUCION == int.Parse(dgvListaRds.Rows[dgvListaRds.CurrentRow.Index].Cells["Numero"].Value.ToString()) && R.FAANIORESOLUCION == int.Parse(dgvListaRds.Rows[dgvListaRds.CurrentRow.Index].Cells["Anio"].Value.ToString()) select R;

            int NroResolucion = int.Parse(dgvListaRds.Rows[dgvListaRds.CurrentRow.Index].Cells["Numero"].Value.ToString());
            string Idciudadano = Resolucion.First().FAIDCIUDADANO;
            int AnioResolucion = int.Parse(dgvListaRds.Rows[dgvListaRds.CurrentRow.Index].Cells["Anio"].Value.ToString());
            string Operador = pOperador;
            int Desde = Resolucion.First().FADESDE;
            int Hasta = int.Parse(Resolucion.First().FAHASTA.ToString());
            frmFiltroActualizacion filtro = new frmFiltroActualizacion(Desde, Hasta, NroResolucion, AnioResolucion, Operador, Idciudadano);
            filtro.ShowDialog();
            */
        }

        private void aFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
          
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenerarRDByCodigo nuevaRD = new frmGenerarRDByCodigo(pIdCiudadano,DateTime.Today.Year.ToString(),pOperador);
            nuevaRD.ShowDialog();
        }

        private void anularRDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("ANULAR RESOLUCION, DESEA CONTINUAR?", "Advertecia", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        string aniovalor = dgvListaRds.Rows[dgvListaRds.CurrentCell.RowIndex].Cells["Anio"].Value.ToString();
                        string nroresolucion = dgvListaRds.Rows[dgvListaRds.CurrentCell.RowIndex].Cells["Numero"].Value.ToString();

                        frmObservaciones obs = new frmObservaciones(int.Parse(aniovalor), int.Parse(nroresolucion), pIdCiudadano, "RD", pOperador);
                        obs.ShowDialog();
                        break;
                    case DialogResult.No:

                        break;
                }
            }
            catch (Exception)
            {
                //
            }
                
            


           
        }
    }
}
