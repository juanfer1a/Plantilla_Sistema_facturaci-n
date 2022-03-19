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
                string sentencia = $"EXEC CargaProducto {IdProducto}"; // CONSULTO REGISTRO DEL iDcLIENTE

                dt = Acceso.EjecutarComandoDatos(sentencia);
                foreach (DataRow row in dt.Rows)
                {
                    // LLENAMOS LOS CAMPOS CON EL REGISTRO CONSULTADO

                    txbIdProducto.Text = row[0].ToString();
                    txtNombreProducto.Text = row[1].ToString();
                    txtCodRef.Text = row[2].ToString();
                    txtPrecioCompra.Text = row[3].ToString();
                    txtPrecioVenta.Text = row[4].ToString();
                    txtCantStock.Text = row[5].ToString();
                    cboCategoria.Text = row[6].ToString();
                    txbDetalle.Text= row[7].ToString();
                }
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        // *************************************** ACTUALIZACIONES ********* ********************
        // ------- funciones que permiten el ingreso , retiro y actualización de la información de Clientes en la base de datos
        public bool Guardar()
        {
            Boolean actualizado = false;
            if (validar())
            {
                try
                {
                    if (txbIdProducto.Text == string.Empty)
                    {
                        txbIdProducto.Text = "0";
                    }
                    ;
                    Acceso_datos Acceso = new Acceso_datos();
                    string sentencia = $"Exec actualizar_Producto {txbIdProducto.Text},'{txtNombreProducto.Text}','{txtCodRef.Text}'," +
                        $"{txtPrecioCompra.Text},{txtPrecioVenta.Text},'{cboCategoria.Text}','{txbDetalle.Text}'," +
                        $"'Ninguna',{txtCantStock.Text},'Juan','{DateTime.Now.ToShortDateString()}'";
                    MessageBox.Show(Acceso.EjecutarComando(sentencia));
                    actualizado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("falló inserción: " + ex);
                    actualizado = false;
                }
            }
            return actualizado;
        }
        //FUNCIÓN QE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        private Boolean validar()
        {
            Boolean errorCampos = true;
            //if (!esNumerico(txbIdProducto.Text))
            //{
            //    MensajeError.SetError(txtNombreProducto, "Debe ingresar un valor numerico");
            //    txbIdProducto.Text = string.Empty;
            //    txtNombreProducto.Focus();
            //    errorCampos = false;
            //}
            //else
            //{
                
            //    MensajeError.SetError(txbIdProducto, string.Empty);
            //    //if (Convert.ToInt32(txbIdProducto.Text) < 1 )
            //    //{
            //    //    txbIdProducto.Text = "0";
            //    //}
            
            //}

            
            if (txtNombreProducto.Text == string.Empty)
            {
                MensajeError.SetError(txtNombreProducto, "Debe ingresar el nombre del producto");
                txtNombreProducto.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtNombreProducto, string.Empty); }

            if (txtCodRef.Text == string.Empty)
            {
                MensajeError.SetError(txtCodRef, "Debe ingresar el codigo de referencia del producto");
                txtCodRef.Focus();
                errorCampos = false;
            }
            else { MensajeError.SetError(txtCodRef, string.Empty); }
            if (!esNumerico(txtPrecioCompra.Text))
            {
                MensajeError.SetError(txtPrecioCompra, "Debe ingresar valores numericos");
                txtPrecioCompra.Focus();
                return false;
            }
            else { MensajeError.SetError(txtPrecioCompra, string.Empty); }

            if (!esNumerico(txtPrecioVenta.Text))
            {
                MensajeError.SetError(txtPrecioVenta, "Debe ingresar valores numericos");
                txtPrecioVenta.Focus();
                return false;
            }
            else { MensajeError.SetError(txtPrecioVenta, string.Empty); }

            if (!esNumerico(txtCantStock.Text))
            {
                MensajeError.SetError(txtCantStock, "Debe ingresar valores numericos");
                txtCantStock.Focus();
                return false;
            }
            MensajeError.SetError(txtCantStock, string.Empty);
            return errorCampos;
        }

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

        private void llenar_combo_categoria()
        {
            DataTable dt = new DataTable();
            Acceso_datos Acceso = new Acceso_datos(); // creamos un objeto con la clase Acceso_datos
            dt = Acceso.cargartabla("TBLCATEGORIA_PROD", "");
            cboCategoria.DataSource = dt;
            cboCategoria.DisplayMember = "strNombre";
            cboCategoria.ValueMember = "StrDescripcion";
            
            Acceso.CerrarBd();
        }


        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            llenar_combo_categoria();
            Llenar_Productos();
        }
    }
}
