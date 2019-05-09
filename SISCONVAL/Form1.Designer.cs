namespace SISCONVAL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvValores = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chbVolverGenerar = new System.Windows.Forms.CheckBox();
            this.btnVolverGenerar = new System.Windows.Forms.Button();
            this.cmbEstadoRD = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dtpFechaNotificacion = new System.Windows.Forms.DateTimePicker();
            this.btnActualizarNotificador = new System.Windows.Forms.Button();
            this.cmbNotificador = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label43 = new System.Windows.Forms.Label();
            this.txtObservacionRD = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtCodigoContrib = new System.Windows.Forms.TextBox();
            this.txtNroResolucion = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rdbFiltro = new System.Windows.Forms.RadioButton();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.Desde = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnioResolucion = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValores)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1341, 724);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1333, 695);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RESOLUCIONES";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvValores);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 203);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1327, 387);
            this.panel2.TabIndex = 1;
            // 
            // dgvValores
            // 
            this.dgvValores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvValores.Location = new System.Drawing.Point(0, 0);
            this.dgvValores.MultiSelect = false;
            this.dgvValores.Name = "dgvValores";
            this.dgvValores.RowTemplate.Height = 24;
            this.dgvValores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvValores.Size = new System.Drawing.Size(1327, 387);
            this.dgvValores.TabIndex = 0;
            this.dgvValores.SelectionChanged += new System.EventHandler(this.dgvValores_SelectionChanged);
            this.dgvValores.TabIndexChanged += new System.EventHandler(this.dgvValores_TabIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.btnActualizar);
            this.panel3.Controls.Add(this.btnLimpiar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 590);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1327, 102);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox7);
            this.panel1.Controls.Add(this.groupBox6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.MaximumSize = new System.Drawing.Size(1327, 200);
            this.panel1.MinimumSize = new System.Drawing.Size(1327, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1327, 200);
            this.panel1.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chbVolverGenerar);
            this.groupBox7.Controls.Add(this.btnVolverGenerar);
            this.groupBox7.Controls.Add(this.cmbEstadoRD);
            this.groupBox7.Controls.Add(this.label41);
            this.groupBox7.Controls.Add(this.dtpFechaNotificacion);
            this.groupBox7.Controls.Add(this.btnActualizarNotificador);
            this.groupBox7.Controls.Add(this.cmbNotificador);
            this.groupBox7.Controls.Add(this.label42);
            this.groupBox7.Controls.Add(this.label45);
            this.groupBox7.Controls.Add(this.dtpFechaVencimiento);
            this.groupBox7.Controls.Add(this.label43);
            this.groupBox7.Controls.Add(this.txtObservacionRD);
            this.groupBox7.Controls.Add(this.label44);
            this.groupBox7.Location = new System.Drawing.Point(530, 13);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(791, 174);
            this.groupBox7.TabIndex = 26;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "DETALLES";
            // 
            // chbVolverGenerar
            // 
            this.chbVolverGenerar.AutoSize = true;
            this.chbVolverGenerar.Location = new System.Drawing.Point(526, 93);
            this.chbVolverGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.chbVolverGenerar.Name = "chbVolverGenerar";
            this.chbVolverGenerar.Size = new System.Drawing.Size(171, 21);
            this.chbVolverGenerar.TabIndex = 25;
            this.chbVolverGenerar.Text = "VOLVER A GENERAR";
            this.chbVolverGenerar.UseVisualStyleBackColor = true;
            // 
            // btnVolverGenerar
            // 
            this.btnVolverGenerar.Enabled = false;
            this.btnVolverGenerar.Location = new System.Drawing.Point(575, 119);
            this.btnVolverGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolverGenerar.Name = "btnVolverGenerar";
            this.btnVolverGenerar.Size = new System.Drawing.Size(193, 46);
            this.btnVolverGenerar.TabIndex = 24;
            this.btnVolverGenerar.Text = "Volver a Generar";
            this.btnVolverGenerar.UseVisualStyleBackColor = true;
            this.btnVolverGenerar.Visible = false;
            // 
            // cmbEstadoRD
            // 
            this.cmbEstadoRD.FormattingEnabled = true;
            this.cmbEstadoRD.Location = new System.Drawing.Point(80, 22);
            this.cmbEstadoRD.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstadoRD.Name = "cmbEstadoRD";
            this.cmbEstadoRD.Size = new System.Drawing.Size(240, 24);
            this.cmbEstadoRD.TabIndex = 5;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(20, 26);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(52, 17);
            this.label41.TabIndex = 10;
            this.label41.Text = "Estado";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(989, 7);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(151, 90);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dtpFechaNotificacion
            // 
            this.dtpFechaNotificacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNotificacion.Location = new System.Drawing.Point(157, 57);
            this.dtpFechaNotificacion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaNotificacion.Name = "dtpFechaNotificacion";
            this.dtpFechaNotificacion.Size = new System.Drawing.Size(132, 22);
            this.dtpFechaNotificacion.TabIndex = 6;
            this.dtpFechaNotificacion.ValueChanged += new System.EventHandler(this.dtpFechaNotificacion_ValueChanged);
            // 
            // btnActualizarNotificador
            // 
            this.btnActualizarNotificador.Location = new System.Drawing.Point(272, 119);
            this.btnActualizarNotificador.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarNotificador.Name = "btnActualizarNotificador";
            this.btnActualizarNotificador.Size = new System.Drawing.Size(35, 28);
            this.btnActualizarNotificador.TabIndex = 22;
            this.btnActualizarNotificador.Text = "...";
            this.btnActualizarNotificador.UseVisualStyleBackColor = true;
            this.btnActualizarNotificador.Click += new System.EventHandler(this.btnActualizarNotificador_Click);
            // 
            // cmbNotificador
            // 
            this.cmbNotificador.FormattingEnabled = true;
            this.cmbNotificador.Location = new System.Drawing.Point(104, 122);
            this.cmbNotificador.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNotificador.Name = "cmbNotificador";
            this.cmbNotificador.Size = new System.Drawing.Size(160, 24);
            this.cmbNotificador.TabIndex = 9;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(20, 60);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(124, 17);
            this.label42.TabIndex = 11;
            this.label42.Text = "Fecha Notificacion";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(20, 128);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(76, 17);
            this.label45.TabIndex = 17;
            this.label45.Text = "Notificador";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(459, 57);
            this.dtpFechaVencimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(116, 22);
            this.dtpFechaVencimiento.TabIndex = 7;
            this.dtpFechaVencimiento.Value = new System.DateTime(2019, 5, 8, 0, 0, 0, 0);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(320, 60);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(128, 17);
            this.label43.TabIndex = 13;
            this.label43.Text = "Fecha Vencimiento";
            // 
            // txtObservacionRD
            // 
            this.txtObservacionRD.Location = new System.Drawing.Point(116, 92);
            this.txtObservacionRD.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacionRD.Name = "txtObservacionRD";
            this.txtObservacionRD.Size = new System.Drawing.Size(392, 22);
            this.txtObservacionRD.TabIndex = 8;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(20, 95);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(88, 17);
            this.label44.TabIndex = 15;
            this.label44.Text = "Observacion";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtAnioResolucion);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.txtCodigoContrib);
            this.groupBox6.Controls.Add(this.txtNroResolucion);
            this.groupBox6.Controls.Add(this.label38);
            this.groupBox6.Controls.Add(this.label39);
            this.groupBox6.Location = new System.Drawing.Point(17, 13);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(485, 174);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "GENERAL";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(824, 8);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(157, 89);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtCodigoContrib
            // 
            this.txtCodigoContrib.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoContrib.Location = new System.Drawing.Point(114, 111);
            this.txtCodigoContrib.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoContrib.Name = "txtCodigoContrib";
            this.txtCodigoContrib.Size = new System.Drawing.Size(352, 30);
            this.txtCodigoContrib.TabIndex = 4;
            this.txtCodigoContrib.TextChanged += new System.EventHandler(this.txtCodigoContrib_TextChanged);
            // 
            // txtNroResolucion
            // 
            this.txtNroResolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroResolucion.Location = new System.Drawing.Point(199, 73);
            this.txtNroResolucion.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroResolucion.Name = "txtNroResolucion";
            this.txtNroResolucion.Size = new System.Drawing.Size(267, 30);
            this.txtNroResolucion.TabIndex = 3;
            this.txtNroResolucion.TextChanged += new System.EventHandler(this.txtNroResolucion_TextChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(12, 73);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(171, 25);
            this.label38.TabIndex = 1;
            this.label38.Text = "Nro Resolución :";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(12, 111);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(94, 25);
            this.label39.TabIndex = 8;
            this.label39.Text = "Codigo :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rdbFiltro);
            this.tabPage2.Controls.Add(this.txtHasta);
            this.tabPage2.Controls.Add(this.txtDesde);
            this.tabPage2.Controls.Add(this.Desde);
            this.tabPage2.Controls.Add(this.label40);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1333, 695);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RESUMEN RD\'s";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rdbFiltro
            // 
            this.rdbFiltro.AutoSize = true;
            this.rdbFiltro.Enabled = false;
            this.rdbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFiltro.Location = new System.Drawing.Point(53, 39);
            this.rdbFiltro.Name = "rdbFiltro";
            this.rdbFiltro.Size = new System.Drawing.Size(68, 24);
            this.rdbFiltro.TabIndex = 15;
            this.rdbFiltro.TabStop = true;
            this.rdbFiltro.Text = "Filtro";
            this.rdbFiltro.UseVisualStyleBackColor = true;
            this.rdbFiltro.Visible = false;
            // 
            // txtHasta
            // 
            this.txtHasta.Enabled = false;
            this.txtHasta.Location = new System.Drawing.Point(197, 100);
            this.txtHasta.Margin = new System.Windows.Forms.Padding(4);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(132, 22);
            this.txtHasta.TabIndex = 13;
            this.txtHasta.Text = "99999";
            this.txtHasta.Visible = false;
            // 
            // txtDesde
            // 
            this.txtDesde.Enabled = false;
            this.txtDesde.Location = new System.Drawing.Point(48, 100);
            this.txtDesde.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(132, 22);
            this.txtDesde.TabIndex = 11;
            this.txtDesde.Text = "1";
            this.txtDesde.Visible = false;
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.Enabled = false;
            this.Desde.Location = new System.Drawing.Point(50, 79);
            this.Desde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(53, 17);
            this.Desde.TabIndex = 12;
            this.Desde.Text = "Desde:";
            this.Desde.Visible = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Enabled = false;
            this.label40.Location = new System.Drawing.Point(194, 77);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(49, 17);
            this.label40.TabIndex = 14;
            this.label40.Text = "Hasta:";
            this.label40.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Año Resolucion :";
            // 
            // txtAnioResolucion
            // 
            this.txtAnioResolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnioResolucion.Location = new System.Drawing.Point(199, 27);
            this.txtAnioResolucion.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnioResolucion.Name = "txtAnioResolucion";
            this.txtAnioResolucion.Size = new System.Drawing.Size(267, 30);
            this.txtAnioResolucion.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1161, 7);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(151, 90);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1341, 724);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROL DE VALORES";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValores)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvValores;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtCodigoContrib;
        private System.Windows.Forms.TextBox txtNroResolucion;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chbVolverGenerar;
        private System.Windows.Forms.Button btnVolverGenerar;
        private System.Windows.Forms.ComboBox cmbEstadoRD;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DateTimePicker dtpFechaNotificacion;
        private System.Windows.Forms.Button btnActualizarNotificador;
        private System.Windows.Forms.ComboBox cmbNotificador;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox txtObservacionRD;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtAnioResolucion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbFiltro;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button btnSalir;
    }
}

