using DiWork.Persistencia;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiWork.Logica
{
    public  class LogicaDesperfectoRepuesto : DatosDesperfectoRepuesto
    {
        #region OBTENER
        public new List<LogicaDesperfectoRepuesto> ObtenerDesperfectoRepuesto()
        {
            try
            {
                List<LogicaDesperfectoRepuesto> desperfectoRepuesto = JsonConvert.DeserializeObject<List<LogicaDesperfectoRepuesto>>(base.ObtenerDesperfectoRepuesto());
                return desperfectoRepuesto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion

    }
}
