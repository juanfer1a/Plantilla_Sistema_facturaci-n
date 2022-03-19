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
        public int idFactura { get; set; }
        public int descuento { get; set; }
        public int totalIva { get; set; }
        public int totalFactura { get; set; }
        public int idcliente { get; set; }
        public int empleadoFactura { get; set; }
        public int estadoFactura { get; set; }
        public string fecha { get; set; }

        Acceso_datos cn = new Acceso_datos();

        public frmFacturas()
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

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            cn.llenarComboCliente(cxbClienteFactura);
            cn.llenarComboEmpleado(cxbEmpleadoFactura);
            cn.llenarComboEstadoFactura(cxbEstadoFactura);
            if (idFactura == 0)
            {//Registro nueva categiria
                lblEditarFactura.Text = "NUEVA FACTURA";
            }
            else
            {//Actulizar categoria
                lblEditarFactura.Text = "MODIFICAR FACTURA";
                txtNroFactura.Text = idFactura.ToString();
                txtDescuento.Text = descuento.ToString();
                txtDetalleFactura.Text = "Detalle factura";
                txtTotalFactura.Text = totalFactura.ToString();
                txtTotalIva.Text = totalIva.ToString();
                cxbClienteFactura.SelectedValue = idcliente;
                cxbEmpleadoFactura.SelectedValue = empleadoFactura;
                cxbEstadoFactura.SelectedValue = estadoFactura;
                DateTime dateTime = Convert.ToDateTime(fecha);
                dtpFechaFactura.Value = dateTime;
                
            }
        }
       

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            campoVacio(txtDescuento);
            campoVacio(txtDetalleFactura);
            campoVacio(txtNroFactura);
            campoVacio(txtTotalFactura);
            campoVacio(txtTotalIva);
            campoVacio(cxbClienteFactura);
            campoVacio(cxbEmpleadoFactura);
            campoVacio(cxbEstadoFactura);

            cn.actualizarFactura(txtNroFactura.Text, dtpFechaFactura.Value.ToString(), cxbClienteFactura.SelectedValue.ToString(),
                cxbEmpleadoFactura.SelectedValue.ToString(), txtDescuento.Text, txtTotalIva.Text, txtTotalFactura.Text, cxbEstadoFactura.SelectedValue.ToString()) ;
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
