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

        //Guardamos el Usuario que realizo el login
        public static string UsuarioActivo;
               
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
                    while (reader.Read())
                    {
                        UsuarioActivo = reader.GetString(1);

                    }
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

                command = new SqlCommand("Select * from " + tabla + "", connection);

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

                command = new SqlCommand("Select * from " + tabla + " where " + campo + " like '%" + busqueda + "%' ", connection);

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

        public void actualizarCliente(string identificador, string nombre, string documento, string direccion, string telefono, string email)
        {

            conectar();
            try
            {
                DateTime fecha = DateTime.Now.Date;
                //Utilizamos Sp
                command = new SqlCommand("actualizar_Cliente", connection);
                //Tipo de proceso
                command.CommandType = CommandType.StoredProcedure;

                //Asignamos los datos
                command.Parameters.Add("@IdCliente", SqlDbType.Int).Value = int.Parse(identificador);
                command.Parameters.Add("@StrNombre", SqlDbType.VarChar).Value = nombre;
                command.Parameters.Add("@NumDocumento", SqlDbType.Int).Value = int.Parse(documento);
                command.Parameters.Add("@StrDireccion", SqlDbType.VarChar).Value = direccion;
                command.Parameters.Add("@StrTelefono", SqlDbType.VarChar).Value = telefono;
                command.Parameters.Add("@StrEmail", SqlDbType.VarChar).Value = email;
                command.Parameters.Add("@StrUsuarioModifica", SqlDbType.VarChar).Value = UsuarioActivo;
                command.Parameters.Add("@DtmFechaModifica", SqlDbType.DateTime).Value = fecha;

                //Ejecutamos el Query
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Actualización Exitosa");
            }
            catch (Exception ec)
            {
                connection.Close();
                MessageBox.Show("Error al actualizar el cliente ");
            }

        }

        public void actualizarProductos(string identificador, string nombre, string referencia, string precioCompra, string precioVenta,
            string idcategoria, string cantidad, string detalle, string foto)
        {

            conectar();
            try
            {
                DateTime fecha = DateTime.Now.Date;
                //Utilizamos Sp
                command = new SqlCommand("actualizar_Producto", connection);
                //Tipo de proceso
                command.CommandType = CommandType.StoredProcedure;

                //Asignamos los datos
                command.Parameters.Add("@IdProducto", SqlDbType.Int).Value = int.Parse(identificador);
                command.Parameters.Add("@StrNombre", SqlDbType.VarChar).Value = nombre;
                command.Parameters.Add("@StrCodigo", SqlDbType.VarChar).Value = referencia;
                command.Parameters.Add("@NumPrecioCompra", SqlDbType.Float).Value = float.Parse(precioCompra);
                command.Parameters.Add("@NumPrecioVenta", SqlDbType.Float).Value = float.Parse(precioVenta);
                command.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = int.Parse(idcategoria);
                command.Parameters.Add("@StrDetalle", SqlDbType.VarChar).Value = detalle;
                command.Parameters.Add("@strFoto", SqlDbType.VarChar).Value = foto;
                command.Parameters.Add("@NumStock", SqlDbType.Int).Value = int.Parse(cantidad);
                command.Parameters.Add("@StrUsuarioModifica", SqlDbType.VarChar).Value = UsuarioActivo;
                command.Parameters.Add("@DtmFechaModifica", SqlDbType.DateTime).Value = fecha;

                //Ejecutamos el Query
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Actualización Exitosa");
            }
            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("Error al actualizar el producto");
            }

        }

        public void llenarComboBoxCategoria(ComboBox box)
        {
            conectar();
            try
            {
                //---------------------OTRA FORMA DE HACERLO

                command = new SqlCommand("Select * from TBLCATEGORIA_PROD", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                //Almacenamos dt
                box.DataSource = dt;

                //Mostamos los datos de la tabla que contiene esta nombre
                box.DisplayMember = "StrDescripcion";

                //Asignamos los datos de la tabla que contiene esta nombre
                box.ValueMember = "IdCategoria";

                connection.Close();

            }
            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("Error al cargar los proveedores a los combo");

            }
        }

        public void actualizarCategoria(string identificador, string descripcion)
        {

            conectar();
            try
            {
                DateTime fecha = DateTime.Now.Date;
                //Utilizamos Sp
                command = new SqlCommand("actualizar_CategoriaProd", connection);
                //Tipo de proceso
                command.CommandType = CommandType.StoredProcedure;

                //Asignamos los datos
                command.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = int.Parse(identificador);
                command.Parameters.Add("@StrDescripcion", SqlDbType.VarChar).Value = descripcion;
                command.Parameters.Add("@StrUsuarioModifico", SqlDbType.VarChar).Value = UsuarioActivo;
                command.Parameters.Add("@DtmFechaModifica", SqlDbType.DateTime).Value = fecha;

                //Ejecutamos el Query
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Actualización Exitosa");
            }
            catch (Exception ec)
            {
                connection.Close();
                MessageBox.Show("Error al actualizar la categoria" + ec);
            }

        }

        public void llenarComboCliente(ComboBox box)
        {
            conectar();
            try
            {
                //---------------------OTRA FORMA DE HACERLO

                command = new SqlCommand("Select * from TBLCLIENTES", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                //Almacenamos dt
                box.DataSource = dt;

                //Mostamos los datos de la tabla que contiene esta nombre
                box.DisplayMember = "StrNombre";

                //Asignamos los datos de la tabla que contiene esta nombre
                box.ValueMember = "IdCliente";

                connection.Close();

            }
            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("Error al cargar los proveedores a los combo");

            }
        }

        public void llenarComboEmpleado(ComboBox box)
        {
            conectar();
            try
            {
                //---------------------OTRA FORMA DE HACERLO

                command = new SqlCommand("Select * from TBLEMPLEADO", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                //Almacenamos dt
                box.DataSource = dt;

                //Mostamos los datos de la tabla que contiene esta nombre
                box.DisplayMember = "StrNombre";

                //Asignamos los datos de la tabla que contiene esta nombre
                box.ValueMember = "IdEmpleado";

                connection.Close();

            }
            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("Error al cargar los proveedores a los combo");

            }
        }

        public void llenarComboEstadoFactura(ComboBox box)
        {
            conectar();
            try
            {
                //---------------------OTRA FORMA DE HACERLO

                command = new SqlCommand("Select * from TBLESTADO_FACTURA", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                //Almacenamos dt
                box.DataSource = dt;

                //Mostamos los datos de la tabla que contiene esta nombre
                box.DisplayMember = "StrDescripcion";

                //Asignamos los datos de la tabla que contiene esta nombre
                box.ValueMember = "IdEstadoFactura";

                connection.Close();

            }
            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("Error al cargar los proveedores a los combo");

            }
        }

        public void actualizarFactura(string identificador, string fecha2, string cliente, string empleado, string descuento, string impuesto,
            string valorTotal, string estado)
        {

            conectar();
            try
            {
                DateTime fecha = DateTime.Now.Date;
                //Utilizamos Sp
                command = new SqlCommand("actualizar_Factura", connection);
                //Tipo de proceso
                command.CommandType = CommandType.StoredProcedure;

                //Asignamos los datos
                command.Parameters.Add("@IdFactura", SqlDbType.Int).Value = int.Parse(identificador);
                command.Parameters.Add("@DtmFecha", SqlDbType.DateTime).Value = fecha2;
                command.Parameters.Add("@IdCliente", SqlDbType.Int).Value = cliente;
                command.Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = int.Parse(empleado);
                command.Parameters.Add("@NumDescuento", SqlDbType.Float).Value = float.Parse(descuento);
                command.Parameters.Add("@NumImpuesto", SqlDbType.Float).Value = float.Parse(impuesto);
                command.Parameters.Add("@NumValorTotal", SqlDbType.Float).Value = valorTotal;
                command.Parameters.Add("@IdEstado", SqlDbType.Int).Value = int.Parse(estado);
                command.Parameters.Add("@StrUsuarioModifica", SqlDbType.VarChar).Value = UsuarioActivo;
                command.Parameters.Add("@DtmFechaModifica", SqlDbType.DateTime).Value = fecha;

                //Ejecutamos el Query
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Actualización Exitosa");
            }
            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("Error al actualizar el producto");
            }

        }

        public void llenarComboRol(ComboBox box)
        {
            conectar();
            try
            {
                //---------------------OTRA FORMA DE HACERLO

                command = new SqlCommand(" Select * from TBLROLES", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                //Almacenamos dt
                box.DataSource = dt;

                //Mostamos los datos de la tabla que contiene esta nombre
                box.DisplayMember = "StrDescripcion";

                //Asignamos los datos de la tabla que contiene esta nombre
                box.ValueMember = "IdRolEmpleado";

                connection.Close();

            }
            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("Error al cargar los proveedores a los combo");

            }
        }

        public void actualizarEmpleado(string identificador, string nombre, string documento, string direccion, string telefono,
            string email,string rol, string fechaingreso, string fecharetiro, string datosAdicionales)
        {

            conectar();
            try
            {
                DateTime fecha = DateTime.Now.Date;
                //Utilizamos Sp
                command = new SqlCommand("actualizar_Empleado", connection);
                //Tipo de proceso
                command.CommandType = CommandType.StoredProcedure;

                //Asignamos los datos
                command.Parameters.Add("@IdEmpleado", SqlDbType.Int).Value = int.Parse(identificador);
                command.Parameters.Add("@strNombre", SqlDbType.VarChar).Value = nombre;
                command.Parameters.Add("@NumDocumento", SqlDbType.BigInt).Value = long.Parse(documento);
                command.Parameters.Add("@StrDireccion", SqlDbType.VarChar).Value = direccion;
                command.Parameters.Add("@StrTelefono", SqlDbType.VarChar).Value = telefono;
                command.Parameters.Add("@StrEmail", SqlDbType.VarChar).Value = email;
                command.Parameters.Add("@IdRolEmpleado", SqlDbType.Int).Value = int.Parse(rol);
                command.Parameters.Add("@DtmIngreso", SqlDbType.DateTime).Value = fechaingreso;
                command.Parameters.Add("@DtmRetiro", SqlDbType.DateTime).Value = fecharetiro;
                command.Parameters.Add("@strDatosAdicionales", SqlDbType.VarChar).Value = datosAdicionales;
                command.Parameters.Add("@StrUsuarioModifico", SqlDbType.VarChar).Value = UsuarioActivo;
                command.Parameters.Add("@DtmFechaModifica", SqlDbType.DateTime).Value = fecha;

                //Ejecutamos el Query
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Actualización Exitosa");
            }
            catch (Exception rxr)
            {
                connection.Close();
                MessageBox.Show("Error al actualizar el empleado" +rxr);
            }

        }

        public void llenarComboSeguridad(ComboBox box)
        {
            conectar();
            try
            {
                //---------------------OTRA FORMA DE HACERLO

                command = new SqlCommand(" Select * from TBLSEGURIDAD", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                //Almacenamos dt
                box.DataSource = dt;

                //Mostamos los datos de la tabla que contiene esta nombre
                box.DisplayMember = "StrDescripcion";

                //Asignamos los datos de la tabla que contiene esta nombre
                box.ValueMember = "IdRolEmpleado";

                connection.Close();

            }
            catch (Exception)
            {
                connection.Close();
                MessageBox.Show("Error al cargar los proveedores a los combo");

            }
        }
        public bool traerDatosSeguridad(int empleado)
        {
            
            conectar();
            try
            {

                //Utilizamos Sp
                command = new SqlCommand(" Select * from TBLSEGURIDAD where IdEmpleado =" + empleado +"",connection);

                //Asignamos los datos
                //command.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usuario.Trim();
                //command.Parameters.Add("@Clave", SqlDbType.VarChar).Value = Contra.Trim();

                ////Hacemos la conexión
                //command.Connection = connection;
                //Ejecutamos el Query
                SqlDataReader reader = command.ExecuteReader();

                //Si existe alguna linea retorna true
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        frmAdminSeguridad.usuario = reader.GetString(2);
                        frmAdminSeguridad.clave = reader.GetString(3);

                    }
                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();

                    return false;

                }

            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("" + ex);
                return false;
                

            }

        }

        public void insertarRol(string rol)
        {
            conectar();
            try
            {
                //---------------------OTRA FORMA DE HACERLO

                command = new SqlCommand("Insert into tblroles values ('"+rol+"')", connection);

                command.ExecuteNonQuery();
                MessageBox.Show("Registro exitoso");
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Error al insertar el rol");

            }

        }

        public void actualizarSeguridad(string usuario, string contra, string code)
        {
            conectar();
            try
            {
                //---------------------OTRA FORMA DE HACERLO

                command = new SqlCommand("UPDATE tblSeguridad set StrUsuario='"+usuario+"', StrClave='"+contra+"' where IdEmpleado="+code+"", connection);

                command.ExecuteNonQuery();
                MessageBox.Show("Actualización exitosa");
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Error al actualizar el usuario");

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
