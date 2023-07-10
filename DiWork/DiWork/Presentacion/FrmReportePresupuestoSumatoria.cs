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
    public partial class FrmReportePresupuestoSumatoria : Form
    {
       
        #region PROPIEDADES
        LogicaPresupuesto presupuestos = new LogicaPresupuesto();
        #endregion

        #region CONSTRUCTOR
        public FrmReportePresupuestoSumatoria()
        {
            InitializeComponent();
        }
        #endregion
        #region EVENTOS
        private void FrmReportePresupuestoSumatoria_Load(object sender, EventArgs e)
        {
            try
            {
                BindingSource bSource = new BindingSource();
                bSource.DataSource = presupuestos.ObtenerSumatoria();
                dgvSumatoria.DataSource = bSource;
                dgvSumatoria.Refresh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion
    }
}
