using DiWork.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiWork.Modelos.Clases
{
    public abstract class Vehiculo
    {
        #region PROPIEDADES
        public long IdVehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        #endregion
        protected string connectionString = Conexion.ObtenerConnectionString();
    }
}
