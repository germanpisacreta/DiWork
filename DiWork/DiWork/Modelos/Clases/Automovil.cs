using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiWork.Modelos.Clases
{
    public class Automovil : Vehiculo
    {
        #region PROPIEDADES
        public long Id { get; set; }
        public int Tipo { get; set; }
        public decimal CantidadPuertas { get; set; }
        #endregion

    }
}
