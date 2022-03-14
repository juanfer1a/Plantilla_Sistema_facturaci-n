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
    public partial class frmCategoriasProductos : Form
    {
        public int IdCategoria;
        public frmCategoriasProductos()
        {
            InitializeComponent();
        }
        private void frmCategoriasProductos_Load(object sender, EventArgs e)
        {
            if (IdCategoria == 0)
            {//Registro nueva categiria
                lblCatProduc.Text = "CREAR NUEVA CATEGORIA";
            }
            else
            {//Actulizar categoria
                lblCatProduc.Text = "MODIFICAR CATEGORIA";
                txtIdCategoria.Text = IdCategoria.ToString();
                txtNombreCategoria.Text = "Nombre Categoria";
            }

        }



        private void btnActualizarCatProduc_Click(object sender, EventArgs e)
        {

            MensajeError.SetError(txtIdCategoria, "Ingrese un valor");
            MensajeError.SetError(txtNombreCategoria, "Ingrese un valor");


        }
        //FUNCIÓN QE PERMITE VALIDAR LOS CAMPOS DEL FORMULARIO
        //private Boolean validar()
        //{
            //Boolean errorCampos = true;
            //if (txtNombreCategoria.Text == string.Empty)
            //{
            //    MensajeError.SetError(txtNombreCategoria, "debeingresar el nombre del Cliente");
            //    txtNombreCategoria.Focus();
            //    errorCampos = false;
            //}
            //else { MensajeError.SetError(txtNombreCliente, ""); }
            //if (txtDocumento.Text == "")
            //{
            //    MensajeError.SetError(txtDocumento, "debe ingresar el documento");
            //    txtDocumento.Focus();
            //    errorCampos = false;
            //}
            //else { MensajeError.SetError(txtDocumento, ""); }
            //if (!esNumerico(txtDocumento.Text))
            //{
            //    MensajeError.SetError(txtDocumento, "El Documento debe ser numerico");
            //    txtDocumento.Focus();
            //    return false;
            //}
            //MensajeError.SetError(txtDocumento, "");
            //return errorCampos;
        //}
        private void lblSalirCatProduc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
