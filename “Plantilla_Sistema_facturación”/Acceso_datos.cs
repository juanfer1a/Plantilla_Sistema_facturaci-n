using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _Plantilla_Sistema_facturación_
{
    internal class Acceso_datos
    {
        string ConexionSting = ConfigurationManager.ConnectionStrings["Plantilla_Sistema_facturación.Properties.Settings.andresmu.DBFACTURAS.dbo"].ToString();
        //varaible para la conección
        SqlConnection connection;
        //variable para el comando
        SqlCommand command;
               
        //R
        #region conexión
        private void conectar()
        {
            try
            {
                connection = new SqlConnection(ConexionSting);
                //Abrimos la conexión
                connection.Open();
                //MessageBox.Show("Bien");
            }
            catch (SqlException)
            {
                MessageBox.Show("Error al conectar ");

            }

        }
        #endregion
        public bool login(string Usuario, string Contra)
        {
            conectar();
            try
            {
                
                //Utilizamos Sp
                command = new SqlCommand();
                //Tipo de proceso
                command.CommandType = CommandType.StoredProcedure;
                //Ponemos el Query
                command.CommandText = "SPLogin";
                //Asignamos los datos
                command.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usuario.Trim();
                command.Parameters.Add("@Clave", SqlDbType.VarChar).Value = Contra.Trim();

                //Hacemos la conexión
                command.Connection = connection;
                //Ejecutamos el Query
                SqlDataReader reader = command.ExecuteReader();

                //Si existe alguna linea retorna true
                if (reader.HasRows)
                {
                    
                    connection.Close();
                    return true;

                }
                else
                {
                    connection.Close();
                    
                    return false;

                }

            }
            catch (Exception)
            {
                connection.Close();
                return false;

            }

        }

        public void llenarTablas(DataGridView dataGrid, string tabla)
        {
            conectar();
            try
            {
                //---------------------OTRA FORMA DE HACERLO

                command = new SqlCommand("Select * from "+tabla+"", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGrid.DataSource = dt;

                connection.Close();

            }
            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("Error al llenar la tabla ");

            }

        }

        public void buscarYLlenarTablas(DataGridView dataGrid, string tabla, string campo, string busqueda)
        {
            conectar();
            try
            {
                //---------------------OTRA FORMA DE HACERLO

                command = new SqlCommand("Select * from " + tabla + " where "+campo+" like '%"+busqueda+"%' ", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                dataGrid.DataSource = dt;

                connection.Close();

            }
            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("Error al llenar la tabla");

            }

        }
        
        public void eliminarDeCualquierLista(int identificador, string procedure, string variableSQL)
        {
            conectar();
            try
            {
                //Utilizamos Sp
                command = new SqlCommand(procedure, connection);
                //Tipo de proceso
                command.CommandType = CommandType.StoredProcedure;

                //Asignamos los datos
                command.Parameters.Add(variableSQL, SqlDbType.Int).Value = identificador;

                //Ejecutamos el Query
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Eliminación realizada");
            }
            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("Error al eliminar");
            }

        }


        public void actualizarCliente(int identificador,string nombre,string Direccion,int telefono,string email)
        {
            conectar();
            try
            {
                //Utilizamos Sp
                command = new SqlCommand("Eliminar_Cliente", connection);
                //Tipo de proceso
                command.CommandType = CommandType.StoredProcedure;

                //Asignamos los datos
                command.Parameters.Add("@IdCliente", SqlDbType.Int).Value = identificador;

                //Ejecutamos el Query
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Eliminación realizada");
            }
            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("Error al eliminar el cliente");
            }

        }

        //public void eliminarProducto(int identificador)
        //{
        //    conectar();
        //    try
        //    {
        //        //Utilizamos Sp
        //        command = new SqlCommand("Eliminar_Producto", connection);
        //        //Tipo de proceso
        //        command.CommandType = CommandType.StoredProcedure;

        //        //Asignamos los datos
        //        command.Parameters.Add("@IdProducto", SqlDbType.Int).Value = identificador;

        //        //Ejecutamos el Query
        //        command.ExecuteNonQuery();

        //        connection.Close();
        //        MessageBox.Show("Eliminación realizada");
        //    }
        //    catch (Exception)
        //    {
        //        connection.Close();
        //        MessageBox.Show("Error al eliminar el producto");
        //    }


        //}

        //public void eliminarCategoria(int identificador)
        //{
        //    conectar();
        //    try
        //    {
        //        //Utilizamos Sp
        //        command = new SqlCommand("Eliminar_CategoriaProducto", connection);
        //        //Tipo de proceso
        //        command.CommandType = CommandType.StoredProcedure;

        //        //Asignamos los datos
        //        command.Parameters.Add("@IdCategoria ", SqlDbType.Int).Value = identificador;

        //        //Ejecutamos el Query
        //        command.ExecuteNonQuery();

        //        connection.Close();
        //        MessageBox.Show("Eliminación realizada");
        //    }
        //    catch (Exception)
        //    {
        //        connection.Close();
        //        MessageBox.Show("Error al eliminar la categoría");
        //    }


        //}

        //public void eliminarFactura(int identificador)
        //{
        //    conectar();
        //    try
        //    {
        //        //Utilizamos Sp
        //        command = new SqlCommand("Eliminar_Factura", connection);
        //        //Tipo de proceso
        //        command.CommandType = CommandType.StoredProcedure;

        //        //Asignamos los datos
        //        command.Parameters.Add("@IdFactura", SqlDbType.Int).Value = identificador;

        //        //Ejecutamos el Query
        //        command.ExecuteNonQuery();

        //        connection.Close();
        //        MessageBox.Show("Eliminación realizada");
        //    }
        //    catch (Exception)
        //    {
        //        connection.Close();
        //        MessageBox.Show("Error al eliminar la categoría");
        //    }


        //}

        //public void eliminarEmpleado(int identificador)
        //{
        //    conectar();
        //    try
        //    {
        //        //Utilizamos Sp
        //        command = new SqlCommand("Eliminar_Empleado", connection);
        //        //Tipo de proceso
        //        command.CommandType = CommandType.StoredProcedure;

        //        //Asignamos los datos
        //        command.Parameters.Add("@IdFactura", SqlDbType.Int).Value = identificador;

        //        //Ejecutamos el Query
        //        command.ExecuteNonQuery();

        //        connection.Close();
        //        MessageBox.Show("Eliminación realizada");
        //    }
        //    catch (Exception)
        //    {
        //        connection.Close();
        //        MessageBox.Show("Error al eliminar la categoría");
        //    }


        //}
    }
}
