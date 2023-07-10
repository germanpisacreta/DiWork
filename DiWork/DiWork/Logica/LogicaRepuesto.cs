using DiWork.Modelos.Clases;
using DiWork.Persistencia;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiWork.Logica
{
    public class LogicaRepuesto : DatosRepuesto
    {

        #region OBTENER
        public new List<LogicaRepuesto> ObtenerRepuestos()
        {
            try
            {
                List<LogicaRepuesto> repuesto = JsonConvert.DeserializeObject<List<LogicaRepuesto>>(base.ObtenerRepuestos());
                return repuesto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion

        #region OBTENER REPUESTO MAS USADO
        public new List<LogicaRepuesto> ObtenerRepuestosMasUsado()
        {
            try
            {
                List<LogicaRepuesto> repuesto = JsonConvert.DeserializeObject<List<LogicaRepuesto>>(base.ObtenerRepuestosMasUsado());
                repuesto = new List<LogicaRepuesto>(repuesto.OrderBy(x => x.Marca).ThenBy(x => x.Modelo).ThenByDescending(x => x.Cantidad).ToList());
                return repuesto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion



    }
}
