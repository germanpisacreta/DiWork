using DiWork.Persistencia;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiWork.Logica
{
    public class LogicaMoto : DatosMoto
    {
        #region OBTENER
        public new LogicaMoto ObtenerMotoPorId(long IdVehiculo)
        {
            try
            {
                LogicaMoto moto = JsonConvert.DeserializeObject<LogicaMoto>(base.ObtenerMotoPorId(IdVehiculo));
                return moto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion
    }
}
