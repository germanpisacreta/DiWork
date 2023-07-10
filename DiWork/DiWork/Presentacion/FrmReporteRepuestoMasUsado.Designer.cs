namespace DiWork.Presentacion
{
    partial class FrmReporteRepuestoMasUsado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteRepuestoMasUsado));
            this.dgvRepuestoMasUsado = new System.Windows.Forms.DataGridView();
            this.gcMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcRepuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestoMasUsado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRepuestoMasUsado
            // 
            this.dgvRepuestoMasUsado.AllowUserToAddRows = false;
            this.dgvRepuestoMasUsado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRepuestoMasUsado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepuestoMasUsado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcMarca,
            this.gcModelo,
            this.gcRepuesto,
            this.gcCantidad});
            this.dgvRepuestoMasUsado.Location = new System.Drawing.Point(7, 24);
            this.dgvRepuestoMasUsado.Name = "dgvRepuestoMasUsado";
            this.dgvRepuestoMasUsado.Size = new System.Drawing.Size(593, 292);
            this.dgvRepuestoMasUsado.TabIndex = 0;
            // 
            // gcMarca
            // 
            this.gcMarca.DataPropertyName = "Marca";
            this.gcMarca.HeaderText = "Marca";
            this.gcMarca.Name = "gcMarca";
            this.gcMarca.ReadOnly = true;
            this.gcMarca.Width = 150;
            // 
            // gcModelo
            // 
            this.gcModelo.DataPropertyName = "Modelo";
            this.gcModelo.HeaderText = "Modelo";
            this.gcModelo.Name = "gcModelo";
            this.gcModelo.ReadOnly = true;
            this.gcModelo.Width = 150;
            // 
            // gcRepuesto
            // 
            this.gcRepuesto.DataPropertyName = "Nombre";
            this.gcRepuesto.HeaderText = "Repuesto";
            this.gcRepuesto.Name = "gcRepuesto";
            this.gcRepuesto.ReadOnly = true;
            this.gcRepuesto.Width = 150;
            // 
            // gcCantidad
            // 
            this.gcCantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gcCantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.gcCantidad.HeaderText = "Cantidad";
            this.gcCantidad.Name = "gcCantidad";
            this.gcCantidad.ReadOnly = true;
            // 
            // FrmReporteRepuestoMasUsado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 328);
            this.Controls.Add(this.dgvRepuestoMasUsado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(650, 367);
            this.MinimumSize = new System.Drawing.Size(550, 367);
            this.Name = "FrmReporteRepuestoMasUsado";
            this.Text = "Reporte Repuesto Mas Usado";
            this.Load += new System.EventHandler(this.FrmReportePresupuestoSumatoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestoMasUsado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRepuestoMasUsado;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcRepuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcCantidad;
    }
}