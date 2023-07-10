using DiWork.Logica;
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
    public partial class FrmReportePresupuestoPromedio : Form
    {
        #region PROPIEDADES
        LogicaPresupuesto presupuestos = new LogicaPresupuesto();
        #endregion

        #region CONSTRUCTOR
        public FrmReportePresupuestoPromedio()
        {
            InitializeComponent();
        }
        #endregion
        #region EVENTOS
        private void FrmReportePresupuestoPromedio_Load(object sender, EventArgs e)
        {
            try
            {
                BindingSource bSource = new BindingSource();
                bSource.DataSource = presupuestos.ObtenerPromedio();
                dgvPromedio.DataSource = bSource;
                dgvPromedio.Refresh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
        #endregion
    }
}
