namespace DiWork.Presentacion
{
    partial class FrmConsultaPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaPresupuesto));
            this.dgvPresupuesto = new System.Windows.Forms.DataGridView();
            this.btnNuevoPresupuesto = new System.Windows.Forms.Button();
            this.gcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReportePresupuesto = new System.Windows.Forms.Button();
            this.btnSumatoria = new System.Windows.Forms.Button();
            this.btnRepuestoMasUsando = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuesto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPresupuesto
            // 
            this.dgvPresupuesto.AllowUserToAddRows = false;
            this.dgvPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresupuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcId,
            this.gcNombre,
            this.gcApellido,
            this.gcEmail,
            this.gcMarca,
            this.gcModelo,
            this.gcPatente,
            this.gcTotal});
            this.dgvPresupuesto.Location = new System.Drawing.Point(12, 60);
            this.dgvPresupuesto.Name = "dgvPresupuesto";
            this.dgvPresupuesto.Size = new System.Drawing.Size(843, 378);
            this.dgvPresupuesto.TabIndex = 0;
            this.dgvPresupuesto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPresupuesto_CellClick);
            // 
            // btnNuevoPresupuesto
            // 
            this.btnNuevoPresupuesto.Location = new System.Drawing.Point(711, 31);
            this.btnNuevoPresupuesto.Name = "btnNuevoPresupuesto";
            this.btnNuevoPresupuesto.Size = new System.Drawing.Size(143, 23);
            this.btnNuevoPresupuesto.TabIndex = 1;
            this.btnNuevoPresupuesto.Text = "Nuevo Presupuesto";
            this.btnNuevoPresupuesto.UseVisualStyleBackColor = true;
            this.btnNuevoPresupuesto.Click += new System.EventHandler(this.btnNuevoPresupuesto_Click);
            // 
            // gcId
            // 
            this.gcId.DataPropertyName = "Id";
            this.gcId.HeaderText = "Id";
            this.gcId.Name = "gcId";
            this.gcId.ReadOnly = true;
            this.gcId.Visible = false;
            // 
            // gcNombre
            // 
            this.gcNombre.DataPropertyName = "Nombre";
            this.gcNombre.HeaderText = "Nombre";
            this.gcNombre.Name = "gcNombre";
            this.gcNombre.ReadOnly = true;
            this.gcNombre.Width = 150;
            // 
            // gcApellido
            // 
            this.gcApellido.DataPropertyName = "Apellido";
            this.gcApellido.HeaderText = "Apellido";
            this.gcApellido.Name = "gcApellido";
            this.gcApellido.ReadOnly = true;
            this.gcApellido.Width = 150;
            // 
            // gcEmail
            // 
            this.gcEmail.DataPropertyName = "Email";
            this.gcEmail.HeaderText = "Email";
            this.gcEmail.Name = "gcEmail";
            this.gcEmail.ReadOnly = true;
            // 
            // gcMarca
            // 
            this.gcMarca.DataPropertyName = "Marca";
            this.gcMarca.HeaderText = "Marca";
            this.gcMarca.Name = "gcMarca";
            this.gcMarca.ReadOnly = true;
            // 
            // gcModelo
            // 
            this.gcModelo.DataPropertyName = "Modelo";
            this.gcModelo.HeaderText = "Modelo";
            this.gcModelo.Name = "gcModelo";
            this.gcModelo.ReadOnly = true;
            // 
            // gcPatente
            // 
            this.gcPatente.DataPropertyName = "Patente";
            this.gcPatente.HeaderText = "Patente";
            this.gcPatente.Name = "gcPatente";
            this.gcPatente.ReadOnly = true;
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
            // btnReportePresupuesto
            // 
            this.btnReportePresupuesto.Location = new System.Drawing.Point(349, 31);
            this.btnReportePresupuesto.Name = "btnReportePresupuesto";
            this.btnReportePresupuesto.Size = new System.Drawing.Size(143, 23);
            this.btnReportePresupuesto.TabIndex = 2;
            this.btnReportePresupuesto.Text = "Reporte Presupuesto";
            this.btnReportePresupuesto.UseVisualStyleBackColor = true;
            this.btnReportePresupuesto.Click += new System.EventHandler(this.btnReportePresupuesto_Click);
            // 
            // btnSumatoria
            // 
            this.btnSumatoria.Location = new System.Drawing.Point(522, 31);
            this.btnSumatoria.Name = "btnSumatoria";
            this.btnSumatoria.Size = new System.Drawing.Size(143, 23);
            this.btnSumatoria.TabIndex = 4;
            this.btnSumatoria.Text = "Reporte Sumatoria";
            this.btnSumatoria.UseVisualStyleBackColor = true;
            this.btnSumatoria.Click += new System.EventHandler(this.btnSumatoria_Click);
            // 
            // btnRepuestoMasUsando
            // 
            this.btnRepuestoMasUsando.Location = new System.Drawing.Point(169, 31);
            this.btnRepuestoMasUsando.Name = "btnRepuestoMasUsando";
            this.btnRepuestoMasUsando.Size = new System.Drawing.Size(143, 23);
            this.btnRepuestoMasUsando.TabIndex = 5;
            this.btnRepuestoMasUsando.Text = "Repuesto Mas Usado";
            this.btnRepuestoMasUsando.UseVisualStyleBackColor = true;
            this.btnRepuestoMasUsando.Click += new System.EventHandler(this.btnRepuestoMasUsando_Click);
            // 
            // FrmConsultaPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.btnRepuestoMasUsando);
            this.Controls.Add(this.btnSumatoria);
            this.Controls.Add(this.btnReportePresupuesto);
            this.Controls.Add(this.btnNuevoPresupuesto);
            this.Controls.Add(this.dgvPresupuesto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaPresupuesto";
            this.Text = "Consulta Presupuesto";
            this.Load += new System.EventHandler(this.FrmConsultaPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuesto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPresupuesto;
        private System.Windows.Forms.Button btnNuevoPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcTotal;
        private System.Windows.Forms.Button btnReportePresupuesto;
        private System.Windows.Forms.Button btnSumatoria;
        private System.Windows.Forms.Button btnRepuestoMasUsando;
    }
}