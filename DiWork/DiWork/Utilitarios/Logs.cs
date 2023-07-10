using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiWork.Utilitarios
{
    public static class Logs
    {
        public static void GuardarArchivoTxt(string contenido)
        {
            // Obtener la ruta de la carpeta donde se compila el proyecto
            string rutaProyecto = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // Combinar la ruta de la carpeta con el nombre del archivo
            string rutaArchivo = Path.Combine(rutaProyecto, "Logs.txt");

            // Verificar si el archivo ya existe
            if (File.Exists(rutaArchivo))
            {
                // Agregar la información nueva al archivo existente
                File.AppendAllText(rutaArchivo, DateTime.Now.ToShortDateString() + " - " + contenido);
            }
            else
            {
                // Crear un nuevo archivo y escribir el contenido
                File.WriteAllText(rutaArchivo, contenido);
            }

            MessageBox.Show("Ocurrio un problema comuniquese con el administrador");
        }
    }
}
