using System;
using System.Data;
using System.Data.SqlClient;
using DiWork.Modelos.Clases;
using DiWork.Utilitarios;
using Newtonsoft.Json;

namespace DiWork.Persistencia
{
    public class DatosMoto : Moto
    {

        #region OBTENER POR ID
        public string ObtenerMotoPorId(long idVehiculo)
        {
            try
            {
                DataTable dataTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("ObtenerMotoPorIdVehiculo", connection);
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

        #region INSERT
        public void InsertarMoto(SqlConnection connection, SqlTransaction trans)
        {
            try
            {
                
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    using (SqlCommand command = new SqlCommand("Moto_Insertar"))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Connection = connection;
                        command.Parameters.AddWithValue("@Marca", Marca);
                        command.Parameters.AddWithValue("@Modelo", Modelo);
                        command.Parameters.AddWithValue("@Patente", Patente);
                        command.Parameters.AddWithValue("@Cilindrado", Cilindrado);
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
        public void ActualizarMoto(SqlConnection connection, SqlTransaction trans)
        {
            try
            {


                SqlCommand command = new SqlCommand("Moto_Actualizar", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@IdVehiculo", IdVehiculo);
                command.Parameters.AddWithValue("@Marca", Marca);
                command.Parameters.AddWithValue("@Modelo", Modelo);
                command.Parameters.AddWithValue("@Patente", Patente);
                command.Parameters.AddWithValue("@Cilindrado", Cilindrado);
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
