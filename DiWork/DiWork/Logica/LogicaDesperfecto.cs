using DiWork.Persistencia;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiWork.Logica
{
    public class LogicaDesperfecto : DatosDesperfecto
    {
        #region PROPIEDADES
        public int CantidadProductos { get; set; }
        public Decimal PrecioDesperfecto { get; set; }
        public List<LogicaRepuesto> lstRepuesto { get; set; } = new List<LogicaRepuesto>();
        public List<LogicaRepuesto> lstRepuestoElimnar { get; set; } = new List<LogicaRepuesto>();
        #endregion


        #region VALIDAR
        public string Validar()
        {
            string mensaje = null;
            try
            {
                if (string.IsNullOrEmpty(Descripcion))
                    mensaje = "La descripcion no puede estar vacia \n";

                if (ManoDeObra == 0)
                    mensaje = "La mano de obra no puede ser cero \n";

                if (Tiempo == 0)
                    mensaje = "El tiempo no puede ser cero \n";

                if (CantidadProductos == 0)
                    mensaje = "La cantidad de repuestos no puede ser cero";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return mensaje;
        }
        #endregion

        #region OBTENER
        public new List<LogicaDesperfecto> ObtenerDesperfectoPorId(long IdPresupuesto)
        {
            try
            {
                List<LogicaDesperfecto> desperfecto = JsonConvert.DeserializeObject<List<LogicaDesperfecto>>(base.ObtenerDesperfectoPorId(IdPresupuesto));
                foreach (var item in desperfecto)
                {
                    item.Tiempo = (int)Math.Truncate(item.Tiempo);
                }
                return desperfecto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion
    }
}
