using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Plantilla_Sistema_facturación_
{
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

       

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDescuento, "Ingrese un valor");
            errorProvider1.SetError(txtDetalleFactura, "Ingrese un valor");
            errorProvider1.SetError(txtIdCliente, "Ingrese un valor");
            errorProvider1.SetError(txtTotalFactura, "Ingrese un valor");
            errorProvider1.SetError(txtTotalIva, "Ingrese un valor");
            errorProvider1.SetError(cxbCliente, "Ingrese un valor");
            errorProvider1.SetError(cxbEmpleado, "Ingrese un valor");
            errorProvider1.SetError(cxbEstadoFactura, "Ingrese un valor");
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
