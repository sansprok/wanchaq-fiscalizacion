
namespace SISCONVAL
{
    partial class Prescripcion
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
            this.dgvPrescripciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaniodesde = new System.Windows.Forms.TextBox();
            this.txtaniohasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbconcepto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrescripciones
            // 
            this.dgvPrescripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescripciones.Location = new System.Drawing.Point(52, 141);
            this.dgvPrescripciones.Name = "dgvPrescripciones";
            this.dgvPrescripciones.Size = new System.Drawing.Size(783, 150);
            this.dgvPrescripciones.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DESDE";
            // 
            // txtaniodesde
            // 
            this.txtaniodesde.Location = new System.Drawing.Point(139, 72);
            this.txtaniodesde.Name = "txtaniodesde";
            this.txtaniodesde.Size = new System.Drawing.Size(100, 20);
            this.txtaniodesde.TabIndex = 1;
            this.txtaniodesde.Text = "1990";
            this.txtaniodesde.TextChanged += new System.EventHandler(this.txtaniodesde_TextChanged);
            this.txtaniodesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaniodesde_KeyPress);
            // 
            // txtaniohasta
            // 
            this.txtaniohasta.Location = new System.Drawing.Point(351, 72);
            this.txtaniohasta.Name = "txtaniohasta";
            this.txtaniohasta.Size = new System.Drawing.Size(100, 20);
            this.txtaniohasta.TabIndex = 2;
            this.txtaniohasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtaniodesde_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "HASTA";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(696, 363);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(139, 55);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(530, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 55);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbconcepto
            // 
            this.cmbconcepto.FormattingEnabled = true;
            this.cmbconcepto.Items.AddRange(new object[] {
            "IP-IMPUESTO PREDIAL",
            "LP-LIMPIEZA PUBLICA",
            "SC-SEGURIDAD"});
            this.cmbconcepto.Location = new System.Drawing.Point(143, 20);
            this.cmbconcepto.Name = "cmbconcepto";
            this.cmbconcepto.Size = new System.Drawing.Size(198, 21);
            this.cmbconcepto.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CONCEPTO:";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(493, 54);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(139, 55);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // Prescripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 469);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbconcepto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtaniohasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtaniodesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPrescripciones);
            this.Name = "Prescripcion";
            this.Text = "PRESCRIPCION";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescripciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrescripciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaniodesde;
        private System.Windows.Forms.TextBox txtaniohasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbconcepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCargar;
    }
}