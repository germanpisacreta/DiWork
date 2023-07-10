using DiWork.Logica;
using DiWork.Modelos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiWork.Presentacion
{
    public partial class FrmRepuesto : Form
    {
        #region PROPIEDADES
            LogicaRepuesto objLogicaRepuesto = new LogicaRepuesto();
            LogicaDesperfecto LogicaDesperfectos = new LogicaDesperfecto();
        #endregion

        #region CONSTRUCTOR
        public FrmRepuesto(ref LogicaDesperfecto _logicaDesperfectos)
        {
            InitializeComponent();
            LogicaDesperfectos = _logicaDesperfectos;
        }
        #endregion

        #region EVENTOS
        private void FrmRepuesto_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombo();
                if (LogicaDesperfectos.lstRepuesto.Count > 0)
                {
                    dgvRepuestos.AutoGenerateColumns = false;
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = LogicaDesperfectos.lstRepuesto;
                    dgvRepuestos.DataSource = bSource;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void cmbRepuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbRepuestos.SelectedValue != null)
                    txtPrecio.Text = ((LogicaRepuesto)cmbRepuestos.SelectedItem).Precio.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }

        private void picAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                LogicaRepuesto objRepuesto = (LogicaRepuesto)cmbRepuestos.SelectedItem;
                if (LogicaDesperfectos.lstRepuesto.Where(x => x.Id == objRepuesto.Id).Count() == 0)
                {
                    LogicaDesperfectos.lstRepuesto.Add(objRepuesto);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = LogicaDesperfectos.lstRepuesto;
                    dgvRepuestos.DataSource = bSource;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void dgvRepuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dataGridView = (DataGridView)sender;
                DataGridViewColumn clickedColumn = dataGridView.Columns[e.ColumnIndex];
                string columnName = clickedColumn.Name;
                if (columnName == "gcEliminar")
                {
                    DataGridViewRow clickedRow = dataGridView.Rows[e.RowIndex];

                    // Acceder a los valores de las celdas de la fila
                    LogicaRepuesto logicaRepuesto = new LogicaRepuesto();
                    logicaRepuesto.Id = Convert.ToInt32(clickedRow.Cells["gcId"].Value);
                    logicaRepuesto.Nombre = clickedRow.Cells["gcRepuesto"].Value.ToString();
                    logicaRepuesto.Precio = Convert.ToDecimal(clickedRow.Cells["gcPrecio"].Value);


                    LogicaDesperfectos.lstRepuestoElimnar.Add(logicaRepuesto);
                    LogicaDesperfectos.lstRepuesto.RemoveAt(e.RowIndex);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = LogicaDesperfectos.lstRepuesto;
                    dgvRepuestos.DataSource = bSource;

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region METODO
        private void CargarCombo()
        {
            try
            {
                cmbRepuestos.DataSource = objLogicaRepuesto.ObtenerRepuestos();
                cmbRepuestos.ValueMember = "Id";
                cmbRepuestos.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

       
    }
}
