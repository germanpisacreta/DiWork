namespace DiWork.Presentacion
{
    partial class FrmPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPresupuesto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.gbDatosVehiculo = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblGenerico = new System.Windows.Forms.Label();
            this.txtGenerico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.gbDesperfectos = new System.Windows.Forms.GroupBox();
            this.picAgregar = new System.Windows.Forms.PictureBox();
            this.picDetalle = new System.Windows.Forms.PictureBox();
            this.dgvDesperfectos = new System.Windows.Forms.DataGridView();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblManoObra = new System.Windows.Forms.Label();
            this.txtManoObra = new System.Windows.Forms.TextBox();
            this.lblDescip = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRecargo = new System.Windows.Forms.Label();
            this.txtTotalDesperfectos = new System.Windows.Forms.TextBox();
            this.txtRecargo = new System.Windows.Forms.TextBox();
            this.gcIdDesperfecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcManoObra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcCantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbldias = new System.Windows.Forms.Label();
            this.gbCliente.SuspendLayout();
            this.gbDatosVehiculo.SuspendLayout();
            this.gbDesperfectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesperfectos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(9, 42);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(48, 13);
            this.lblVehiculo.TabIndex = 0;
            this.lblVehiculo.Text = "Vehiculo";
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Location = new System.Drawing.Point(123, 39);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cmbVehiculo.TabIndex = 1;
            this.cmbVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbVehiculo_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 33);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lblMail);
            this.gbCliente.Controls.Add(this.txtMail);
            this.gbCliente.Controls.Add(this.txtApellido);
            this.gbCliente.Controls.Add(this.lblApellido);
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Controls.Add(this.txtNombre);
            this.gbCliente.Location = new System.Drawing.Point(4, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(784, 100);
            this.gbCliente.TabIndex = 4;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos Clientes";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(372, 36);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 7;
            this.lblMail.Text = "Mail";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(440, 33);
            this.txtMail.MaxLength = 100;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(250, 33);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(200, 36);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // gbDatosVehiculo
            // 
            this.gbDatosVehiculo.Controls.Add(this.lblTipo);
            this.gbDatosVehiculo.Controls.Add(this.cmbTipo);
            this.gbDatosVehiculo.Controls.Add(this.lblGenerico);
            this.gbDatosVehiculo.Controls.Add(this.txtGenerico);
            this.gbDatosVehiculo.Controls.Add(this.label3);
            this.gbDatosVehiculo.Controls.Add(this.txtPatente);
            this.gbDatosVehiculo.Controls.Add(this.label2);
            this.gbDatosVehiculo.Controls.Add(this.txtModelo);
            this.gbDatosVehiculo.Controls.Add(this.label1);
            this.gbDatosVehiculo.Controls.Add(this.txtMarca);
            this.gbDatosVehiculo.Controls.Add(this.lblVehiculo);
            this.gbDatosVehiculo.Controls.Add(this.cmbVehiculo);
            this.gbDatosVehiculo.Location = new System.Drawing.Point(4, 118);
            this.gbDatosVehiculo.Name = "gbDatosVehiculo";
            this.gbDatosVehiculo.Size = new System.Drawing.Size(784, 134);
            this.gbDatosVehiculo.TabIndex = 5;
            this.gbDatosVehiculo.TabStop = false;
            this.gbDatosVehiculo.Text = "Datos Vehiculo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(254, 82);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 16;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.Visible = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(308, 79);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(100, 21);
            this.cmbTipo.TabIndex = 17;
            this.cmbTipo.Visible = false;
            // 
            // lblGenerico
            // 
            this.lblGenerico.AutoSize = true;
            this.lblGenerico.Location = new System.Drawing.Point(9, 85);
            this.lblGenerico.Name = "lblGenerico";
            this.lblGenerico.Size = new System.Drawing.Size(50, 13);
            this.lblGenerico.TabIndex = 15;
            this.lblGenerico.Text = "Generico";
            this.lblGenerico.Visible = false;
            // 
            // txtGenerico
            // 
            this.txtGenerico.Location = new System.Drawing.Point(123, 79);
            this.txtGenerico.Name = "txtGenerico";
            this.txtGenerico.Size = new System.Drawing.Size(121, 20);
            this.txtGenerico.TabIndex = 14;
            this.txtGenerico.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Patente";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(678, 40);
            this.txtPatente.MaxLength = 50;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(495, 40);
            this.txtModelo.MaxLength = 50;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(308, 40);
            this.txtMarca.MaxLength = 50;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 8;
            // 
            // gbDesperfectos
            // 
            this.gbDesperfectos.Controls.Add(this.lbldias);
            this.gbDesperfectos.Controls.Add(this.picAgregar);
            this.gbDesperfectos.Controls.Add(this.picDetalle);
            this.gbDesperfectos.Controls.Add(this.dgvDesperfectos);
            this.gbDesperfectos.Controls.Add(this.txtTiempo);
            this.gbDesperfectos.Controls.Add(this.lblTiempo);
            this.gbDesperfectos.Controls.Add(this.lblManoObra);
            this.gbDesperfectos.Controls.Add(this.txtManoObra);
            this.gbDesperfectos.Controls.Add(this.lblDescip);
            this.gbDesperfectos.Controls.Add(this.txtDescrip);
            this.gbDesperfectos.Location = new System.Drawing.Point(4, 258);
            this.gbDesperfectos.Name = "gbDesperfectos";
            this.gbDesperfectos.Size = new System.Drawing.Size(784, 253);
            this.gbDesperfectos.TabIndex = 6;
            this.gbDesperfectos.TabStop = false;
            this.gbDesperfectos.Text = "Desperfectos";
            // 
            // picAgregar
            // 
            this.picAgregar.Image = ((System.Drawing.Image)(resources.GetObject("picAgregar.Image")));
            this.picAgregar.Location = new System.Drawing.Point(699, 22);
            this.picAgregar.Name = "picAgregar";
            this.picAgregar.Size = new System.Drawing.Size(39, 30);
            this.picAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAgregar.TabIndex = 26;
            this.picAgregar.TabStop = false;
            this.picAgregar.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // picDetalle
            // 
            this.picDetalle.Image = ((System.Drawing.Image)(resources.GetObject("picDetalle.Image")));
            this.picDetalle.Location = new System.Drawing.Point(636, 22);
            this.picDetalle.Name = "picDetalle";
            this.picDetalle.Size = new System.Drawing.Size(39, 30);
            this.picDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDetalle.TabIndex = 25;
            this.picDetalle.TabStop = false;
            this.picDetalle.Click += new System.EventHandler(this.picDetalle_Click);
            // 
            // dgvDesperfectos
            // 
            this.dgvDesperfectos.AllowUserToAddRows = false;
            this.dgvDesperfectos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDesperfectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesperfectos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gcIdDesperfecto,
            this.gcDescripcion,
            this.gcManoObra,
            this.gcTiempo,
            this.gcCantidadProducto});
            this.dgvDesperfectos.Location = new System.Drawing.Point(19, 65);
            this.dgvDesperfectos.Name = "dgvDesperfectos";
            this.dgvDesperfectos.Size = new System.Drawing.Size(753, 171);
            this.dgvDesperfectos.TabIndex = 24;
            this.dgvDesperfectos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDesperfectos_CellClick);
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(461, 29);
            this.txtTiempo.MaxLength = 3;
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempo.TabIndex = 23;
            this.txtTiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTiempo_KeyPress);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(407, 32);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(42, 13);
            this.lblTiempo.TabIndex = 22;
            this.lblTiempo.Text = "Tiempo";
            // 
            // lblManoObra
            // 
            this.lblManoObra.AutoSize = true;
            this.lblManoObra.Location = new System.Drawing.Point(200, 32);
            this.lblManoObra.Name = "lblManoObra";
            this.lblManoObra.Size = new System.Drawing.Size(75, 13);
            this.lblManoObra.TabIndex = 21;
            this.lblManoObra.Text = "Mano de Obra";
            // 
            // txtManoObra
            // 
            this.txtManoObra.Location = new System.Drawing.Point(281, 29);
            this.txtManoObra.MaxLength = 19;
            this.txtManoObra.Name = "txtManoObra";
            this.txtManoObra.Size = new System.Drawing.Size(100, 20);
            this.txtManoObra.TabIndex = 20;
            this.txtManoObra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtManoObra.TextChanged += new System.EventHandler(this.txtManoObra_TextChanged);
            this.txtManoObra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtManoObra_KeyPress);
            // 
            // lblDescip
            // 
            this.lblDescip.AutoSize = true;
            this.lblDescip.Location = new System.Drawing.Point(8, 32);
            this.lblDescip.Name = "lblDescip";
            this.lblDescip.Size = new System.Drawing.Size(63, 13);
            this.lblDescip.TabIndex = 19;
            this.lblDescip.Text = "Descripción";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(77, 29);
            this.txtDescrip.MaxLength = 200;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(100, 20);
            this.txtDescrip.TabIndex = 18;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(608, 613);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(701, 613);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total Desperfectos";
            // 
            // lblRecargo
            // 
            this.lblRecargo.AutoSize = true;
            this.lblRecargo.Location = new System.Drawing.Point(23, 569);
            this.lblRecargo.Name = "lblRecargo";
            this.lblRecargo.Size = new System.Drawing.Size(48, 13);
            this.lblRecargo.TabIndex = 10;
            this.lblRecargo.Text = "Recargo";
            this.lblRecargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalDesperfectos
            // 
            this.txtTotalDesperfectos.Enabled = false;
            this.txtTotalDesperfectos.Location = new System.Drawing.Point(123, 533);
            this.txtTotalDesperfectos.Name = "txtTotalDesperfectos";
            this.txtTotalDesperfectos.Size = new System.Drawing.Size(100, 20);
            this.txtTotalDesperfectos.TabIndex = 11;
            this.txtTotalDesperfectos.Text = "0";
            this.txtTotalDesperfectos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRecargo
            // 
            this.txtRecargo.Location = new System.Drawing.Point(123, 564);
            this.txtRecargo.MaxLength = 19;
            this.txtRecargo.Name = "txtRecargo";
            this.txtRecargo.Size = new System.Drawing.Size(100, 20);
            this.txtRecargo.TabIndex = 12;
            this.txtRecargo.Text = "0";
            this.txtRecargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRecargo.TextChanged += new System.EventHandler(this.txtRecargo_TextChanged);
            // 
            // gcIdDesperfecto
            // 
            this.gcIdDesperfecto.DataPropertyName = "Id";
            this.gcIdDesperfecto.HeaderText = "Id";
            this.gcIdDesperfecto.Name = "gcIdDesperfecto";
            this.gcIdDesperfecto.ReadOnly = true;
            this.gcIdDesperfecto.Visible = false;
            // 
            // gcDescripcion
            // 
            this.gcDescripcion.DataPropertyName = "Descripcion";
            this.gcDescripcion.HeaderText = "Descripcion";
            this.gcDescripcion.Name = "gcDescripcion";
            this.gcDescripcion.ReadOnly = true;
            this.gcDescripcion.Width = 340;
            // 
            // gcManoObra
            // 
            this.gcManoObra.DataPropertyName = "ManoDeObra";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gcManoObra.DefaultCellStyle = dataGridViewCellStyle16;
            this.gcManoObra.HeaderText = "Mano de Obra";
            this.gcManoObra.Name = "gcManoObra";
            this.gcManoObra.ReadOnly = true;
            // 
            // gcTiempo
            // 
            this.gcTiempo.DataPropertyName = "Tiempo";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gcTiempo.DefaultCellStyle = dataGridViewCellStyle17;
            this.gcTiempo.HeaderText = "Tiempo";
            this.gcTiempo.Name = "gcTiempo";
            this.gcTiempo.ReadOnly = true;
            // 
            // gcCantidadProducto
            // 
            this.gcCantidadProducto.DataPropertyName = "CantidadProductos";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.gcCantidadProducto.DefaultCellStyle = dataGridViewCellStyle18;
            this.gcCantidadProducto.HeaderText = "Cantidad Productos";
            this.gcCantidadProducto.Name = "gcCantidadProducto";
            this.gcCantidadProducto.ReadOnly = true;
            this.gcCantidadProducto.Width = 170;
            // 
            // lbldias
            // 
            this.lbldias.AutoSize = true;
            this.lbldias.Location = new System.Drawing.Point(575, 32);
            this.lbldias.Name = "lbldias";
            this.lbldias.Size = new System.Drawing.Size(28, 13);
            this.lbldias.TabIndex = 27;
            this.lbldias.Text = "Dias";
            // 
            // FrmPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 648);
            this.Controls.Add(this.txtRecargo);
            this.Controls.Add(this.txtTotalDesperfectos);
            this.Controls.Add(this.lblRecargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbDesperfectos);
            this.Controls.Add(this.gbDatosVehiculo);
            this.Controls.Add(this.gbCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 687);
            this.MinimumSize = new System.Drawing.Size(816, 687);
            this.Name = "FrmPresupuesto";
            this.Text = "Presupuesto";
            this.Load += new System.EventHandler(this.FrmPresupuesto_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbDatosVehiculo.ResumeLayout(false);
            this.gbDatosVehiculo.PerformLayout();
            this.gbDesperfectos.ResumeLayout(false);
            this.gbDesperfectos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesperfectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.GroupBox gbDatosVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblGenerico;
        private System.Windows.Forms.TextBox txtGenerico;
        private System.Windows.Forms.GroupBox gbDesperfectos;
        private System.Windows.Forms.PictureBox picDetalle;
        private System.Windows.Forms.DataGridView dgvDesperfectos;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblManoObra;
        private System.Windows.Forms.Label lblDescip;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox picAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRecargo;
        private System.Windows.Forms.TextBox txtTotalDesperfectos;
        private System.Windows.Forms.TextBox txtRecargo;
        private System.Windows.Forms.TextBox txtManoObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcIdDesperfecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcManoObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn gcCantidadProducto;
        private System.Windows.Forms.Label lbldias;
    }
}