using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiWork.Modelos.Clases
{
    
    public class Desperfecto
    {
        #region PROPIEDADES
            public long Id { get; set; }
            public long IdPresupuesto { get; set; }
            public string Descripcion { get; set; }
            public decimal ManoDeObra { get; set; }
            public decimal Tiempo { get; set; }
            
        #endregion
    }

}
