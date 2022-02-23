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
        public int NroFactura { get; set; }
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            if (NroFactura == 0)
            {//Registro nueva categiria
                lblEditarFactura.Text = "NUEVA FACTURA";
            }
            else
            {//Actulizar categoria
                lblEditarFactura.Text = "MODIFICAR FACTURA";
                txtNroFactura.Text = NroFactura.ToString();
                txtDescuento.Text = "Descuento";
                txtDetalleFactura.Text = "Detalle factura";
                txtTotalFactura.Text = "Total factura";
                txtTotalIva.Text = "Total iva";
                cxbClienteFactura.Text = "Cliente factura";
                cxbEmpleadoFactura.Text = "Empleado factura";
                cxbEstadoFactura.Text = "Estado factura";
            }
        }
       

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDescuento, "Ingrese un valor");
            errorProvider1.SetError(txtDetalleFactura, "Ingrese un valor");
            errorProvider1.SetError(txtNroFactura, "Ingrese un valor");
            errorProvider1.SetError(txtTotalFactura, "Ingrese un valor");
            errorProvider1.SetError(txtTotalIva, "Ingrese un valor");
            errorProvider1.SetError(cxbClienteFactura, "Ingrese un valor");
            errorProvider1.SetError(cxbEmpleadoFactura, "Ingrese un valor");
            errorProvider1.SetError(cxbEstadoFactura, "Ingrese un valor");
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
