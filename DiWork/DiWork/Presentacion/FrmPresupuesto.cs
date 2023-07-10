using DiWork.Logica;
using DiWork.Modelos.Clases;
using DiWork.Modelos.Enumerados;
using DiWork.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace DiWork.Presentacion
{
    public partial class FrmPresupuesto : Form
    {
        #region PROPIEDADES
        List<LogicaDesperfecto> lista_LogicaDesperfecto = new List<LogicaDesperfecto>();
        LogicaDesperfecto objLogicaDesperfectos = new LogicaDesperfecto();
        LogicaPresupuesto objLogicaPresupuesto = new LogicaPresupuesto();
        int Id = 0;
        FrmRepuesto frmRepuesto = null;
        #endregion

        #region CONSTRUCTOR
        public FrmPresupuesto()
        {
            InitializeComponent();
        }

        public FrmPresupuesto(int _id)
        {
            InitializeComponent();
            Id = _id;
        }
        #endregion

        #region METODOS
        public void CargarComboTipo()
        {
            // Obtener los valores del Enum como un arreglo
            eTipo[] valores = (eTipo[])Enum.GetValues(typeof(eTipo));

            // Limpiar el combo antes de cargar los nuevos elementos
            cmbTipo.Items.Clear();

            // Agregar los elementos del Enum al combo
            foreach (eTipo valor in valores)
            {
                cmbTipo.Items.Add(valor);
            }
        }

        public void CargarComboVehiculo()
        {
            // Obtener los valores del Enum como un arreglo
            eVehiculo[] valores = (eVehiculo[])Enum.GetValues(typeof(eVehiculo));

            // Limpiar el combo antes de cargar los nuevos elementos
            cmbVehiculo.Items.Clear();

            // Agregar los elementos del Enum al combo
            foreach (eVehiculo valor in valores)
            {
                cmbVehiculo.Items.Add(valor);
            }
        }

       

        public void Cargar(int Id)
        {
            try
            {
                objLogicaPresupuesto = objLogicaPresupuesto.ObtenerPresupuestoID(this.Id);
                txtNombre.Text = objLogicaPresupuesto.Nombre;
                txtApellido.Text = objLogicaPresupuesto.Apellido;
                txtMail.Text = objLogicaPresupuesto.Email;
                txtRecargo.Text = objLogicaPresupuesto.Recargo.ToString();
                cmbVehiculo.SelectedIndex = objLogicaPresupuesto.Tipo;
                ConfigurarVehiculo();
                if (cmbVehiculo.SelectedItem.ToString() == eVehiculo.Automovil.ToString())
                {
                    txtGenerico.Text = objLogicaPresupuesto.objAutomovil.CantidadPuertas.ToString();
                    cmbTipo.SelectedIndex = objLogicaPresupuesto.objAutomovil.Tipo;
                    txtMarca.Text = objLogicaPresupuesto.objAutomovil.Marca;
                    txtModelo.Text = objLogicaPresupuesto.objAutomovil.Modelo;
                    txtPatente.Text = objLogicaPresupuesto.objAutomovil.Patente;
                }
                else
                {
                    txtMarca.Text = objLogicaPresupuesto.objMoto.Marca;
                    txtModelo.Text = objLogicaPresupuesto.objMoto.Modelo;
                    txtPatente.Text = objLogicaPresupuesto.objMoto.Patente;
                    txtGenerico.Text = objLogicaPresupuesto.objMoto.Cilindrado;
                }

                BindingSource bSource = new BindingSource();
                bSource.DataSource = objLogicaPresupuesto.lstDesperfecto;
                dgvDesperfectos.DataSource = bSource;
                dgvDesperfectos.Refresh();
                lista_LogicaDesperfecto = objLogicaPresupuesto.lstDesperfecto;
                txtTotalDesperfectos.Text = objLogicaPresupuesto.lstDesperfecto.Sum(x => x.PrecioDesperfecto).ToString();
                cmbVehiculo.Enabled = false;
            }
            catch (Exception ex)
            {
                Logs.GuardarArchivoTxt(ex.Message);
            }
        }

        public void ConfigurarVehiculo()
        {
            if (cmbVehiculo.SelectedItem.ToString() == eVehiculo.Automovil.ToString())
            {
                lblGenerico.Text = "Cantidad de Puertas";
                cmbTipo.Visible = true;
                lblTipo.Visible = true;
                txtGenerico.Text = "";
                txtGenerico.KeyPress += txtGenerico_KeyPress;
                txtGenerico.TextAlign = HorizontalAlignment.Right;
                txtGenerico.MaxLength = 1;
            }
            else
            {
                lblGenerico.Text = "Cilindrada";
                cmbTipo.Visible = false;
                lblTipo.Visible = false;
                txtGenerico.Text = "";
                txtGenerico.KeyPress -= txtGenerico_KeyPress;
                txtGenerico.TextAlign = HorizontalAlignment.Left;
                txtGenerico.MaxLength = 50;
            }
        }

        public bool ValidarDesperfecto()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDescrip.Text) || !string.IsNullOrEmpty(txtTiempo.Text) || !string.IsNullOrEmpty(txtManoObra.Text))
                {
                    
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                Logs.GuardarArchivoTxt(ex.Message);
            }
            return true;
        }

        public void AgregarSuperTips()
        {
            // Crear una instancia de ToolTip
            ToolTip toolTip = new ToolTip();

            // Establecer propiedades del supertooltip
            toolTip.AutoPopDelay = 5000; 
            toolTip.InitialDelay = 1000; 
            toolTip.ReshowDelay = 500; 

            // Agregar el supertooltip al botón o imagen
            toolTip.SetToolTip(picAgregar, "Agregar Desperfecto");
            toolTip.SetToolTip(picDetalle, "Agregar Respuesto");
        }
        #endregion

        #region EVENTOS

        private void FrmPresupuesto_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDesperfectos.AutoGenerateColumns = false;
                CargarComboTipo();
                CargarComboVehiculo();
                AgregarSuperTips();
                if (this.Id != 0)
                    Cargar(this.Id);
            }
            catch (Exception ex)
            {
                Logs.GuardarArchivoTxt(ex.Message);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtManoObra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTiempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void picDetalle_Click(object sender, EventArgs e)
        {
            Repuesto objRepuesto = new Repuesto();
            frmRepuesto = new FrmRepuesto(ref objLogicaDesperfectos);
            if (frmRepuesto.ShowDialog() == DialogResult.OK)
            {
                frmRepuesto = null;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string mensaje = null;
            try
            {

                if (!ValidarDesperfecto())
                {
                    if (MessageBox.Show("¿Existe un desperfecto sin agregar\n Desea continuar?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                }

                objLogicaPresupuesto.Nombre = txtNombre.Text;
                objLogicaPresupuesto.Apellido = txtApellido.Text;
                objLogicaPresupuesto.Email = txtMail.Text;
                objLogicaPresupuesto.Recargo = Convert.ToDecimal(txtRecargo.Text);
                objLogicaPresupuesto.Total = Convert.ToDecimal(txtTotalDesperfectos.Text) + (string.IsNullOrEmpty(txtRecargo.Text) ? 0 : Convert.ToDecimal(txtRecargo.Text));
                objLogicaPresupuesto.Tipo = cmbVehiculo.SelectedIndex;
                if (cmbVehiculo.SelectedItem.ToString() == eVehiculo.Automovil.ToString())
                {
                    long id = 0;
                    if (objLogicaPresupuesto.objAutomovil != null)
                        id =  objLogicaPresupuesto.objAutomovil.Id;
                    objLogicaPresupuesto.objAutomovil = new LogicaAutomovil();
                    objLogicaPresupuesto.objAutomovil.Id = id;
                    objLogicaPresupuesto.objAutomovil.Marca = txtMarca.Text;
                    objLogicaPresupuesto.objAutomovil.Modelo = txtModelo.Text;
                    objLogicaPresupuesto.objAutomovil.Patente = txtPatente.Text;
                    objLogicaPresupuesto.objAutomovil.IdVehiculo = objLogicaPresupuesto.IdVehiculo;
                    objLogicaPresupuesto.objAutomovil.Tipo = cmbVehiculo.SelectedIndex;
                    if (!string.IsNullOrEmpty(txtGenerico.Text))
                        objLogicaPresupuesto.objAutomovil.CantidadPuertas = Convert.ToInt16(txtGenerico.Text);
                    else
                        objLogicaPresupuesto.objAutomovil.CantidadPuertas = 0;
                }
                else
                {
                    long id = 0;
                    if (objLogicaPresupuesto.objMoto != null)
                        id = objLogicaPresupuesto.objMoto.Id;

                    objLogicaPresupuesto.objMoto = new LogicaMoto();
                    objLogicaPresupuesto.objMoto.Id = id;
                    objLogicaPresupuesto.objMoto.Marca = txtMarca.Text;
                    objLogicaPresupuesto.objMoto.Modelo = txtModelo.Text;
                    objLogicaPresupuesto.objMoto.Patente = txtPatente.Text;
                    objLogicaPresupuesto.objMoto.Cilindrado = txtGenerico.Text;
                    objLogicaPresupuesto.objMoto.IdVehiculo = objLogicaPresupuesto.IdVehiculo;
                }
                objLogicaPresupuesto.lstDesperfecto = lista_LogicaDesperfecto;
                mensaje = objLogicaPresupuesto.Validar();
                if (string.IsNullOrEmpty(mensaje))
                {
                    objLogicaPresupuesto.GrabarPresupuesto();
                    MessageBox.Show("Grabación exitosa");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(mensaje);
                    return;
                }

            }
            catch (Exception ex)
            {
                Logs.GuardarArchivoTxt(ex.Message);
            }
        }

        private void cmbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVehiculo.SelectedItem != null)
            {
                lblGenerico.Visible = true;
                txtGenerico.Visible = true;
                ConfigurarVehiculo();

            }
            else
            {
                lblGenerico.Visible = false;
                txtGenerico.Visible = false;
            }
        }
        private void picAdd_Click(object sender, EventArgs e)
        {
            string mensaje = null;
            try
            {
                objLogicaDesperfectos.Descripcion = txtDescrip.Text;
                if (!string.IsNullOrEmpty(txtManoObra.Text))
                    objLogicaDesperfectos.ManoDeObra = Convert.ToDecimal(txtManoObra.Text);
                else
                    objLogicaDesperfectos.ManoDeObra = 0;

                if (!string.IsNullOrEmpty(txtTiempo.Text))
                    objLogicaDesperfectos.Tiempo = Convert.ToInt32(txtTiempo.Text);
                else
                    objLogicaDesperfectos.Tiempo = 0;
                objLogicaDesperfectos.CantidadProductos = objLogicaDesperfectos.lstRepuesto.Count();
                mensaje = objLogicaDesperfectos.Validar();
                if (string.IsNullOrEmpty(mensaje))
                {

                    if (lista_LogicaDesperfecto.Where(x => x.Id == objLogicaDesperfectos.Id).Count() == 0)
                    {
                        lista_LogicaDesperfecto.Add(objLogicaDesperfectos);
                        BindingSource bSource = new BindingSource();
                        bSource.DataSource = lista_LogicaDesperfecto;
                        dgvDesperfectos.DataSource = bSource;
                        
                        objLogicaDesperfectos = new LogicaDesperfecto();
                        txtTotalDesperfectos.Text = (Convert.ToDecimal(txtTotalDesperfectos.Text) + Convert.ToDecimal(lista_LogicaDesperfecto.Sum(x => x.lstRepuesto.Sum(c => c.Precio)))).ToString();

                    }
                    else
                    {
                        lista_LogicaDesperfecto.Where(x => x.Id == objLogicaDesperfectos.Id).FirstOrDefault().Descripcion = txtDescrip.Text;
                        if (!string.IsNullOrEmpty(txtManoObra.Text))
                            lista_LogicaDesperfecto.Where(x => x.Id == objLogicaDesperfectos.Id).FirstOrDefault().ManoDeObra = Convert.ToDecimal(txtManoObra.Text);
                        else
                            lista_LogicaDesperfecto.Where(x => x.Id == objLogicaDesperfectos.Id).FirstOrDefault().ManoDeObra = 0;

                        if (!string.IsNullOrEmpty(txtTiempo.Text))
                            lista_LogicaDesperfecto.Where(x => x.Id == objLogicaDesperfectos.Id).FirstOrDefault().Tiempo = Convert.ToInt32(txtTiempo.Text);
                        else
                            lista_LogicaDesperfecto.Where(x => x.Id == objLogicaDesperfectos.Id).FirstOrDefault().Tiempo = 0;
                        lista_LogicaDesperfecto.Where(x => x.Id == objLogicaDesperfectos.Id).FirstOrDefault().CantidadProductos = objLogicaDesperfectos.lstRepuesto.Count();
                    }
                    dgvDesperfectos.Refresh();
                    txtTiempo.Text = "";
                    txtManoObra.Text = "";
                    txtDescrip.Text = "";

                }
                else
                {
                    MessageBox.Show(mensaje);
                    return;
                }
            }
            catch (Exception ex)
            {
                Logs.GuardarArchivoTxt(ex.Message);
            }

        }

        private void txtGenerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvDesperfectos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;


                if (rowIndex >= 0 && rowIndex < dgvDesperfectos.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvDesperfectos.Rows[rowIndex];

                    int id = Convert.ToInt32(selectedRow.Cells["gcIdDesperfecto"].Value);
                    txtDescrip.Text = Convert.ToString(selectedRow.Cells["gcDescripcion"].Value);
                    txtManoObra.Text = Convert.ToString(selectedRow.Cells["gcManoObra"].Value);
                    txtTiempo.Text = Convert.ToString(selectedRow.Cells["gcTiempo"].Value);
                    objLogicaDesperfectos = objLogicaPresupuesto.lstDesperfecto.Where(x => x.Id == id).FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                Logs.GuardarArchivoTxt(ex.Message);
            }
        }
        private void txtManoObra_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtManoObra.Text))
            {
                decimal valor;
                if (decimal.TryParse(txtManoObra.Text, out valor))
                {
                    txtManoObra.Text = valor.ToString("##########0.000000").PadRight(6, '0');
                }
                else
                {
                    txtManoObra.Text = string.Empty;
                }
            }
        }

        private void txtRecargo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRecargo.Text))
            {
                decimal valor;
                if (decimal.TryParse(txtRecargo.Text, out valor))
                {
                    txtRecargo.Text = valor.ToString("##########0.000000").PadRight(6, '0');
                }
                else
                {
                    txtRecargo.Text = string.Empty;
                }
            }
        }
        #endregion


    }
}
