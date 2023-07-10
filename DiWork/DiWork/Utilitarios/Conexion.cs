using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DiWork.Utilitarios
{
    public static class Conexion
    {
        public static string ObtenerConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["MiConnectionString"].ConnectionString;
        }
    }
}
