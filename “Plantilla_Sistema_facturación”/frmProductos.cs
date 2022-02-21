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
        public frmProductos()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtCantStock, "Ingrese un valor");
            errorProvider1.SetError(txtCodRef, "Ingrese un valor");
            errorProvider1.SetError(txtIdCliente, "Ingrese un valor");
            errorProvider1.SetError(txtNombreProducto, "Ingrese un valor");
            errorProvider1.SetError(txtPrecioCompra, "Ingrese un valor");
            errorProvider1.SetError(txtPrecioVenta, "Ingrese un valor");
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
