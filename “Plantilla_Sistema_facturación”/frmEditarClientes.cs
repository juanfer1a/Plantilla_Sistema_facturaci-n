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
    public partial class frmEditarClientes : Form
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public int Documento { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }

        Acceso_datos cn = new Acceso_datos();

        public frmEditarClientes()
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

        private void frmEditarClientes_Load(object sender, EventArgs e)
        {
            if (IdCliente == 0)
            {//Registro nuevo
                lblTitulo.Text = "INGRESO NUEVO CLIENTE";
            }
            else
            {//Actulizar cliente
                lblTitulo.Text = "MODIFICAR CLIENTE";
                txtIdCliente.Text = IdCliente.ToString();
                txtNombreCliente.Text = Nombre;
                txtDocumento.Text = Documento.ToString();
                txtDireccion.Text = Direccion;
                txtTelefono.Text = Text.ToString();
                txtEmail.Text = Email;

            }
        }

        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            campoVacio(txtIdCliente);
            campoVacio(txtDireccion);
            campoVacio(txtDocumento);
            campoVacio(txtEmail);
            campoVacio(txtNombreCliente);
            campoVacio(txtTelefono);

            cn.actualizarCliente(txtIdCliente.Text,txtNombreCliente.Text,txtDocumento.Text,txtDireccion.Text,txtTelefono.Text,txtEmail.Text);
            
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
