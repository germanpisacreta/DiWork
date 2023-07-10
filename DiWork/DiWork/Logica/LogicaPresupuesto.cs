using DiWork.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using DiWork.Modelos.Enumerados;
using System.Data.SqlClient;

namespace DiWork.Logica
{
    public class LogicaPresupuesto : DatosPresupuesto
    {
        #region PROPIEDADES
        public LogicaAutomovil objAutomovil;
        public LogicaMoto objMoto;
        public List<LogicaDesperfecto> lstDesperfecto { get; set; } = new List<LogicaDesperfecto>();
        const int estacionamiento = 130;
        #endregion

        


        #region VALIDAR
        public string Validar()
        {
            string mensaje = null;
            try
            {
                if (string.IsNullOrEmpty(Nombre))
                    mensaje += "El nombre del cliente no puede estar vacio \n";

                if (string.IsNullOrEmpty(Apellido))
                    mensaje += "El Apellido del cliente no puede estar vacio \n";

                if (string.IsNullOrEmpty(Email))
                    mensaje += "El Mail del cliente no puede estar vacio \n";

                if(!ComprobarFormatoEmail(Email))
                    mensaje += "El formato de mail es incorrecto \n";

                if (objAutomovil != null)
                {
                    if (string.IsNullOrEmpty(objAutomovil.Marca))
                        mensaje += "El marca no puede estar vacio \n";

                    if (string.IsNullOrEmpty(objAutomovil.Modelo))
                        mensaje += "El modelo no puede estar vacio \n";

                    if (string.IsNullOrEmpty(objAutomovil.Patente))
                        mensaje += "La pantente no puede estar vacio \n";

                    if (objAutomovil.CantidadPuertas == 0)
                        mensaje += "La pantente no puede ser cero \n";
                }
                else if(objMoto != null)
                {
                    if (string.IsNullOrEmpty(objMoto.Marca))
                        mensaje += "El marca no puede estar vacio \n";

                    if (string.IsNullOrEmpty(objMoto.Modelo))
                        mensaje += "El modelo no puede estar vacio \n";

                    if (string.IsNullOrEmpty(objMoto.Patente))
                        mensaje += "La pantente no puede estar vacio \n";

                    if (string.IsNullOrEmpty(objMoto.Cilindrado))
                        mensaje += "La cilindrada no puede estar vacia \n";

                }
             
                return mensaje;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool ComprobarFormatoEmail(string sEmailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(sEmailAComprobar, sFormato))
            {
                if (Regex.Replace(sEmailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region GRABAR
        public void GrabarPresupuesto()
        {
            Conexiones objConexiones = new Conexiones();
            SqlConnection conn = objConexiones.AbrirConnection(this.connectionString);
            SqlTransaction trans = objConexiones.AbrirTransactionCommited(conn);
            long IdVehiculo = 0;
            decimal Ganancia = 0;
            try
            {
                if (objAutomovil != null)
                {
                    if (objAutomovil.Id == 0)
                        objAutomovil.InsertarAutomovil(conn,trans);
                    else
                        objAutomovil.ActualizarAutomovil(conn, trans);

                    IdVehiculo = objAutomovil.IdVehiculo;
                }
                else if (objMoto != null)
                {
                    if (objMoto.Id == 0)
                        objMoto.InsertarMoto(conn, trans);
                    else
                        objMoto.ActualizarMoto(conn, trans);

                    IdVehiculo = objMoto.IdVehiculo;
                }

                this.IdVehiculo = IdVehiculo;
                Ganancia = (130 * lstDesperfecto.Sum(x => x.Tiempo) + this.Total + lstDesperfecto.Sum(x => x.ManoDeObra)) * 10 / 100;
                this.Total = 130 * lstDesperfecto.Sum(x => x.Tiempo) +lstDesperfecto.Sum(x => x.ManoDeObra) + this.Total + Ganancia;
                if (this.Id == 0)
                    this.InsertarPresupuesto(conn, trans);
                else
                    this.ActualizarPresupuesto(conn, trans);

                foreach (LogicaDesperfecto item in lstDesperfecto)
                {
                    item.IdPresupuesto = this.Id;
                    if (item.Id == 0)
                        item.InsertarDesperfecto(conn, trans);
                    else
                        item.ActualizarDesperfecto(conn, trans);

                    foreach (var itemRepuesto in item.lstRepuestoElimnar)
                    {
                        LogicaDesperfectoRepuesto objDatosDesperfectoRepuesto = new LogicaDesperfectoRepuesto();
                        objDatosDesperfectoRepuesto.IdDesperfecto = item.Id;
                        objDatosDesperfectoRepuesto.IdRepuesto = itemRepuesto.Id;
                        objDatosDesperfectoRepuesto.BorrarDesperfectoRepuesto();
                    }


                    foreach (var itemRepuesto in item.lstRepuesto)
                    {
                        LogicaDesperfectoRepuesto objDatosDesperfectoRepuesto = new LogicaDesperfectoRepuesto();
                        objDatosDesperfectoRepuesto.IdDesperfecto = item.Id;
                        objDatosDesperfectoRepuesto.IdRepuesto = itemRepuesto.Id;
                        objDatosDesperfectoRepuesto.InsertarDesperfectoRepuesto(conn, trans);
                    }

                }
                trans.Commit();
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                    conn = null;
                }
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw new Exception(ex.Message);
            }
        }
        #endregion



        #region OBTENER
        public new List<LogicaPresupuesto> ObtenerPresupuesto()
        {
            try
            {
                List<LogicaPresupuesto> presupuestos = JsonConvert.DeserializeObject<List<LogicaPresupuesto>>(base.ObtenerPresupuesto());
                presupuestos = new List<LogicaPresupuesto>(presupuestos.OrderBy(item => item.Nombre).OrderBy(x => x.Apellido).ToList());
                

                return presupuestos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        #endregion

        #region PROMEDIO
        public new List<LogicaPresupuesto> ObtenerPromedio()
        {
            try
            {
                List<LogicaPresupuesto> presupuestos = JsonConvert.DeserializeObject<List<LogicaPresupuesto>>(base.ObtenerPromedio());
                return presupuestos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion

        #region SUMATORIA
        public new List<LogicaPresupuesto> ObtenerSumatoria()
        {
            try
            {
                List<LogicaPresupuesto> presupuestos = JsonConvert.DeserializeObject<List<LogicaPresupuesto>>(base.ObtenerSumatoria());
                return presupuestos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion

        #region OBTENER POR ID
        public new LogicaPresupuesto ObtenerPresupuestoID(int Id)
        {
            try
            {
                LogicaPresupuesto objLogicaPresupuesto = JsonConvert.DeserializeObject<LogicaPresupuesto>(base.ObtenerPresupuestoID(Id));
                LogicaDesperfecto objLogicaDesperfecto = new LogicaDesperfecto();
                LogicaDesperfectoRepuesto objLogicaDesperfectoRepuesto = new LogicaDesperfectoRepuesto();
                List<LogicaDesperfectoRepuesto> listaLogicaDesperfectoRepuesto = new List<LogicaDesperfectoRepuesto>();
                listaLogicaDesperfectoRepuesto = objLogicaDesperfectoRepuesto.ObtenerDesperfectoRepuesto();
                objLogicaPresupuesto.lstDesperfecto = objLogicaDesperfecto.ObtenerDesperfectoPorId(objLogicaPresupuesto.Id);
                foreach (var item in objLogicaPresupuesto.lstDesperfecto)
                {
                    foreach (var DesperfectoRepuesto in listaLogicaDesperfectoRepuesto.Where(x => x.IdDesperfecto == item.Id).ToList())
                    {
                        LogicaRepuesto logicaRepuesto = new LogicaRepuesto();
                        logicaRepuesto.Id = DesperfectoRepuesto.IdRepuesto;
                        logicaRepuesto.Nombre = DesperfectoRepuesto.Nombre;
                        logicaRepuesto.Precio = DesperfectoRepuesto.Precio;
                        item.lstRepuesto.Add(logicaRepuesto);
                    }
                    item.CantidadProductos = item.lstRepuesto.Count();
                    item.PrecioDesperfecto = item.lstRepuesto.Sum(x => x.Precio);
                }

                if (objLogicaPresupuesto.Tipo == (int)eVehiculo.Automovil)
                {
                    objLogicaPresupuesto.objAutomovil = new LogicaAutomovil();
                    objLogicaPresupuesto.objAutomovil = objLogicaPresupuesto.objAutomovil.ObtenerAutomovilPorId(objLogicaPresupuesto.IdVehiculo);
                }
                else
                {
                    objLogicaPresupuesto.objMoto = new LogicaMoto();
                    objLogicaPresupuesto.objMoto = objLogicaPresupuesto.objMoto.ObtenerMotoPorId(objLogicaPresupuesto.IdVehiculo);
                }

                return objLogicaPresupuesto;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion
    }
}
