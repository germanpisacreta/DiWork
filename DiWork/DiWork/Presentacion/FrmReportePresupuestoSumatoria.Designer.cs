namespace DiWork.Presentacion
{
    partial class FrmReportePresupuestoSumatoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportePresupuestoSumatoria));
            this.dgvSumatoria = new System.Windows.Forms.DataGridView();
            this.gcModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumatoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSumatoria
            // 
            this.dgvSumatoria.AllowUserToAddRows = false;
            this.dgvSumatoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSumatoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcModelo,
            this.gcTotal});
            this.dgvSumatoria.Location = new System.Drawing.Point(15, 13);
            this.dgvSumatoria.Name = "dgvSumatoria";
            this.dgvSumatoria.Size = new System.Drawing.Size(443, 302);
            this.dgvSumatoria.TabIndex = 1;
            // 
            // gcModelo
            // 
            this.gcModelo.DataPropertyName = "TipoDescrip";
            this.gcModelo.HeaderText = "Tipo";
            this.gcModelo.Name = "gcModelo";
            this.gcModelo.ReadOnly = true;
            this.gcModelo.Width = 300;
            // 
            // gcTotal
            // 
            this.gcTotal.DataPropertyName = "Total";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gcTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.gcTotal.HeaderText = "Total";
            this.gcTotal.Name = "gcTotal";
            this.gcTotal.ReadOnly = true;
            // 
            // FrmReportePresupuestoSumatoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 328);
            this.Controls.Add(this.dgvSumatoria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(488, 367);
            this.MinimumSize = new System.Drawing.Size(488, 367);
            this.Name = "FrmReportePresupuestoSumatoria";
            this.Text = "Reporte Presupuesto Sumatoria";
            this.Load += new System.EventHandler(this.FrmReportePresupuestoSumatoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSumatoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSumatoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcTotal;
    }
}