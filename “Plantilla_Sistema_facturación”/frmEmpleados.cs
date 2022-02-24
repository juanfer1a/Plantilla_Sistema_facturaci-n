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
        public frmEmpleados()
        {
            InitializeComponent();
        }
        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            if (idEmpleado == 0)
            {
                lblAdminEmpleados.Text = "CREAR EMPLEADOS";
            }
            else
            {
                lblAdminEmpleados.Text = "EDITAR EMPLEADOS";
                txtNombreEmpleado.Text = "NOMBRE EMPLEADO";
                txtDocumentoEmpleado.Text = "DOCUMENTO";
                txtDireccionEmpleado.Text = "DIRECCION";
                txtTelefonoEmpleado.Text = "TELEFONO";
                txtEmailEmpleado.Text = "EMAIL";
                
            }
        }

        private void btnActuliazarEmpleado_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(cxbRolEmpleado, "Ingrese un valor");
            errorProvider1.SetError(txtDatosAdicionales, "Ingrese un valor");
            errorProvider1.SetError(txtDireccionEmpleado, "Ingrese un valor");
            errorProvider1.SetError(txtDocumentoEmpleado, "Ingrese un valor");
            errorProvider1.SetError(txtEmailEmpleado, "Ingrese un valor");
            errorProvider1.SetError(txtIdEmpleados, "Ingrese un valor");
            errorProvider1.SetError(txtNombreEmpleado, "Ingrese un valor");
            errorProvider1.SetError(txtTelefonoEmpleado, "Ingrese un valor");
        }

        private void btnSalirEmpleado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
