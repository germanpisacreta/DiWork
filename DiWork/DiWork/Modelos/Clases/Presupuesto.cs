using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiWork.Modelos.Clases
{
    public class Presupuesto
    {
        #region PROPIEDADES
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public decimal Total { get; set; }
        public decimal Recargo { get; set; }
        public int Tipo { get; set; }
        public long IdVehiculo { get; set; }
       
        #endregion
    }
}
