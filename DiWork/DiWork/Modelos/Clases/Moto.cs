using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiWork.Modelos.Clases
{
    public class Moto : Vehiculo
    {
        #region PROPIEDADES
        public long Id { get; set; }
        public string Cilindrado { get; set; }
        #endregion
    }
}
