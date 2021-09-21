namespace SISCONVAL
{
    partial class frmListaRDs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaRDs));
            this.dgvListaRds = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularRDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aHoyDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvResIniCoac = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvResFra = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListaOrdenesPago = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAlerta4 = new System.Windows.Forms.Label();
            this.lblAlerta3 = new System.Windows.Forms.Label();
            this.lblAlerta2 = new System.Windows.Forms.Label();
            this.lblAlerta1 = new System.Windows.Forms.Label();
            this.btnAlerta = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRds)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResIniCoac)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResFra)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaOrdenesPago)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaRds
            // 
            this.dgvListaRds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaRds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaRds.Location = new System.Drawing.Point(3, 16);
            this.dgvListaRds.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaRds.Name = "dgvListaRds";
            this.dgvListaRds.RowTemplate.Height = 24;
            this.dgvListaRds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaRds.Size = new System.Drawing.Size(369, 129);
            this.dgvListaRds.TabIndex = 0;
            this.dgvListaRds.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaRds_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.anularToolStripMenuItem,
            this.actualizarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // anularToolStripMenuItem
            // 
            this.anularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anularRDToolStripMenuItem});
            this.anularToolStripMenuItem.Name = "anularToolStripMenuItem";
            this.anularToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.anularToolStripMenuItem.Text = "Anular";
            this.anularToolStripMenuItem.Click += new System.EventHandler(this.anularToolStripMenuItem_Click);
            // 
            // anularRDToolStripMenuItem
            // 
            this.anularRDToolStripMenuItem.Name = "anularRDToolStripMenuItem";
            this.anularRDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.anularRDToolStripMenuItem.Text = "Anular RD";
            this.anularRDToolStripMenuItem.Click += new System.EventHandler(this.anularRDToolStripMenuItem_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aHoyDiaToolStripMenuItem,
            this.aFechaToolStripMenuItem});
            this.actualizarToolStripMenuItem.Enabled = false;
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            this.actualizarToolStripMenuItem.Visible = false;
            this.actualizarToolStripMenuItem.Click += new System.EventHandler(this.actualizarToolStripMenuItem_Click);
            // 
            // aHoyDiaToolStripMenuItem
            // 
            this.aHoyDiaToolStripMenuItem.Name = "aHoyDiaToolStripMenuItem";
            this.aHoyDiaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.aHoyDiaToolStripMenuItem.Text = "Periodos";
            this.aHoyDiaToolStripMenuItem.Click += new System.EventHandler(this.aHoyDiaToolStripMenuItem_Click);
            // 
            // aFechaToolStripMenuItem
            // 
            this.aFechaToolStripMenuItem.Name = "aFechaToolStripMenuItem";
            this.aFechaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.aFechaToolStripMenuItem.Text = "A una Fecha";
            this.aFechaToolStripMenuItem.Click += new System.EventHandler(this.aFechaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 169);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvResIniCoac);
            this.groupBox3.Location = new System.Drawing.Point(393, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 148);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RESOLUCION EN EJECUCION COACTIVA";
            // 
            // dgvResIniCoac
            // 
            this.dgvResIniCoac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResIniCoac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResIniCoac.Location = new System.Drawing.Point(3, 16);
            this.dgvResIniCoac.Name = "dgvResIniCoac";
            this.dgvResIniCoac.Size = new System.Drawing.Size(384, 129);
            this.dgvResIniCoac.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListaRds);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RESOLUCIONES";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 306);
            this.panel2.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvResFra);
            this.groupBox4.Location = new System.Drawing.Point(393, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(380, 142);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RESOLUCION DE FRACCIONAMIENTO";
            // 
            // dgvResFra
            // 
            this.dgvResFra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResFra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResFra.Location = new System.Drawing.Point(3, 16);
            this.dgvResFra.Name = "dgvResFra";
            this.dgvResFra.Size = new System.Drawing.Size(374, 123);
            this.dgvResFra.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListaOrdenesPago);
            this.groupBox2.Location = new System.Drawing.Point(15, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 142);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ORDENES DE PAGO";
            // 
            // dgvListaOrdenesPago
            // 
            this.dgvListaOrdenesPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaOrdenesPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaOrdenesPago.Location = new System.Drawing.Point(3, 16);
            this.dgvListaOrdenesPago.Name = "dgvListaOrdenesPago";
            this.dgvListaOrdenesPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaOrdenesPago.Size = new System.Drawing.Size(366, 123);
            this.dgvListaOrdenesPago.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblAlerta4);
            this.panel3.Controls.Add(this.lblAlerta3);
            this.panel3.Controls.Add(this.lblAlerta2);
            this.panel3.Controls.Add(this.lblAlerta1);
            this.panel3.Controls.Add(this.btnAlerta);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(795, 140);
            this.panel3.TabIndex = 3;
            // 
            // lblAlerta4
            // 
            this.lblAlerta4.AutoSize = true;
            this.lblAlerta4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta4.ForeColor = System.Drawing.Color.Red;
            this.lblAlerta4.Location = new System.Drawing.Point(180, 105);
            this.lblAlerta4.Name = "lblAlerta4";
            this.lblAlerta4.Size = new System.Drawing.Size(63, 24);
            this.lblAlerta4.TabIndex = 4;
            this.lblAlerta4.Text = "label1";
            this.lblAlerta4.Visible = false;
            // 
            // lblAlerta3
            // 
            this.lblAlerta3.AutoSize = true;
            this.lblAlerta3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta3.ForeColor = System.Drawing.Color.Red;
            this.lblAlerta3.Location = new System.Drawing.Point(180, 72);
            this.lblAlerta3.Name = "lblAlerta3";
            this.lblAlerta3.Size = new System.Drawing.Size(63, 24);
            this.lblAlerta3.TabIndex = 3;
            this.lblAlerta3.Text = "label1";
            this.lblAlerta3.Visible = false;
            // 
            // lblAlerta2
            // 
            this.lblAlerta2.AutoSize = true;
            this.lblAlerta2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta2.ForeColor = System.Drawing.Color.Red;
            this.lblAlerta2.Location = new System.Drawing.Point(180, 36);
            this.lblAlerta2.Name = "lblAlerta2";
            this.lblAlerta2.Size = new System.Drawing.Size(63, 24);
            this.lblAlerta2.TabIndex = 2;
            this.lblAlerta2.Text = "label1";
            this.lblAlerta2.Visible = false;
            // 
            // lblAlerta1
            // 
            this.lblAlerta1.AutoSize = true;
            this.lblAlerta1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlerta1.ForeColor = System.Drawing.Color.Red;
            this.lblAlerta1.Location = new System.Drawing.Point(180, 3);
            this.lblAlerta1.Name = "lblAlerta1";
            this.lblAlerta1.Size = new System.Drawing.Size(63, 24);
            this.lblAlerta1.TabIndex = 1;
            this.lblAlerta1.Text = "label1";
            this.lblAlerta1.Visible = false;
            // 
            // btnAlerta
            // 
            this.btnAlerta.BackColor = System.Drawing.Color.White;
            this.btnAlerta.Image = global::SISCONVAL.Properties.Resources.alerta_x70;
            this.btnAlerta.Location = new System.Drawing.Point(18, 3);
            this.btnAlerta.Name = "btnAlerta";
            this.btnAlerta.Size = new System.Drawing.Size(146, 125);
            this.btnAlerta.TabIndex = 0;
            this.btnAlerta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAlerta.UseVisualStyleBackColor = false;
            this.btnAlerta.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frmListaRDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 499);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListaRDs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Resoluciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRds)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResIniCoac)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResFra)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaOrdenesPago)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaRds;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListaOrdenesPago;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAlerta;
        private System.Windows.Forms.Label lblAlerta2;
        private System.Windows.Forms.Label lblAlerta1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aHoyDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvResIniCoac;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvResFra;
        private System.Windows.Forms.Label lblAlerta4;
        private System.Windows.Forms.Label lblAlerta3;
        private System.Windows.Forms.ToolStripMenuItem anularRDToolStripMenuItem;
    }
}