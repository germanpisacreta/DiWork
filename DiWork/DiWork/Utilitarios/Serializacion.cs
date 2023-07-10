using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiWork.Utilitarios
{
    public class MiObjeto
    {
        public List<Dictionary<string, object>> Datos { get; set; }
    }

    public static class Serializacion
    {
        public static string SerializarDataTable(DataRowCollection datarow)
        {
            List<Dictionary<string, object>> listaDatos = new List<Dictionary<string, object>>();

            foreach (DataRow row in datarow)
            {
                Dictionary<string, object> data = new Dictionary<string, object>();

                foreach (DataColumn column in row.Table.Columns)
                {
                    data.Add(column.ColumnName, row[column]);
                }

                listaDatos.Add(data);
            }

            string json = JsonConvert.SerializeObject(listaDatos);

            return json;
        }

        public static string SerializarDataRow(DataRow datarow)
        {
            List<Dictionary<string, object>> listaDatos = new List<Dictionary<string, object>>();

            
            Dictionary<string, object> data = new Dictionary<string, object>();

            foreach (DataColumn column in datarow.Table.Columns)
            {
                data.Add(column.ColumnName, datarow[column]);
            }

            listaDatos.Add(data);
            
            string json = JsonConvert.SerializeObject(listaDatos.FirstOrDefault());

            return json;
        }

    }
}
