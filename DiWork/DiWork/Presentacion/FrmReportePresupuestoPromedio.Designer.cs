namespace DiWork.Presentacion
{
    partial class FrmReportePresupuestoPromedio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportePresupuestoPromedio));
            this.dgvPromedio = new System.Windows.Forms.DataGridView();
            this.gcMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPromedio
            // 
            this.dgvPromedio.AllowUserToAddRows = false;
            this.dgvPromedio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromedio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcMarca,
            this.gcModelo,
            this.gcTotal});
            this.dgvPromedio.Location = new System.Drawing.Point(14, 15);
            this.dgvPromedio.Name = "dgvPromedio";
            this.dgvPromedio.Size = new System.Drawing.Size(443, 302);
            this.dgvPromedio.TabIndex = 0;
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
            // gcTotal
            // 
            this.gcTotal.DataPropertyName = "Total";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gcTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.gcTotal.HeaderText = "Total";
            this.gcTotal.Name = "gcTotal";
            this.gcTotal.ReadOnly = true;
            // 
            // FrmReportePresupuestoPromedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 328);
            this.Controls.Add(this.dgvPromedio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(488, 367);
            this.MinimumSize = new System.Drawing.Size(488, 367);
            this.Name = "FrmReportePresupuestoPromedio";
            this.Text = "Reporte Presupuesto Promedio";
            this.Load += new System.EventHandler(this.FrmReportePresupuestoPromedio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromedio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPromedio;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcTotal;
    }
}