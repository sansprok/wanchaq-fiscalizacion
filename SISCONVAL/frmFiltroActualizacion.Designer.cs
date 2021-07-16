namespace SISCONVAL
{
    partial class frmFiltroActualizacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnioDesde = new System.Windows.Forms.TextBox();
            this.txtAnioHasta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEL:";
            // 
            // txtAnioDesde
            // 
            this.txtAnioDesde.Location = new System.Drawing.Point(53, 12);
            this.txtAnioDesde.MaxLength = 4;
            this.txtAnioDesde.Name = "txtAnioDesde";
            this.txtAnioDesde.Size = new System.Drawing.Size(100, 20);
            this.txtAnioDesde.TabIndex = 1;
            this.txtAnioDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAnioDesde_KeyPress);
            // 
            // txtAnioHasta
            // 
            this.txtAnioHasta.Location = new System.Drawing.Point(203, 12);
            this.txtAnioHasta.MaxLength = 4;
            this.txtAnioHasta.Name = "txtAnioHasta";
            this.txtAnioHasta.Size = new System.Drawing.Size(100, 20);
            this.txtAnioHasta.TabIndex = 2;
            this.txtAnioHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAnioDesde_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "AL:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(155, 49);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "OK";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(249, 49);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCEL";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // frmFiltroActualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 83);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAnioHasta);
            this.Controls.Add(this.txtAnioDesde);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(348, 122);
            this.MinimumSize = new System.Drawing.Size(348, 122);
            this.Name = "frmFiltroActualizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACTUALIZAR AÑOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnioDesde;
        private System.Windows.Forms.TextBox txtAnioHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}