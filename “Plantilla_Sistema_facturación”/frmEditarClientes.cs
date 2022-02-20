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

        public frmEditarClientes()
        {
            InitializeComponent();
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
                txtNombreCliente.Text = "Nombre Apellido1";
                txtDocumento.Text = "345345435";
                txtDireccion.Text = "Direccion del cliente";
                txtTelefono.Text = "23452345";
            }
        }
    }
}
