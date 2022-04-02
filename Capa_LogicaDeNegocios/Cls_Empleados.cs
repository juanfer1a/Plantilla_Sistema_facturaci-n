using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    class Cls_Empleados
    {
        public int C_IdEmpleado { get; set; }
        public string C_StrNombre { get; set; }
        public double C_NumDocumento { get; set; }
        public string C_StrDireccion { get; set; }
        public string C_StrTelefono { get; set; }
        public string C_StrEmail { get; set; }
        public int C_IdRolEmpleado { get; set; }
        public string C_DtmIngreso { get; set; }
        public string C_DtmRetiro { get; set; }
        public string C_StrDatosAdicionales { get; set; }
        public string C_StrUsuarioModifico { get; set; }

        Cls_Acceso_Datos Acceso_Datos = new Cls_Acceso_Datos();

        public DataTable ConsultaEmpleado()
        {
            string sentencia="";

            try
            {
                sentencia = "Select * from TBLEMPLEADO";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public DataTable ConsultaEmpleado(string IdEmpleado)
        {
            string sentencia="";

            try
            {
                sentencia = $"Select * from TBLEMPLEADO where IdEmpleado={IdEmpleado}";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public DataTable Filtrar_Empleado(string filtro)
        {
            string sentencia = "";

            try
            {
                sentencia = $"Select * from TBLEMPLEADO where strnombre like '%{filtro}%'";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        public DataTable ConsultarRol()
        {
            string sentencia = "";

            try
            {
                sentencia = "Select * from TBLROLES";
                DataTable dt = new DataTable();
                dt = Acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public string EliminarEmpleado()
        {
            string mensaje = "";

            try
            {
                List<Cls_parametros> lts = new List<Cls_parametros>();

                lts.Add(new Cls_parametros("@IdEmpleado",C_IdEmpleado));

                mensaje = Acceso_Datos.Ejecutar_procedimiento("eliminar_Empleado",lts);
            }
            catch (Exception ex)
            {
                mensaje = "FALLO BORRADO EN EMPLEADO" +ex;
            }
            return mensaje;
        }

        public string ActualizarEmpleado()
        {
            string mensaje = "";

            try
            {
                List<Cls_parametros> lts = new List<Cls_parametros>();

                lts.Add(new Cls_parametros("@IdEmpleado", C_IdEmpleado));
                lts.Add(new Cls_parametros("@IdEmpleado", C_StrNombre));
                lts.Add(new Cls_parametros("@IdEmpleado", C_NumDocumento));
                lts.Add(new Cls_parametros("@IdEmpleado", C_StrDireccion ));
                lts.Add(new Cls_parametros("@IdEmpleado", C_StrTelefono));
                lts.Add(new Cls_parametros("@IdEmpleado", C_StrEmail ));
                lts.Add(new Cls_parametros("@IdEmpleado", C_IdRolEmpleado));
                lts.Add(new Cls_parametros("@IdEmpleado", C_DtmIngreso));
                lts.Add(new Cls_parametros("@IdEmpleado", C_DtmRetiro));
                lts.Add(new Cls_parametros("@IdEmpleado", C_StrDatosAdicionales));
                lts.Add(new Cls_parametros("@IdEmpleado", DateTime.Now));
                lts.Add(new Cls_parametros("@IdEmpleado", C_StrUsuarioModifico));

                mensaje = Acceso_Datos.Ejecutar_procedimiento("eliminar_Empleado", lts);
            }
            catch (Exception ex)
            {
                mensaje = "FALLO BORRADO EN EMPLEADO" + ex;
            }
            return mensaje;
        }
    }
}
