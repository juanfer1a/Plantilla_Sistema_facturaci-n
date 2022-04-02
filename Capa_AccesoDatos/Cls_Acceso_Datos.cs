using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Capa_AccesoDatos
{
    
    public class Cls_parametros { 
        
        public string Nombre { get; set; }
        public object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public Int32 Tamano { get; set; }
        public ParameterDirection DirectionParametro { get; set; }

        //Constructor parametros de entrada
        public Cls_parametros(string Objnombre, Object ObjValor)
        {
            Nombre = Objnombre;
            Valor = ObjValor;
            DirectionParametro = ParameterDirection.Input;
        }

        //Constructor parametros de salida
        public Cls_parametros(string Objnombre, SqlDbType ObjTipoDato, Int32 ObjTamano )
        {
            Nombre = Objnombre;
            TipoDato = ObjTipoDato;
            Tamano = ObjTamano; 
            DirectionParametro = ParameterDirection.Output;
        }


    }

    public class Cls_Acceso_Datos
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader lectorDatos = null;
        SqlDataAdapter da;
        DataTable dt;

        public string AbrirBd()
        {
            string resultado = "";
            try
            {
                conexion = new SqlConnection("Data Source=.;Initial Catalog=DBFACTURAS;Integrated Security=True");
                conexion.Open();
            }
            catch (Exception)
            {

                resultado = "Error abrir";
            }
            return resultado;
        }

        public string CerrarBd()
        {
            string resultado = "";
            try
            {
                conexion.Close();
            }
            catch (Exception)
            {

                resultado = "Error cerrar ";
            }
            return resultado;
        }

        public string Ejecutar_procedimiento(string procedimiento, List<Cls_parametros> lst)
        {
            string salida = "";
            try
            {
                int retornado;
                AbrirBd();
                SqlCommand command = new SqlCommand(procedimiento,conexion);
                command.CommandType = CommandType.StoredProcedure;

                if (lst !=null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].DirectionParametro == ParameterDirection.Input)
                        {
                            command.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        }

                        if (lst[i].DirectionParametro == ParameterDirection.Output)
                        {
                            command.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamano).Direction = ParameterDirection.Output;
                        }
                    }
                }

                retornado = command.ExecuteNonQuery();
                CerrarBd();

                if (retornado > 0)
                {
                    salida = "Los datos fueron actualizados";
                }
                else
                {
                    salida = "Los datos no fueron actualizados";
                }

            }
            catch (Exception ex)
            {
                salida = "Error, fallo en la operación"+ex;
                
            }
            return salida;
            
                
        }

        public string EjecutarComando(string sentencia)
        {
            string salida = "";
            try
            {
                int retornado;
                AbrirBd();
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery();
                CerrarBd();

                if (retornado > 0)
                {
                    salida = "Los datos fueron actualizados";
                }
                else
                {
                    salida = "Los datos no fueron actualizados";
                }
            }
            catch (Exception ex)
            {
                salida = "Error, fallo en la operación" + ex;

            }
            return salida;
        }

        public DataTable EjecutarConsulta(string cmd)
        {
            try
            {
                AbrirBd();
                da = new SqlDataAdapter(cmd, conexion);
                dt = new DataTable();
                da.Fill(dt);
                CerrarBd();
                return dt;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }


}
