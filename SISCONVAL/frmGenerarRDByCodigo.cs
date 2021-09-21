﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISCONVAL
{
    public partial class frmGenerarRDByCodigo : Form
    {

        string pIdCiudadano;
        string pAnioTribu;
        string pOperador;
        ValoresDataContext BD = new ValoresDataContext();
        //public frmGenerarRDByCodigo(string IdCiudadano, string AnioTribu)
        //public frmGenerarRDByCodigo(string IDCIUDADANO, string ANIOTRIBUTO, string OPERADOR)
        public frmGenerarRDByCodigo(string IDCIUDADANO, string ANIOTRIBU, string OPERADOR)
        {
            /*recuperando parametros externos*/
          //  string[] passeid = Environment.GetCommandLineArgs();
         /*   pIdCiudadano = passeid.GetValue(1).ToString();
            pAnioTribu = passeid.GetValue(2).ToString();
            pOperador = passeid.GetValue(3).ToString();*/

            pIdCiudadano = IDCIUDADANO;
            pAnioTribu = ANIOTRIBU;
            pOperador = OPERADOR;
            

            InitializeComponent();
            //pIdCiudadano = IdCiudadano;
      
            lblCiudadano.Text = pIdCiudadano;
            txtAnioEjercicio.Text = pAnioTribu;
            txtAnioEjercicio.Text = System.DateTime.Today.Year.ToString();
          
           // pAnioTribu = "2019";
            dgvVistaPrevia.MultiSelect = true;
            dgvVistaPrevia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVistaPrevia.ReadOnly = true;
            dgvVistaPrevia.AllowUserToAddRows = false;
            dgvVistaPrevia.BackgroundColor = Color.White;
            dgvVistaPrevia.RowHeadersVisible = false;
             
            txtAnioHasta.Text = (DateTime.Today.Year).ToString();
            txtAnioDesde.Text = "1";

            try
            {
                dgvVistaPrevia.DataSource = BD.PA_CONTROLDEUDA_GENERARVALOR_INDIVIDUAL_PREVIEW(int.Parse(txtAnioEjercicio.Text), lblCiudadano.Text, int.Parse(txtAnioDesde.Text), int.Parse(txtAnioHasta.Text));

                txtAnioDesde.Text = (from X in BD.PA_CONTROLDEUDA_GENERARVALOR_INDIVIDUAL_PREVIEW(int.Parse(txtAnioEjercicio.Text), lblCiudadano.Text, int.Parse(txtAnioDesde.Text), int.Parse(txtAnioHasta.Text)) select X.ANIO).Min().ToString();
                txtAnioHasta.Text = (from X in BD.PA_CONTROLDEUDA_GENERARVALOR_INDIVIDUAL_PREVIEW(int.Parse(txtAnioEjercicio.Text), lblCiudadano.Text, int.Parse(txtAnioDesde.Text), int.Parse(txtAnioHasta.Text)) select X.ANIO).Max().ToString();
                lblNombreCiudadano.Text = dgvVistaPrevia.Rows[0].Cells["ApellidosyNombres"].Value.ToString();
                lblDireccion.Text = dgvVistaPrevia.Rows[0].Cells["DomicilioFiscalyNumero"].Value.ToString();
                string Insoluto = (from X in BD.PA_CONTROLDEUDA_GENERARVALOR_INDIVIDUAL_PREVIEW(int.Parse(txtAnioEjercicio.Text), lblCiudadano.Text, int.Parse(txtAnioDesde.Text), int.Parse(txtAnioHasta.Text)) select X.INSOLUTOFISCA).Sum().ToString();
                string Mora = (from X in BD.PA_CONTROLDEUDA_GENERARVALOR_INDIVIDUAL_PREVIEW(int.Parse(txtAnioEjercicio.Text), lblCiudadano.Text, int.Parse(txtAnioDesde.Text), int.Parse(txtAnioHasta.Text)) select X.MORA).Sum().ToString();
                string GasAdmin = (from X in BD.PA_CONTROLDEUDA_GENERARVALOR_INDIVIDUAL_PREVIEW(int.Parse(txtAnioEjercicio.Text), lblCiudadano.Text, int.Parse(txtAnioDesde.Text), int.Parse(txtAnioHasta.Text)) select X.GASADMIN).Sum().ToString();
                string total = (from X in BD.PA_CONTROLDEUDA_GENERARVALOR_INDIVIDUAL_PREVIEW(int.Parse(txtAnioEjercicio.Text), lblCiudadano.Text, int.Parse(txtAnioDesde.Text), int.Parse(txtAnioHasta.Text)) select X.GASADMIN + X.INSOLUTO + X.MORA).Sum().ToString();
                string pagado = (from X in BD.PA_CONTROLDEUDA_GENERARVALOR_INDIVIDUAL_PREVIEW(int.Parse(txtAnioEjercicio.Text), lblCiudadano.Text, int.Parse(txtAnioDesde.Text), int.Parse(txtAnioHasta.Text)) select X.PAGADO).Sum().ToString();
                string pendiente = (from X in BD.PA_CONTROLDEUDA_GENERARVALOR_INDIVIDUAL_PREVIEW(int.Parse(txtAnioEjercicio.Text), lblCiudadano.Text, int.Parse(txtAnioDesde.Text), int.Parse(txtAnioHasta.Text)) select X.PENDIENTE).Sum().ToString();
                lblInsoluto.Text ="S/. "+ String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}",decimal.Parse(Insoluto));
                lblMora.Text = "S/. " + String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", decimal.Parse(Mora));
                lblGasAdmin.Text = "S/. " + String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", decimal.Parse(GasAdmin));
                lblTotal.Text = "S/. " + String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", decimal.Parse(total));
                lblpagado.Text = decimal.Parse(pagado).ToString("N2");
                lblPendiente.Text = decimal.Parse(pendiente).ToString("N2");
            }
            catch (Exception error)
            {
                //MessageBox.Show("OCURRIO UN ERROR DURANTE LA EJECUCION DEL PROCESO, CIERRE Y VULEVA A INTENTARLO, SI EL PROBLEMA PERSISTE COMUNIQUESE CON INFORMATICA");
                int Res = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == lblCiudadano.Text && R.FAANIORESOLUCION == int.Parse(txtAnioEjercicio.Text) select R.FAIDCIUDADANO).Count();
                
                if (Res > 0)
                {
                    int nroreso = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == lblCiudadano.Text && R.FAANIORESOLUCION == int.Parse(txtAnioEjercicio.Text) select R.FNNRORESOLUCION).First();
                    MessageBox.Show("EL CIUDADANO YA TIENE UNA RESOLUCIÓN CON NUMERO: " + nroreso.ToString());
                    //this.Close();
                }
                else
                {
                    if ((from X in BD.PA_CONTROLDEUDA_GENERARVALOR_INDIVIDUAL_PREVIEW(int.Parse(txtAnioEjercicio.Text), lblCiudadano.Text, int.Parse(txtAnioDesde.Text), int.Parse(txtAnioHasta.Text)) select X.ANIO).Count() == 0)
                    {
                        MessageBox.Show("El ciudadano no tiene deuda pendiente.");
                    }
                    else
                    {
                        MessageBox.Show("OCURRIO UN ERROR DURANTE LA EJECUCION DEL PROCESO, CIERRE Y VUELVA A INTENTARLO, SI EL PROBLEMA PERSISTE COMUNIQUESE CON INFORMATICA " + error.ToString());
                    }
                }
            }
            
        }
        private void frmGenerarRDByCodigo_Load(object sender, EventArgs e)
        {
           
          
            
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvVistaPrevia.DataSource = BD.PA_CONTROLDEUDA_GENERARVALOR_INDIVIDUAL_PREVIEW(int.Parse(txtAnioEjercicio.Text), lblCiudadano.Text, int.Parse(txtAnioDesde.Text), int.Parse(txtAnioHasta.Text));
                lblNombreCiudadano.Text = dgvVistaPrevia.Rows[0].Cells["ApellidosyNombres"].Value.ToString();
                lblDireccion.Text = dgvVistaPrevia.Rows[0].Cells["DomicilioFiscalyNumero"].Value.ToString();
                string Insoluto= (from X in BD.PA_CONTROLDEUDA_GENERARVALOR_INDIVIDUAL_PREVIEW(int.Parse(txtAnioEjercicio.Text), lblCiudadano.Text, int.Parse(txtAnioDesde.Text), int.Parse(txtAnioHasta.Text)) select X.INSOLUTOFISCA).Sum().ToString();
                string Mora = (from X in BD.PA_CONTROLDEUDA_GENERARVALOR_INDIVIDUAL_PREVIEW(int.Parse(txtAnioEjercicio.Text), lblCiudadano.Text, int.Parse(txtAnioDesde.Text), int.Parse(txtAnioHasta.Text)) select X.MORA).Sum().ToString();
                string GasAdmin = (from X in BD.PA_CONTROLDEUDA_GENERARVALOR_INDIVIDUAL_PREVIEW(int.Parse(txtAnioEjercicio.Text), lblCiudadano.Text, int.Parse(txtAnioDesde.Text), int.Parse(txtAnioHasta.Text)) select X.GASADMIN).Sum().ToString();
                string Total = (from X in BD.PA_CONTROLDEUDA_GENERARVALOR_INDIVIDUAL_PREVIEW(int.Parse(txtAnioEjercicio.Text), lblCiudadano.Text, int.Parse(txtAnioDesde.Text), int.Parse(txtAnioHasta.Text)) select X.GASADMIN + X.INSOLUTO + X.MORA).Sum().ToString();
                lblInsoluto.Text = "S/. " + String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", decimal.Parse(Insoluto));
                lblMora.Text = "S/. " + String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", decimal.Parse(Mora));
                lblGasAdmin.Text = "S/. " + String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", decimal.Parse(GasAdmin));
                lblTotal.Text = "S/. " + String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", decimal.Parse(Total));
            }
            catch (Exception)
            {
                MessageBox.Show("NO TIENE DEUDA PARA LA GENERACION DE UNA RESOLUCION");
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAnioDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblCiudadano.Text.Length>0)
                {
                    DialogResult dr = MessageBox.Show("SE GENERARA LA RESOLUCION, DESEA CONTINUAR?",
                      "Advertecia", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            BD.PA_CONTROLDEUDA_GENERARVALOR_INDIVIDUAL(int.Parse(txtAnioEjercicio.Text), lblCiudadano.Text, int.Parse(txtAnioDesde.Text), int.Parse(txtAnioHasta.Text),pOperador);

                            var nroresolucion = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == lblCiudadano.Text orderby R.FDFECHAEMISION descending select R.FNNRORESOLUCION).Max();

                            //MessageBox.Show("Se genero la Resolucion: " + nroresolucion.ToString(), "Resultado de la operacion");
                            MessageBox.Show("Se genero la Resolución");

                            //frmReporteResolucion Reso = new frmReporteResolucion(int.Parse(txtAnioEjercicio.Text),int.Parse(dgvVistaPrevia.Rows[0].Cells["FANRORESOLUCION"].Value.ToString()));
                            frmReporteResolucion Reso = new frmReporteResolucion(int.Parse(txtAnioEjercicio.Text), int.Parse(nroresolucion.ToString()));
                            Reso.Show();
                            break;
                        case DialogResult.No:
                            
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("CIERRE Y VUELVA A INTENTARLO");
                }
                
            }
            catch (Exception err)
            {
                //MessageBox.Show("SE PRODUJO UN ERROR DURANTE LA EJECUCION DEL PROCESO, CIERRE Y VUELVA A INTENTARLO.", "ADVERTENCIA");
                int Res = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == lblCiudadano.Text && R.FAANIORESOLUCION == int.Parse(txtAnioEjercicio.Text) select R.FAIDCIUDADANO).Count();
                int nroreso = (from R in BD.VALORESGEN where R.FAIDCIUDADANO == lblCiudadano.Text && R.FAANIORESOLUCION == int.Parse(txtAnioEjercicio.Text) select R.FNNRORESOLUCION).First();
                if (Res >0 )
                {
                    MessageBox.Show("EL CIUDADANO YA TIENE UNA RESOLUCIÓN CON NUMERO: "+nroreso.ToString()+ " "+err.ToString());
                }
            }
            
        }

        private void btnImprimirRD_Click(object sender, EventArgs e)
        {
          /*  frmListaRDs listaRds = new frmListaRDs(lblCiudadano.Text, pOperador);
            listaRds.ShowDialog();*/
        }

        
    }
}
