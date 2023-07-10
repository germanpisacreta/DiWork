using DiWork.Logica;
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

namespace DiWork.Presentacion
{
    public partial class FrmConsultaPresupuesto : Form
    {
        #region PROPIEDADES
        FrmPresupuesto frmPresupuesto = new FrmPresupuesto();
        FrmReportePresupuestoPromedio FrmReportePresupuestoPromedio = new FrmReportePresupuestoPromedio();
        FrmReportePresupuestoSumatoria FrmReportePresupuestoSumatoria = new FrmReportePresupuestoSumatoria();
        FrmReporteRepuestoMasUsado FrmReporteRepuestoMasUsado = new FrmReporteRepuestoMasUsado();
        #endregion

        #region CONSTRUCTOR
        public FrmConsultaPresupuesto()
        {
            InitializeComponent();
        }
        #endregion

        #region EVENTOS
        private void FrmConsultaPresupuesto_Load(object sender, EventArgs e)
        {
            try
            {
                dgvPresupuesto.AutoGenerateColumns = false;
                Cargar();

            }
            catch (Exception ex)
            {
                Logs.GuardarArchivoTxt(ex.Message);
            }
        }

        private void btnNuevoPresupuesto_Click(object sender, EventArgs e)
        {
            try
            {
                frmPresupuesto = new FrmPresupuesto();
                frmPresupuesto.ShowDialog();
                frmPresupuesto = null;
                Cargar();
            }
            catch (Exception ex)
            {
                Logs.GuardarArchivoTxt(ex.Message);
            }
        }

        private void dgvPresupuesto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;


                if (rowIndex >= 0 && rowIndex < dgvPresupuesto.Rows.Count)
                {
                    DataGridViewRow selectedRow = dgvPresupuesto.Rows[rowIndex];

                    int id = Convert.ToInt32(selectedRow.Cells["gcId"].Value);

                    frmPresupuesto = new FrmPresupuesto(id);
                    frmPresupuesto.ShowDialog();
                    frmPresupuesto = null;
                    Cargar();
                }

            }
            catch (Exception ex)
            {
                Logs.GuardarArchivoTxt(ex.Message);
            }
        }
        #endregion

        #region METODOS
        public void Cargar()
        {
            try
            {
                LogicaPresupuesto objLogicaPresupuesto = new LogicaPresupuesto();
                
                BindingSource bSource = new BindingSource();
                bSource.DataSource = objLogicaPresupuesto.ObtenerPresupuesto();
                dgvPresupuesto.DataSource = bSource;
                dgvPresupuesto.Refresh();
            }
            catch (Exception ex)
            {
                Logs.GuardarArchivoTxt(ex.Message);
            }
}
        #endregion

        private void btnReportePresupuesto_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReportePresupuestoPromedio = new FrmReportePresupuestoPromedio();
                FrmReportePresupuestoPromedio.ShowDialog();
                FrmReportePresupuestoPromedio = null;
            }
            catch (Exception ex)
            {
                Logs.GuardarArchivoTxt(ex.Message);
            }
}

        private void btnSumatoria_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReportePresupuestoSumatoria = new FrmReportePresupuestoSumatoria();
                FrmReportePresupuestoSumatoria.ShowDialog();
                FrmReportePresupuestoSumatoria = null;
            }
            catch (Exception ex)
            {
                Logs.GuardarArchivoTxt(ex.Message);
            }
        }

        private void btnRepuestoMasUsando_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReporteRepuestoMasUsado = new FrmReporteRepuestoMasUsado();
                FrmReporteRepuestoMasUsado.ShowDialog();
                FrmReporteRepuestoMasUsado = null;
            }
            catch (Exception ex)
            {
                Logs.GuardarArchivoTxt(ex.Message);
            }
        }
    }
}
