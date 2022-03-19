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
                txbNroFactura.Text = NroFactura.ToString();
                txtDescuento.Text = "Descuento";
                txtDetalleFactura.Text = "Detalle factura";
                txtTotalFactura.Text = "Total factura";
                txtTotalIva.Text = "Total iva";
                cboClienteFactura.Text = "Cliente factura";
                cboEmpleadoFactura.Text = "Empleado factura";
                cboEstadoFactura.Text = "Estado factura";
            }
        }
       

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MensajeError.SetError(txtDescuento, "Ingrese un valor");
            MensajeError.SetError(txtDetalleFactura, "Ingrese un valor");
            MensajeError.SetError(txbNroFactura, "Ingrese un valor");
            MensajeError.SetError(txtTotalFactura, "Ingrese un valor");
            MensajeError.SetError(txtTotalIva, "Ingrese un valor");
            MensajeError.SetError(cboClienteFactura, "Ingrese un valor");
            MensajeError.SetError(cboEmpleadoFactura, "Ingrese un valor");
            MensajeError.SetError(cboEstadoFactura, "Ingrese un valor");
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
