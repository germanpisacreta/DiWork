using System;
using System.Data;
using System.Data.SqlClient;
using DiWork.Modelos.Clases;
using DiWork.Utilitarios;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DiWork.Persistencia
{
    public class DatosDesperfecto : Desperfecto
    {
        #region PROPIEDADES
        private readonly string connectionString = Conexion.ObtenerConnectionString();
        #endregion


        #region OBTENER POR ID
        public string ObtenerDesperfectoPorId(long idPresupuesto)
        {
            try
            {
                DataTable dataTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("ObtenerDesperfectoPorId", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idPresupuesto", idPresupuesto);
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

        #region INSERTAR
        public void InsertarDesperfecto(SqlConnection connection, SqlTransaction trans)
        {
            try
            {
               
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    using (SqlCommand command = new SqlCommand("Desperfecto_Insertar"))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Connection = connection;
                        command.Parameters.AddWithValue("@IdPresupuesto", IdPresupuesto);
                        command.Parameters.AddWithValue("@Descripcion", Descripcion);
                        command.Parameters.AddWithValue("@ManoDeObra", ManoDeObra);
                        command.Parameters.AddWithValue("@Tiempo", Tiempo);
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
        public void ActualizarDesperfecto(SqlConnection connection, SqlTransaction trans)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                    SqlCommand command = new SqlCommand("Desperfecto_Actualizar", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@IdPresupuesto", IdPresupuesto);
                    command.Parameters.AddWithValue("@Descripcion", Descripcion);
                    command.Parameters.AddWithValue("@ManoDeObra", ManoDeObra);
                    command.Parameters.AddWithValue("@Tiempo", Tiempo);
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
