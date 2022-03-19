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
    public partial class frmEmpleados : Form
    {
        public int idEmpleado { get; set; }
        public string nombre { get; set; }
        public long documento { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public int rol { get; set; }
        public string fechaIngreso { get; set; }
        public string fechaRetiro { get; set; }
        public string datosAdicionales { get; set; }
        public frmEmpleados()
        {
            InitializeComponent();
        }
        Acceso_datos cn = new Acceso_datos();
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
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            cn.llenarComboRol(cxbRolEmpleado);

            if (idEmpleado == 0)
            {
                lblAdminEmpleados.Text = "CREAR EMPLEADOS";
            }
            else
            {
                lblAdminEmpleados.Text = "EDITAR EMPLEADOS";
                txtIdEmpleados.Text = idEmpleado.ToString();
                txtNombreEmpleado.Text = nombre;
                txtDocumentoEmpleado.Text = documento.ToString();
                txtDireccionEmpleado.Text = direccion;
                txtTelefonoEmpleado.Text = telefono;
                txtEmailEmpleado.Text = email;
                cxbRolEmpleado.SelectedValue = rol;
                txtDatosAdicionales.Text = datosAdicionales;
                DateTime dateTime = Convert.ToDateTime(fechaIngreso);
                dtpFechaIngreso.Value = dateTime;
                DateTime dateTime2 = Convert.ToDateTime(fechaRetiro);
                dtpFechaRetiro.Value = dateTime2;

            }
        }

        private void btnActuliazarEmpleado_Click(object sender, EventArgs e)
        {
            campoVacio(cxbRolEmpleado);
            campoVacio(txtDatosAdicionales);
            campoVacio(txtDireccionEmpleado);
            campoVacio(txtDocumentoEmpleado);
            campoVacio(txtEmailEmpleado);
            campoVacio(txtIdEmpleados);
            campoVacio(txtNombreEmpleado);
            campoVacio(txtTelefonoEmpleado);
            cn.actualizarEmpleado(txtIdEmpleados.Text,txtNombreEmpleado.Text,txtDocumentoEmpleado.Text,txtDireccionEmpleado.Text,
                txtTelefonoEmpleado.Text,txtEmailEmpleado.Text, cxbRolEmpleado.SelectedValue.ToString(), dtpFechaIngreso.Value.ToString(),
                dtpFechaRetiro.Value.ToString(),txtDatosAdicionales.Text);
        }

        private void btnSalirEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
