using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace _Plantilla_Sistema_facturación_
{
    public partial class frmProductos : Form
    {
        public int IdProducto { get; set; }
        public frmProductos()
        {
            InitializeComponent();
        }
        private void frmProductos_Load(object sender, EventArgs e)
        {

            
        }

        DataTable dt = new DataTable(); // CREAMOS EL OBJETO DE TIPO DATATABLE PARA ALMACENAR LO CONSULTADO
        Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
        public void Llenar_Productos()
        {
            if (IdProducto == 0)
            {//Registro nuevo
                lblTituloProducto.Text = "INGRESO NUEVO PRODUCTO";
            }
            else
            {//Actulizar cliente
             //ACTUALIZAR EL REGISTRO CON EL ID PASADO
                string sentencia = $"select * from TBLPRODUCTOS where IdProducto = {IdProducto}"; // CONSULTO REGISTRO DEL iDcLIENTE

                dt = Acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows)
                {
                    // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO

                    txtNombreProducto.Text = row[1].ToString();
                    txtCodRef.Text = row[2].ToString();
                    txtPrecioCompra.Text = row[3].ToString();
                    txtPrecioVenta.Text = row[4].ToString();
                    txtCantStock.Text = row[5].ToString();
                    cxbCategoria.Text = row[8].ToString();
                }
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }

        // *************************************** ACTUALIZACIONES ********* ********************
        // ------- funciones que permiten el ingreso , retiro y actualización de la información de Clientes en la base de datos
        public bool Guardar()
        {
            Boolean actualizado = false;
           // if (validar())
            //{
                try
                {
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec actualizar_Producto '{txtNombreProducto.Text}',{txtCodRef.Text} ,'{txtPrecioCompra.Text}','{txtPrecioVenta.Text}', '{txtCantStock.Text}','Juan','{DateTime.Now.ToShortDateString()}'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                    actualizado = false;
                }
           // }
            return actualizado;
        }
        //FUNCIÓN QE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        //private Boolean validar()
        //{
        //    Boolean errorCampos = true;
        //    if (txtNombreProducto.Text == string.Empty)
        //    {
        //        MensajeError.SetError(txtNombreProducto, "Debe ingresar el nombre del producto");
        //        txtNombreProducto.Focus();
        //        errorCampos = false;
        //    }
        //    else { MensajeError.SetError(txtNombreProducto, ""); }
        //    if (txtCodRef.Text == "")
        //    {
        //        MensajeError.SetError(, "debe ingresar el codigo de referencia del producto");
        //        txtCodRef.Focus();
        //        errorCampos = false;
        //    }
        //    else { MensajeError.SetError(txtCodRef, ""); }
        //    if (!esNumerico(txtDocumento.Text))
        //    {
        //        MensajeError.SetError(txtDocumento, "El Documento debe ser numerico");
        //        txtDocumento.Focus();
        //        return false;
        //    }
        //    MensajeError.SetError(txtDocumento, "");
        //    return errorCampos;
        //}

        //función para validar si un valor dado es numerico
        private bool esNumerico(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
