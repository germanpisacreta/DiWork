using System;
using System.Data;
using System.Data.SqlClient;
using DiWork.Modelos.Clases;
using System.Collections.Generic;
using Newtonsoft.Json;
using DiWork.Utilitarios;

namespace DiWork.Persistencia
{
    public class DatosAutomovil : Automovil
    {
        #region OBTENER POR ID
        public string ObtenerAutomovilPorId(long idVehiculo)
        {
            try
            {

                DataTable dataTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("ObtenerAutomovilPorIdVehiculo", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idVehiculo", idVehiculo);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                    // Abrir la conexión y llenar el DataTable
                    connection.Open();
                    dataAdapter.Fill(dataTable);
                }
                if (dataTable.Rows.Count > 0)
                    return Serializacion.SerializarDataRow(dataTable.Rows[0]);
                else
                    return null;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region INSERTAR
        public void InsertarAutomovil(SqlConnection connection, SqlTransaction trans)
        {
            try
            {
                    if(connection.State != ConnectionState.Open)
                        connection.Open();

                    using (SqlCommand command = new SqlCommand("Automovil_Insertar"))
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Marca", Marca);
                        command.Parameters.AddWithValue("@Modelo", Modelo);
                        command.Parameters.AddWithValue("@Patente", Patente);
                        command.Parameters.AddWithValue("@Tipo", Tipo);
                        command.Parameters.AddWithValue("@CantidadPuertas", CantidadPuertas);
                        command.Transaction = trans;
                        IdVehiculo = Convert.ToInt32(command.ExecuteScalar());
                    }
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region ACTUALIZAR
        public void ActualizarAutomovil(SqlConnection connection, SqlTransaction trans)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                    SqlCommand command = new SqlCommand("Automovil_Actualizar", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@IdVehiculo", IdVehiculo);
                    command.Parameters.AddWithValue("@Marca", Marca);
                    command.Parameters.AddWithValue("@Modelo", Modelo);
                    command.Parameters.AddWithValue("@Patente", Patente);
                    command.Parameters.AddWithValue("@Tipo", Tipo);
                    command.Parameters.AddWithValue("@CantidadPuertas", CantidadPuertas);
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
