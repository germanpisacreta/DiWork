using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DiWork.Modelos.Clases;
using DiWork.Utilitarios;
using Newtonsoft.Json;

namespace DiWork.Persistencia
{
    public class DatosDesperfectoRepuesto :DesperfectoRepuesto
    {
        #region PROPIEDADES
        private readonly string connectionString = Conexion.ObtenerConnectionString();
        public long Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        #endregion  


        #region OBTENER 
        public string ObtenerDesperfectoRepuesto()
        {
            try
            {
                DataTable dataTable = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("ObtenerDesperfectoRepuesto", connection);
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

        #region INSERT
        public void InsertarDesperfectoRepuesto(SqlConnection connection, SqlTransaction trans)
        {
            try
            {
                
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.InsertCommand = new SqlCommand("DesperfectoRepuesto_Insertar", connection);
                    dataAdapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                    dataAdapter.InsertCommand.Transaction = trans;
                    dataAdapter.InsertCommand.Parameters.AddWithValue("@IdRepuesto", IdRepuesto);
                    dataAdapter.InsertCommand.Parameters.AddWithValue("@IdDesperfecto", IdDesperfecto);

                    DataTable dataTable = new DataTable();
                    dataTable.TableName = "DesperfectoRepuesto";
                    dataTable.Rows.Add(dataTable.NewRow());

                    dataAdapter.Update(dataTable);
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region BORRAR
        public void BorrarDesperfectoRepuesto()
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("DesperfectoRepuesto_Borrar", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@IdRepuesto", IdRepuesto);
                    command.Parameters.AddWithValue("@IdDesperfecto", IdDesperfecto);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
