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
    public partial class FrmReporteRepuestoMasUsado : Form
    {
        
        #region PROPIEDADES
        LogicaRepuesto repuesto = new LogicaRepuesto();
        #endregion

        #region CONSTRUCTOR
        public FrmReporteRepuestoMasUsado()
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
                bSource.DataSource = repuesto.ObtenerRepuestosMasUsado();
                dgvRepuestoMasUsado.DataSource = bSource;
                dgvRepuestoMasUsado.Refresh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion
    }
}
