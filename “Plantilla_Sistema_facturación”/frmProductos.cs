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
        public string Nombre { get; set; }
        public string Referencia { get; set; }
        public float PrecioCompra { get; set; }
        public float PrecioVenta { get; set; }
        public string Detalle { get; set; }
        public string Foto { get; set; }
        public int Cantidad { get; set; }

        Acceso_datos cn = new Acceso_datos();

        public frmProductos()
        {
            InitializeComponent();
        }

        public void campoVacio(System.Windows.Forms.Control campo)
        {
            if (campo.Text == String.Empty)
            {
                errorProvider1.SetError(campo, "Se debe llenar este campo");
            }
            else
            {
                errorProvider1.SetError(campo, "");
            }
        }

        private void frmProductos_Load_1(object sender, EventArgs e)
        {
            cn.llenarComboBoxCategoria(cboCategoria);
            if (IdProducto == 0)
            {//Registro nuevo
                lblTituloProducto.Text = "INGRESO NUEVO PRODUCTO";
            }
            else
            {//Actulizar Producto
                lblTituloProducto.Text = "MODIFICAR PRODUCTO";
                txtNombreProducto.Text = Nombre;
                txtIdProducto.Text = IdProducto.ToString();
                txtCodRef.Text = Referencia;
                txtPrecioCompra.Text = PrecioCompra.ToString();
                txtPrecioVenta.Text = PrecioVenta.ToString();
                txtDetalleProducto.Text = Detalle;
                txtRutaImagen.Text = Foto;
                txtCantStock.Text = Cantidad.ToString();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            campoVacio(txtCantStock);
            campoVacio(txtCodRef);
            campoVacio(txtIdProducto);
            campoVacio(txtNombreProducto);
            campoVacio(txtPrecioCompra);
            campoVacio(txtPrecioVenta);
            campoVacio(txtDetalleProducto);
            campoVacio(txtRutaImagen);

            string categoria = cboCategoria.SelectedValue.ToString();
            cn.actualizarProductos(txtIdProducto.Text, txtNombreProducto.Text, txtCodRef.Text, txtPrecioCompra.Text, txtPrecioVenta.Text, categoria,
                txtCantStock.Text,txtDetalleProducto.Text,txtRutaImagen.Text);
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
