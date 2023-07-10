using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DiWork.Modelos.Clases;
using DiWork.Utilitarios;
using Newtonsoft.Json;

namespace DiWork.Persistencia
{
    public class DatosPresupuesto : Presupuesto
    {
        #region PROPIEDADES
        public  string connectionString = Conexion.ObtenerConnectionString();
        public string Marca {get;set;}
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public string TipoDescrip { get; set; }
        #endregion

        #region OBTENER
        public string ObtenerPresupuesto()
        {
            try
            {
                DataTable dataTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("ObtenerPresupuesto", connection);
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


        #region OBTENER PROMEDIO
        public string ObtenerPromedio()
        {
            try
            {
                DataTable dataTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("PromedioMonto", connection);
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

        #region OBTENER SUMATORIA
        public string ObtenerSumatoria()
        {
            try
            {
                DataTable dataTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("SumatoriaMonto", connection);
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

        #region OBTENER POR ID
        public string ObtenerPresupuestoID(int Id)
        {
            try
            {
                DataTable dataTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("ObtenerPresupuestoPorId", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", Id);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    // Abrir la conexión y llenar el DataTable
                    connection.Open();
                    dataAdapter.Fill(dataTable);
                }
                return Serializacion.SerializarDataRow(dataTable.Rows[0]);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region INSERTAR

        

        public void InsertarPresupuesto(SqlConnection connection, SqlTransaction trans)
        {
            try
            {
                
                    if (connection.State != ConnectionState.Open)
                        connection.Open();


                    using (SqlCommand command = new SqlCommand("Presupuesto_Insertar"))
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Apellido", Apellido);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Total", Total);
                        command.Parameters.AddWithValue("@Recargo", Recargo);
                        command.Parameters.AddWithValue("@Tipo", Tipo);
                        command.Parameters.AddWithValue("@IdVehiculo", IdVehiculo);
                        command.Transaction = trans;
                        Id = Convert.ToInt32(command.ExecuteScalar());
                    }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion 

        #region ACTUALIZAR
        public void ActualizarPresupuesto(SqlConnection connection, SqlTransaction trans)
        {
            try
            {

                SqlCommand command = new SqlCommand("Presupuesto_Actualizar", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Apellido", Apellido);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Total", Total);
                command.Parameters.AddWithValue("@Recargo", Recargo);
                command.Parameters.AddWithValue("@Tipo", Tipo);
                command.Parameters.AddWithValue("@IdVehiculo", IdVehiculo);

                command.Transaction = trans;
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion 

    }
}
