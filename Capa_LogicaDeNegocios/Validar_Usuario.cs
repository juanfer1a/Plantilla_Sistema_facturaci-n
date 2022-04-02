using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_LogicaDeNegocios
{
    public class Validar_usuario
    {
        public string C_StrUsuario { get; set; }
        public string C_StrClave { get; set; }
        public Int32 C_IdEmpleado { get; set; }
        public void ValidarUsuario()
        {
            try
            {
                string sentencia = $"SELECT IdEmpleado FROM TBLSEGURIDAD WHERE StrUsuario='{C_StrUsuario}' AND StrClave='{C_StrClave}'";
                DataTable dt = new DataTable();
                Cls_Acceso_Datos Acceso = new Cls_Acceso_Datos();
                dt = Acceso.EjecutarConsulta(sentencia);

                foreach (DataRow row in dt.Rows)
                {
                    //Mirar
                    C_IdEmpleado = int.Parse(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la consulta"+ex);
            }
        }

    }
}
