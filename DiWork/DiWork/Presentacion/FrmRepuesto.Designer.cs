namespace DiWork.Presentacion
{
    partial class FrmRepuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepuesto));
            this.lblRepuestos = new System.Windows.Forms.Label();
            this.cmbRepuestos = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvRepuestos = new System.Windows.Forms.DataGridView();
            this.picAgregar = new System.Windows.Forms.PictureBox();
            this.gcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcRepuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRepuestos
            // 
            this.lblRepuestos.AutoSize = true;
            this.lblRepuestos.Location = new System.Drawing.Point(37, 31);
            this.lblRepuestos.Name = "lblRepuestos";
            this.lblRepuestos.Size = new System.Drawing.Size(58, 13);
            this.lblRepuestos.TabIndex = 0;
            this.lblRepuestos.Text = "Repuestos";
            // 
            // cmbRepuestos
            // 
            this.cmbRepuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRepuestos.FormattingEnabled = true;
            this.cmbRepuestos.Location = new System.Drawing.Point(101, 28);
            this.cmbRepuestos.Name = "cmbRepuestos";
            this.cmbRepuestos.Size = new System.Drawing.Size(121, 21);
            this.cmbRepuestos.TabIndex = 1;
            this.cmbRepuestos.SelectedIndexChanged += new System.EventHandler(this.cmbRepuestos_SelectedIndexChanged);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(37, 70);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(101, 67);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(246, 327);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(340, 327);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvRepuestos
            // 
            this.dgvRepuestos.AllowUserToAddRows = false;
            this.dgvRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcId,
            this.gcRepuesto,
            this.gcPrecio,
            this.gcEliminar});
            this.dgvRepuestos.Location = new System.Drawing.Point(7, 122);
            this.dgvRepuestos.Name = "dgvRepuestos";
            this.dgvRepuestos.Size = new System.Drawing.Size(415, 188);
            this.dgvRepuestos.TabIndex = 6;
            this.dgvRepuestos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRepuestos_CellClick);
            // 
            // picAgregar
            // 
            this.picAgregar.Image = ((System.Drawing.Image)(resources.GetObject("picAgregar.Image")));
            this.picAgregar.Location = new System.Drawing.Point(269, 60);
            this.picAgregar.Name = "picAgregar";
            this.picAgregar.Size = new System.Drawing.Size(39, 30);
            this.picAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAgregar.TabIndex = 27;
            this.picAgregar.TabStop = false;
            this.picAgregar.Click += new System.EventHandler(this.picAgregar_Click);
            // 
            // gcId
            // 
            this.gcId.DataPropertyName = "Id";
            this.gcId.HeaderText = "Id";
            this.gcId.Name = "gcId";
            this.gcId.ReadOnly = true;
            this.gcId.Visible = false;
            // 
            // gcRepuesto
            // 
            this.gcRepuesto.DataPropertyName = "Nombre";
            this.gcRepuesto.HeaderText = "Repuesto";
            this.gcRepuesto.Name = "gcRepuesto";
            this.gcRepuesto.ReadOnly = true;
            this.gcRepuesto.Width = 170;
            // 
            // gcPrecio
            // 
            this.gcPrecio.DataPropertyName = "Precio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gcPrecio.DefaultCellStyle = dataGridViewCellStyle2;
            this.gcPrecio.FillWeight = 80F;
            this.gcPrecio.HeaderText = "Precio";
            this.gcPrecio.Name = "gcPrecio";
            this.gcPrecio.ReadOnly = true;
            // 
            // gcEliminar
            // 
            this.gcEliminar.HeaderText = "Eliminar";
            this.gcEliminar.Image = ((System.Drawing.Image)(resources.GetObject("gcEliminar.Image")));
            this.gcEliminar.Name = "gcEliminar";
            this.gcEliminar.ReadOnly = true;
            // 
            // FrmRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 362);
            this.Controls.Add(this.picAgregar);
            this.Controls.Add(this.dgvRepuestos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cmbRepuestos);
            this.Controls.Add(this.lblRepuestos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(444, 401);
            this.MinimumSize = new System.Drawing.Size(444, 401);
            this.Name = "FrmRepuesto";
            this.Text = "Repuestos";
            this.Load += new System.EventHandler(this.FrmRepuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRepuestos;
        private System.Windows.Forms.ComboBox cmbRepuestos;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvRepuestos;
        private System.Windows.Forms.PictureBox picAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcRepuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcPrecio;
        private System.Windows.Forms.DataGridViewImageColumn gcEliminar;
    }
}