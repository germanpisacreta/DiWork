using DiWork.Persistencia;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiWork.Logica
{
    public class LogicaAutomovil : DatosAutomovil
    {
        #region OBTENER
        public new LogicaAutomovil ObtenerAutomovilPorId(long IdVehiculo)
        {
            try
            {
                LogicaAutomovil automovil = JsonConvert.DeserializeObject<LogicaAutomovil>(base.ObtenerAutomovilPorId(IdVehiculo));
                automovil.CantidadPuertas = (int)Math.Truncate(automovil.CantidadPuertas); 
                return automovil;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion  
    }
}
