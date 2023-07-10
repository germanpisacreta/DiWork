using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DiWork.Modelos.Clases;
using DiWork.Utilitarios;
using Newtonsoft.Json;

namespace DiWork.Persistencia
{
    public class DatosRepuesto : Repuesto
    {
        #region PROPIEDADES
        private readonly string connectionString = Conexion.ObtenerConnectionString();
        public string Marca { get; set; }
        public string Modelo{ get; set; }
        public long Cantidad { get; set; }
        #endregion

        #region OBTENER
        public string ObtenerRepuestos()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("ObtenerRepuesto", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    // Abrir la conexión y llenar el DataTable
                    connection.Open();
                    dataAdapter.Fill(dataTable);
                }
                return Serializacion.SerializarDataTable(dataTable.Rows);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }
        #endregion

        #region OBTENER REPUESTO MAS USADO
        public string ObtenerRepuestosMasUsado()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("RepuestoMasUsado", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    // Abrir la conexión y llenar el DataTable
                    connection.Open();
                    dataAdapter.Fill(dataTable);
                }
                return Serializacion.SerializarDataTable(dataTable.Rows);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion
    }
}
